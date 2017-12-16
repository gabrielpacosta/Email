using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;

namespace Email
{

    public partial class Form1 : Form
    {

        List<String> remetente = new List<String>();
        List<String> destinario = new List<String>();
        int indiceDestinario = 0;
        string arquivoImg = "https://image.ibb.co/bvExQR/Itau.jpg";
        string corpo;

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
            if ((string.IsNullOrWhiteSpace(txbDestinatarios.Text)) || (string.IsNullOrWhiteSpace(txbRemetente.Text)) || (numEmails.Value <= 0) || (string.IsNullOrWhiteSpace(txbAssunto.Text)))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Iniciar a progressBar
            progressBar.Maximum = destinario.Count();
            progressBar.Value = 0;

            // Executa o primeiro laço até o número de destinátários se esgotar
            while (indiceDestinario < destinario.Count())
            {
                //Executa para cada remetente
                for (int i = 0; i < remetente.Count(); i += 2)
                {
                    //  Verifica se estourou o número de destinaários
                    if (indiceDestinario >= destinario.Count())
                        break;

                    // Inicia a conexão smtp para o remetente atual do laço
                    using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential(remetente[i], remetente[i + 1]);

                        // Algoritmo padrão de envio de email
                        using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                        {
                            mail.From = new System.Net.Mail.MailAddress(remetente[i]);

                            //Dentro de cada remetente, manda o número de emails especificado no formulário
                            for (int z = 0; z < (int)numEmails.Value; z++)
                            {
                                //  Verifica se estourou o número de destinaários
                                if (indiceDestinario >= destinario.Count())
                                    break;
                                mail.To.Add(new System.Net.Mail.MailAddress(destinario[indiceDestinario]));
                                indiceDestinario++;
                            }

                            corpo = "<p style='text - align: center; font-size:5px;'>Caso n&atilde;o consiga visualizar,&nbsp;<a href='" + arquivoImg  + " target='_blank' rel='noopener'>clique aqui.</a></p><p><img src ='"+ arquivoImg +"' alt='Banner TSP'/></p>";
                            mail.IsBodyHtml = true;
                            mail.Subject = txbAssunto.Text;
                            mail.Body = corpo;
                            
                            //Envia a mensagem e computa mais um valor para a variável
                            await smtp.SendMailAsync(mail);
                            lblEnviados.Text = "Enviados: " + indiceDestinario;
                            progressBar.Value = indiceDestinario;
                            lblPB.Text = Math.Round(((double)progressBar.Value / progressBar.Maximum) * 100, 0).ToString() + "%";

                        }
                    }
                }
            }

            // Zera as variáveis
            indiceDestinario = 0;
            destinario.Clear();
            remetente.Clear();
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
    }
}
