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

namespace Email
{

    public partial class Form1 : Form
    {

        List<String> remetente = new List<String>();
        List<String> destinario = new List<String>();
        int indiceDestinario = 0;

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

                        //Dentro de cada remetente, manda o número de emails especificado no formulário
                        for (int z = 0; z < (int)numEmails.Value; z++)
                        {
                            //  Verifica se estourou o número de destinaários
                            if (indiceDestinario >= destinario.Count())
                                break;

                            // Algoritmo padrão de envio de email
                            using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                            {
                                mail.From = new System.Net.Mail.MailAddress(remetente[i]);

                                if (!string.IsNullOrWhiteSpace(txbDestinatarios.Text))
                                {

                                    mail.To.Add(new System.Net.Mail.MailAddress(destinario[indiceDestinario]));
                                }
                                else
                                {
                                    MessageBox.Show("Campo 'para' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                mail.IsBodyHtml = true;
                                mail.Subject = txbAssunto.Text;
                                mail.Body = txbMensagem.Text;

                                //Envia a mensagem e computa mais um valor para a variável
                                await smtp.SendMailAsync(mail);
                                indiceDestinario++;
                                lblEnviados.Text = "Enviados: " + indiceDestinario;
                                progressBar.Value += 1;
                                lblPB.Text = Math.Round(((double)progressBar.Value / progressBar.Maximum) * 100, 0).ToString() + "%";

                            }
                        }
                    }
                }
            }
            // Zera as variáveis
            indiceDestinario = 0;
            destinario.Clear();
            remetente.Clear();
        }
    }
}
