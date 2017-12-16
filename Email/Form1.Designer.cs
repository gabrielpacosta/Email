namespace Email
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRemetente = new System.Windows.Forms.Label();
            this.txbRemetente = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txbDestinatarios = new System.Windows.Forms.TextBox();
            this.txbAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txbMensagem = new System.Windows.Forms.RichTextBox();
            this.btnProcurarRemetente = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.numEmails = new System.Windows.Forms.NumericUpDown();
            this.lblNumEmail = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblPB = new System.Windows.Forms.Label();
            this.lblEnviados = new System.Windows.Forms.Label();
            this.lblImagem = new System.Windows.Forms.Label();
            this.txbImagem = new System.Windows.Forms.TextBox();
            this.btnProcurarImg = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.rbItau = new System.Windows.Forms.RadioButton();
            this.rbCetelem = new System.Windows.Forms.RadioButton();
            this.rbBMG = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemetente
            // 
            this.lblRemetente.AutoSize = true;
            this.lblRemetente.Location = new System.Drawing.Point(12, 9);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(62, 13);
            this.lblRemetente.TabIndex = 0;
            this.lblRemetente.Text = "Remetente:";
            // 
            // txbRemetente
            // 
            this.txbRemetente.Location = new System.Drawing.Point(108, 6);
            this.txbRemetente.Name = "txbRemetente";
            this.txbRemetente.Size = new System.Drawing.Size(201, 20);
            this.txbRemetente.TabIndex = 3;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(12, 77);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(71, 13);
            this.lblDestinatario.TabIndex = 4;
            this.lblDestinatario.Text = "Destinatários:";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(108, 100);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Arquivo de Texto |*.txt";
            this.openFileDialog1.Title = "Selecione um arquivo de texto.";
            // 
            // txbDestinatarios
            // 
            this.txbDestinatarios.Location = new System.Drawing.Point(108, 74);
            this.txbDestinatarios.Name = "txbDestinatarios";
            this.txbDestinatarios.Size = new System.Drawing.Size(201, 20);
            this.txbDestinatarios.TabIndex = 7;
            // 
            // txbAssunto
            // 
            this.txbAssunto.Location = new System.Drawing.Point(108, 167);
            this.txbAssunto.Name = "txbAssunto";
            this.txbAssunto.Size = new System.Drawing.Size(375, 20);
            this.txbAssunto.TabIndex = 9;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(12, 170);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(48, 13);
            this.lblAssunto.TabIndex = 8;
            this.lblAssunto.Text = "Assunto:";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 216);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(62, 13);
            this.lblMensagem.TabIndex = 10;
            this.lblMensagem.Text = "Mensagem:";
            // 
            // txbMensagem
            // 
            this.txbMensagem.Location = new System.Drawing.Point(108, 216);
            this.txbMensagem.Name = "txbMensagem";
            this.txbMensagem.Size = new System.Drawing.Size(366, 117);
            this.txbMensagem.TabIndex = 11;
            this.txbMensagem.Text = "";
            // 
            // btnProcurarRemetente
            // 
            this.btnProcurarRemetente.Location = new System.Drawing.Point(108, 32);
            this.btnProcurarRemetente.Name = "btnProcurarRemetente";
            this.btnProcurarRemetente.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarRemetente.TabIndex = 12;
            this.btnProcurarRemetente.Text = "Procurar";
            this.btnProcurarRemetente.UseVisualStyleBackColor = true;
            this.btnProcurarRemetente.Click += new System.EventHandler(this.btnProcurarRemetente_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            this.openFileDialog2.Filter = "Arquivo de Texto |*.txt";
            this.openFileDialog2.Title = "Selecione um arquivo de texto.";
            // 
            // numEmails
            // 
            this.numEmails.Location = new System.Drawing.Point(400, 32);
            this.numEmails.Name = "numEmails";
            this.numEmails.Size = new System.Drawing.Size(74, 20);
            this.numEmails.TabIndex = 13;
            // 
            // lblNumEmail
            // 
            this.lblNumEmail.AutoSize = true;
            this.lblNumEmail.Location = new System.Drawing.Point(383, 16);
            this.lblNumEmail.Name = "lblNumEmail";
            this.lblNumEmail.Size = new System.Drawing.Size(113, 13);
            this.lblNumEmail.TabIndex = 14;
            this.lblNumEmail.Text = "Emails por Remetente:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(399, 65);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 58);
            this.btnEnviar.TabIndex = 15;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 440);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(350, 21);
            this.progressBar.TabIndex = 16;
            // 
            // lblPB
            // 
            this.lblPB.AutoSize = true;
            this.lblPB.BackColor = System.Drawing.Color.Transparent;
            this.lblPB.Location = new System.Drawing.Point(379, 446);
            this.lblPB.Name = "lblPB";
            this.lblPB.Size = new System.Drawing.Size(21, 13);
            this.lblPB.TabIndex = 17;
            this.lblPB.Text = "0%";
            // 
            // lblEnviados
            // 
            this.lblEnviados.AutoSize = true;
            this.lblEnviados.Location = new System.Drawing.Point(411, 446);
            this.lblEnviados.Name = "lblEnviados";
            this.lblEnviados.Size = new System.Drawing.Size(63, 13);
            this.lblEnviados.TabIndex = 18;
            this.lblEnviados.Text = "Enviados: 0";
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(12, 353);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(47, 13);
            this.lblImagem.TabIndex = 19;
            this.lblImagem.Text = "Imagem:";
            // 
            // txbImagem
            // 
            this.txbImagem.Enabled = false;
            this.txbImagem.Location = new System.Drawing.Point(190, 350);
            this.txbImagem.Name = "txbImagem";
            this.txbImagem.Size = new System.Drawing.Size(293, 20);
            this.txbImagem.TabIndex = 20;
            // 
            // btnProcurarImg
            // 
            this.btnProcurarImg.Enabled = false;
            this.btnProcurarImg.Location = new System.Drawing.Point(108, 348);
            this.btnProcurarImg.Name = "btnProcurarImg";
            this.btnProcurarImg.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarImg.TabIndex = 21;
            this.btnProcurarImg.Text = "Procurar";
            this.btnProcurarImg.UseVisualStyleBackColor = true;
            this.btnProcurarImg.Click += new System.EventHandler(this.btnProcurarImg_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog1";
            this.openFileDialog3.Title = "Selecione uma imagem";
            // 
            // rbItau
            // 
            this.rbItau.AutoSize = true;
            this.rbItau.Checked = true;
            this.rbItau.Location = new System.Drawing.Point(108, 404);
            this.rbItau.Name = "rbItau";
            this.rbItau.Size = new System.Drawing.Size(43, 17);
            this.rbItau.TabIndex = 22;
            this.rbItau.TabStop = true;
            this.rbItau.Text = "Itaú";
            this.rbItau.UseVisualStyleBackColor = true;
            this.rbItau.CheckedChanged += new System.EventHandler(this.rbItau_CheckedChanged);
            // 
            // rbCetelem
            // 
            this.rbCetelem.AutoSize = true;
            this.rbCetelem.Location = new System.Drawing.Point(181, 404);
            this.rbCetelem.Name = "rbCetelem";
            this.rbCetelem.Size = new System.Drawing.Size(63, 17);
            this.rbCetelem.TabIndex = 23;
            this.rbCetelem.Text = "Cetelem";
            this.rbCetelem.UseVisualStyleBackColor = true;
            this.rbCetelem.CheckedChanged += new System.EventHandler(this.rbCetelem_CheckedChanged);
            // 
            // rbBMG
            // 
            this.rbBMG.AutoSize = true;
            this.rbBMG.Location = new System.Drawing.Point(271, 404);
            this.rbBMG.Name = "rbBMG";
            this.rbBMG.Size = new System.Drawing.Size(49, 17);
            this.rbBMG.TabIndex = 24;
            this.rbBMG.Text = "BMG";
            this.rbBMG.UseVisualStyleBackColor = true;
            this.rbBMG.CheckedChanged += new System.EventHandler(this.rbBMG_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 468);
            this.Controls.Add(this.rbBMG);
            this.Controls.Add(this.rbCetelem);
            this.Controls.Add(this.rbItau);
            this.Controls.Add(this.btnProcurarImg);
            this.Controls.Add(this.txbImagem);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.lblEnviados);
            this.Controls.Add(this.lblPB);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblNumEmail);
            this.Controls.Add(this.numEmails);
            this.Controls.Add(this.btnProcurarRemetente);
            this.Controls.Add(this.txbMensagem);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txbAssunto);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.txbDestinatarios);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.txbRemetente);
            this.Controls.Add(this.lblRemetente);
            this.Name = "Form1";
            this.Text = "Email TSP";
            ((System.ComponentModel.ISupportInitialize)(this.numEmails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemetente;
        private System.Windows.Forms.TextBox txbRemetente;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txbDestinatarios;
        private System.Windows.Forms.TextBox txbAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.RichTextBox txbMensagem;
        private System.Windows.Forms.Button btnProcurarRemetente;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.NumericUpDown numEmails;
        private System.Windows.Forms.Label lblNumEmail;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPB;
        private System.Windows.Forms.Label lblEnviados;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.TextBox txbImagem;
        private System.Windows.Forms.Button btnProcurarImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.RadioButton rbItau;
        private System.Windows.Forms.RadioButton rbCetelem;
        private System.Windows.Forms.RadioButton rbBMG;
    }
}

