using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Email
{

    public partial class Form1 : Form
    {

        List<String> remetente = new List<String>();
        List<String> destinario = new List<String>();
        int nEmailTotal, nEmailEnviado = 0;
        string arquivoImg = "https://image.ibb.co/bvExQR/Itau.jpg",arquivoLog, corpo;

        public Form1()
        {
            InitializeComponent();
        }



        private void btnProcurar_Click(object sender, EventArgs e)
        {
            // Abre o arquivo txt e carrega uma lista com os destinatarios
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txbDestinatarios.Text = openFileDialog1.FileName;
                destinario.Clear();
                destinario = File.ReadAllLines(openFileDialog1.FileName).ToList();

            }
        }

        // Abre o arquivo txt e carrega uma lista com os remetentes
        private void btnProcurarRemetente_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txbRemetente.Text = openFileDialog2.FileName;
                remetente.Clear();
                remetente = File.ReadAllLines(openFileDialog2.FileName).ToList();
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            //Verifica se os campos estão preenchidos
            if ((string.IsNullOrWhiteSpace(txbDestinatarios.Text)) || (string.IsNullOrWhiteSpace(txbRemetente.Text)) || (string.IsNullOrWhiteSpace(txbAssunto.Text)) || (string.IsNullOrWhiteSpace(txbDirLog.Text)) || (numPorRemetente.Value <= 0) || (numDe.Value <= 0) || (numAte.Value <= 0) || (numAte.Value < numDe.Value))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Bloqueia os controles
            ControlesBloqueados(true);

            //Define o número de email a ser enviado
            nEmailTotal = (int)(numAte.Value - numDe.Value + 1);

            //Iniciar a progressBar
            progressBar.Maximum = nEmailTotal;
            progressBar.Value = 0;
            lblPB.Text = "0%";

            // Executa o primeiro laço até o número emails especificados serem enviados
            while (nEmailEnviado < nEmailTotal)
            {
                //Executa para cada remetente
                for (int i = 0; i < remetente.Count(); i += 2)
                {
                    //  Verifica se estourou o número de emails a serem enviados
                    if (nEmailTotal <= nEmailEnviado)
                        break;

                    // Inicia a conexão smtp para o remetente atual do laço
                    using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential(remetente[i], remetente[i + 1]);

                        //Dentro de cada remetente, manda o número de emails especificado no formulário
                        for (int z = 0; z < (int)numPorRemetente.Value; z++)
                        {
                            //  Verifica se estourou o número de emails a serem enviados
                            if (nEmailTotal <= nEmailEnviado)
                                break;

                            // Algoritmo padrão de envio de email
                            using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                            {
                                mail.From = new System.Net.Mail.MailAddress(remetente[i]);
                                mail.To.Add(new System.Net.Mail.MailAddress(destinario[(int)numDe.Value + nEmailEnviado - 1]));

                                mail.IsBodyHtml = true;
                                mail.Subject = txbAssunto.Text;
                                mail.Body = "<p style='text - align: center; font-size:5px;'>Caso n&atilde;o consiga visualizar,&nbsp;<a href='" + arquivoImg + " target='_blank' rel='noopener'>clique aqui.</a></p> <a href='http://www.tsprecuperadora.com.br/' target='_blank'><p><img src='" + arquivoImg + "' alt='Banner TSP'/></p></a>";

                                //Envia o email, atualiza as variaveis e o log
                                await smtp.SendMailAsync(mail);
                            }

                            txbLog.Text += "Linha: " + (int)(numDe.Value + nEmailEnviado) + " - Email: " + destinario[(int)numDe.Value + nEmailEnviado - 1] + " enviado." + Environment.NewLine;

                            File.AppendAllText(arquivoLog, "Linha: " + (int)(numDe.Value + nEmailEnviado) + " - Email: " + destinario[(int)numDe.Value + nEmailEnviado - 1] + " enviado." + Environment.NewLine);

                            nEmailEnviado++;
                            lblEnviados.Text = "Enviados: " + nEmailEnviado + "/" + nEmailTotal;
                            progressBar.Value = nEmailEnviado;
                            lblPB.Text = Math.Round(((double)progressBar.Value / progressBar.Maximum) * 100, 0).ToString() + "%";
                           
                        }
                    }
                }
            }

            // Zera as variáveis, reativa os controles e manda messagebox
            nEmailEnviado = 0;

            MessageBox.Show("Todos os emails foram enviados com sucesso.", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ControlesBloqueados(false);
        }

        private void ControlesBloqueados(bool block)
        {
            btnEnviar.Enabled = !block;
            btnProcurar.Enabled = !block;
            btnProcurarLog.Enabled = !block;
            btnProcurarRemetente.Enabled = !block;
            txbAssunto.Enabled = !block;
            numAte.Enabled = !block;
            numDe.Enabled = !block;
            numPorRemetente.Enabled = !block;
            rbBMG.Enabled = !block;
            rbCetelem.Enabled = !block;
            rbItau.Enabled = !block;
        }

        private void rbItau_CheckedChanged(object sender, EventArgs e)
        {
            if (rbItau.Checked == true)
                arquivoImg = "https://image.ibb.co/bvExQR/Itau.jpg";
        }

        private void rbCetelem_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCetelem.Checked == true)
                arquivoImg = "https://image.ibb.co/jWLCQR/Cetelem.jpg";
        }

        private void rbBMG_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBMG.Checked == true)
                arquivoImg = "https://image.ibb.co/e823X6/BMG.jpg";
        }

        private void btnProcurarImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                txbImagem.Text = openFileDialog3.FileName;
                arquivoImg = @openFileDialog3.FileName;
            }
        }

        private void btnProcurarLog_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txbDirLog.Text = folderBrowserDialog.SelectedPath;
                arquivoLog = @folderBrowserDialog.SelectedPath + "\\" + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + " - LogEmailTSP.txt";
            }
        }

    }
}
