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
            this.lblLog = new System.Windows.Forms.Label();
            this.txbLog = new System.Windows.Forms.RichTextBox();
            this.btnProcurarRemetente = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.numPorRemetente = new System.Windows.Forms.NumericUpDown();
            this.lblNumEmail = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblImagem = new System.Windows.Forms.Label();
            this.txbImagem = new System.Windows.Forms.TextBox();
            this.btnProcurarImg = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.rbItau = new System.Windows.Forms.RadioButton();
            this.rbCetelem = new System.Windows.Forms.RadioButton();
            this.rbBMG = new System.Windows.Forms.RadioButton();
            this.lblDe = new System.Windows.Forms.Label();
            this.numDe = new System.Windows.Forms.NumericUpDown();
            this.lblAte = new System.Windows.Forms.Label();
            this.numAte = new System.Windows.Forms.NumericUpDown();
            this.btnProcurarLog = new System.Windows.Forms.Button();
            this.txbDirLog = new System.Windows.Forms.TextBox();
            this.lblDirLog = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblPB = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEnviados = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numPorRemetente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAte)).BeginInit();
            this.statusStrip.SuspendLayout();
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
            this.txbRemetente.Enabled = false;
            this.txbRemetente.Location = new System.Drawing.Point(175, 7);
            this.txbRemetente.Name = "txbRemetente";
            this.txbRemetente.Size = new System.Drawing.Size(172, 20);
            this.txbRemetente.TabIndex = 2;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(11, 50);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(71, 13);
            this.lblDestinatario.TabIndex = 3;
            this.lblDestinatario.Text = "Destinatários:";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(100, 44);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 4;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Arquivo destinatarios";
            this.openFileDialog1.Filter = "Arquivo de Texto |*.txt";
            this.openFileDialog1.Title = "Selecione um arquivo de texto.";
            // 
            // txbDestinatarios
            // 
            this.txbDestinatarios.Enabled = false;
            this.txbDestinatarios.Location = new System.Drawing.Point(174, 46);
            this.txbDestinatarios.Name = "txbDestinatarios";
            this.txbDestinatarios.Size = new System.Drawing.Size(172, 20);
            this.txbDestinatarios.TabIndex = 5;
            // 
            // txbAssunto
            // 
            this.txbAssunto.Location = new System.Drawing.Point(101, 148);
            this.txbAssunto.Name = "txbAssunto";
            this.txbAssunto.Size = new System.Drawing.Size(245, 20);
            this.txbAssunto.TabIndex = 19;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Location = new System.Drawing.Point(11, 151);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(48, 13);
            this.lblAssunto.TabIndex = 18;
            this.lblAssunto.Text = "Assunto:";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 187);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(49, 13);
            this.lblLog.TabIndex = 20;
            this.lblLog.Text = "Registro:";
            // 
            // txbLog
            // 
            this.txbLog.Location = new System.Drawing.Point(101, 184);
            this.txbLog.Name = "txbLog";
            this.txbLog.Size = new System.Drawing.Size(373, 117);
            this.txbLog.TabIndex = 21;
            this.txbLog.Text = "";
            // 
            // btnProcurarRemetente
            // 
            this.btnProcurarRemetente.Location = new System.Drawing.Point(101, 6);
            this.btnProcurarRemetente.Name = "btnProcurarRemetente";
            this.btnProcurarRemetente.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarRemetente.TabIndex = 1;
            this.btnProcurarRemetente.Text = "Procurar";
            this.btnProcurarRemetente.UseVisualStyleBackColor = true;
            this.btnProcurarRemetente.Click += new System.EventHandler(this.btnProcurarRemetente_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "Arquivo remetentes";
            this.openFileDialog2.Filter = "Arquivo de Texto |*.txt";
            this.openFileDialog2.Title = "Selecione um arquivo de texto.";
            // 
            // numPorRemetente
            // 
            this.numPorRemetente.Location = new System.Drawing.Point(400, 32);
            this.numPorRemetente.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numPorRemetente.Name = "numPorRemetente";
            this.numPorRemetente.Size = new System.Drawing.Size(74, 20);
            this.numPorRemetente.TabIndex = 13;
            // 
            // lblNumEmail
            // 
            this.lblNumEmail.AutoSize = true;
            this.lblNumEmail.Location = new System.Drawing.Point(383, 16);
            this.lblNumEmail.Name = "lblNumEmail";
            this.lblNumEmail.Size = new System.Drawing.Size(113, 13);
            this.lblNumEmail.TabIndex = 12;
            this.lblNumEmail.Text = "Emails por Remetente:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(398, 351);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(74, 23);
            this.btnEnviar.TabIndex = 22;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(11, 89);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(47, 13);
            this.lblImagem.TabIndex = 6;
            this.lblImagem.Text = "Imagem:";
            // 
            // txbImagem
            // 
            this.txbImagem.Enabled = false;
            this.txbImagem.Location = new System.Drawing.Point(174, 85);
            this.txbImagem.Name = "txbImagem";
            this.txbImagem.Size = new System.Drawing.Size(172, 20);
            this.txbImagem.TabIndex = 8;
            // 
            // btnProcurarImg
            // 
            this.btnProcurarImg.Enabled = false;
            this.btnProcurarImg.Location = new System.Drawing.Point(101, 84);
            this.btnProcurarImg.Name = "btnProcurarImg";
            this.btnProcurarImg.Size = new System.Drawing.Size(74, 23);
            this.btnProcurarImg.TabIndex = 7;
            this.btnProcurarImg.Text = "Procurar";
            this.btnProcurarImg.UseVisualStyleBackColor = true;
            this.btnProcurarImg.Click += new System.EventHandler(this.btnProcurarImg_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "Imagem";
            this.openFileDialog3.Title = "Selecione uma imagem";
            // 
            // rbItau
            // 
            this.rbItau.AutoSize = true;
            this.rbItau.Checked = true;
            this.rbItau.Location = new System.Drawing.Point(101, 113);
            this.rbItau.Name = "rbItau";
            this.rbItau.Size = new System.Drawing.Size(43, 17);
            this.rbItau.TabIndex = 9;
            this.rbItau.TabStop = true;
            this.rbItau.Text = "Itaú";
            this.rbItau.UseVisualStyleBackColor = true;
            this.rbItau.CheckedChanged += new System.EventHandler(this.rbItau_CheckedChanged);
            // 
            // rbCetelem
            // 
            this.rbCetelem.AutoSize = true;
            this.rbCetelem.Location = new System.Drawing.Point(174, 113);
            this.rbCetelem.Name = "rbCetelem";
            this.rbCetelem.Size = new System.Drawing.Size(63, 17);
            this.rbCetelem.TabIndex = 10;
            this.rbCetelem.Text = "Cetelem";
            this.rbCetelem.UseVisualStyleBackColor = true;
            this.rbCetelem.CheckedChanged += new System.EventHandler(this.rbCetelem_CheckedChanged);
            // 
            // rbBMG
            // 
            this.rbBMG.AutoSize = true;
            this.rbBMG.Location = new System.Drawing.Point(264, 113);
            this.rbBMG.Name = "rbBMG";
            this.rbBMG.Size = new System.Drawing.Size(49, 17);
            this.rbBMG.TabIndex = 11;
            this.rbBMG.Text = "BMG";
            this.rbBMG.UseVisualStyleBackColor = true;
            this.rbBMG.CheckedChanged += new System.EventHandler(this.rbBMG_CheckedChanged);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(395, 62);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(83, 13);
            this.lblDe.TabIndex = 14;
            this.lblDe.Text = "A partir da linha:";
            // 
            // numDe
            // 
            this.numDe.Location = new System.Drawing.Point(400, 78);
            this.numDe.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDe.Name = "numDe";
            this.numDe.Size = new System.Drawing.Size(74, 20);
            this.numDe.TabIndex = 15;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(407, 112);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(60, 13);
            this.lblAte.TabIndex = 16;
            this.lblAte.Text = "Até a linha:";
            // 
            // numAte
            // 
            this.numAte.Location = new System.Drawing.Point(400, 128);
            this.numAte.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAte.Name = "numAte";
            this.numAte.Size = new System.Drawing.Size(74, 20);
            this.numAte.TabIndex = 17;
            // 
            // btnProcurarLog
            // 
            this.btnProcurarLog.Location = new System.Drawing.Point(205, 305);
            this.btnProcurarLog.Name = "btnProcurarLog";
            this.btnProcurarLog.Size = new System.Drawing.Size(74, 23);
            this.btnProcurarLog.TabIndex = 26;
            this.btnProcurarLog.Text = "Procurar";
            this.btnProcurarLog.UseVisualStyleBackColor = true;
            this.btnProcurarLog.Click += new System.EventHandler(this.btnProcurarLog_Click);
            // 
            // txbDirLog
            // 
            this.txbDirLog.Enabled = false;
            this.txbDirLog.Location = new System.Drawing.Point(278, 307);
            this.txbDirLog.Name = "txbDirLog";
            this.txbDirLog.Size = new System.Drawing.Size(196, 20);
            this.txbDirLog.TabIndex = 27;
            // 
            // lblDirLog
            // 
            this.lblDirLog.AutoSize = true;
            this.lblDirLog.Location = new System.Drawing.Point(98, 310);
            this.lblDirLog.Name = "lblDirLog";
            this.lblDirLog.Size = new System.Drawing.Size(101, 13);
            this.lblDirLog.TabIndex = 28;
            this.lblDirLog.Text = "Diretório do registro:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.lblPB,
            this.lblEnviados});
            this.statusStrip.Location = new System.Drawing.Point(0, 389);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(513, 22);
            this.statusStrip.TabIndex = 29;
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(280, 16);
            // 
            // lblPB
            // 
            this.lblPB.Margin = new System.Windows.Forms.Padding(25, 3, 0, 2);
            this.lblPB.Name = "lblPB";
            this.lblPB.Size = new System.Drawing.Size(23, 17);
            this.lblPB.Text = "0%";
            // 
            // lblEnviados
            // 
            this.lblEnviados.Margin = new System.Windows.Forms.Padding(25, 3, 0, 2);
            this.lblEnviados.Name = "lblEnviados";
            this.lblEnviados.Size = new System.Drawing.Size(77, 17);
            this.lblEnviados.Text = "Enviados: 0/0";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Selecione o diretório para salvar o arquivo de registro.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 411);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lblDirLog);
            this.Controls.Add(this.txbDirLog);
            this.Controls.Add(this.btnProcurarLog);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.numAte);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.numDe);
            this.Controls.Add(this.rbBMG);
            this.Controls.Add(this.rbCetelem);
            this.Controls.Add(this.rbItau);
            this.Controls.Add(this.btnProcurarImg);
            this.Controls.Add(this.txbImagem);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblNumEmail);
            this.Controls.Add(this.numPorRemetente);
            this.Controls.Add(this.btnProcurarRemetente);
            this.Controls.Add(this.txbLog);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txbAssunto);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.txbDestinatarios);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.txbRemetente);
            this.Controls.Add(this.lblRemetente);
            this.Name = "Form1";
            this.Text = "Email TSP";
            ((System.ComponentModel.ISupportInitialize)(this.numPorRemetente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAte)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.RichTextBox txbLog;
        private System.Windows.Forms.Button btnProcurarRemetente;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.NumericUpDown numPorRemetente;
        private System.Windows.Forms.Label lblNumEmail;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.TextBox txbImagem;
        private System.Windows.Forms.Button btnProcurarImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.RadioButton rbItau;
        private System.Windows.Forms.RadioButton rbCetelem;
        private System.Windows.Forms.RadioButton rbBMG;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.NumericUpDown numDe;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.NumericUpDown numAte;
        private System.Windows.Forms.Button btnProcurarLog;
        private System.Windows.Forms.TextBox txbDirLog;
        private System.Windows.Forms.Label lblDirLog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblPB;
        private System.Windows.Forms.ToolStripStatusLabel lblEnviados;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

