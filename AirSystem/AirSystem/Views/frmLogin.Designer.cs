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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            resources.ApplyResources(this.lblSenha, "lblSenha");
            this.lblSenha.Name = "lblSenha";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // btnEntrar
            // 
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // BtnSair
            // 
            resources.ApplyResources(this.BtnSair, "BtnSair");
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnNovoUsuario
            // 
            resources.ApplyResources(this.btnNovoUsuario, "btnNovoUsuario");
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Tag = "";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtSenha
            // 
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // comboIdiomas
            // 
            resources.ApplyResources(this.comboIdiomas, "comboIdiomas");
            this.comboIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIdiomas.FormattingEnabled = true;
            this.comboIdiomas.Items.AddRange(new object[] {
            resources.GetString("comboIdiomas.Items"),
            resources.GetString("comboIdiomas.Items1")});
            this.comboIdiomas.Name = "comboIdiomas";
            this.comboIdiomas.SelectedIndexChanged += new System.EventHandler(this.comboIdiomas_SelectedIndexChanged);
            // 
            // lblIdioma
            // 
            resources.ApplyResources(this.lblIdioma, "lblIdioma");
            this.lblIdioma.Name = "lblIdioma";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblHora
            // 
            resources.ApplyResources(this.lblHora, "lblHora");
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHora.Name = "lblHora";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblSenha2
            // 
            resources.ApplyResources(this.lblSenha2, "lblSenha2");
            this.lblSenha2.Name = "lblSenha2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AirSystem.Properties.Resources.aviao;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::AirSystem.Properties.Resources.companhia;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
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
            this.Name = "frmLogin";
            this.Tag = "";
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
        private System.Windows.Forms.Timer timer1;
    }
}

