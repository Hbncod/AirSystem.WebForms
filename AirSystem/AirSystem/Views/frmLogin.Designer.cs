namespace AirSystem
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.comboIdiomas = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(385, 246);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(54, 19);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(385, 180);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrar.Location = new System.Drawing.Point(389, 341);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(54, 23);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.Location = new System.Drawing.Point(449, 341);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(46, 23);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoUsuario.Location = new System.Drawing.Point(501, 341);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(83, 23);
            this.btnNovoUsuario.TabIndex = 4;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(389, 202);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(195, 20);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.Tag = "";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(389, 247);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(195, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // comboIdiomas
            // 
            this.comboIdiomas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboIdiomas.FormattingEnabled = true;
            this.comboIdiomas.Location = new System.Drawing.Point(389, 292);
            this.comboIdiomas.Name = "comboIdiomas";
            this.comboIdiomas.Size = new System.Drawing.Size(195, 21);
            this.comboIdiomas.TabIndex = 7;
            // 
            // lblIdioma
            // 
            this.lblIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(385, 270);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(63, 19);
            this.lblIdioma.TabIndex = 8;
            this.lblIdioma.Text = "Idioma";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(521, 17);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(22, 26);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "0";
            // 
            // lblSenha2
            // 
            this.lblSenha2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha2.Location = new System.Drawing.Point(385, 225);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(54, 19);
            this.lblSenha2.TabIndex = 13;
            this.lblSenha2.Text = "Senha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AirSystem.Properties.Resources.aviao;
            this.pictureBox2.Location = new System.Drawing.Point(24, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(338, 318);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::AirSystem.Properties.Resources.companhia;
            this.pictureBox1.Location = new System.Drawing.Point(389, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.lblSenha2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.comboIdiomas);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmLogin";
            this.Tag = "";
            this.Text = "+";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox comboIdiomas;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSenha2;
    }
}

