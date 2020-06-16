namespace AirSystem.Views
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmSenha = new System.Windows.Forms.Label();
            this.txtboxNome = new System.Windows.Forms.TextBox();
            this.txtboxSobrenome = new System.Windows.Forms.TextBox();
            this.txtboxEndereco = new System.Windows.Forms.TextBox();
            this.txtboxNumero = new System.Windows.Forms.TextBox();
            this.txtboxUsuario = new System.Windows.Forms.TextBox();
            this.txtboxSenha = new System.Windows.Forms.TextBox();
            this.txtboxConfirmSenha = new System.Windows.Forms.TextBox();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.checkAdm = new System.Windows.Forms.CheckBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.Name = "lblNome";
            // 
            // lblEndereco
            // 
            resources.ApplyResources(this.lblEndereco, "lblEndereco");
            this.lblEndereco.Name = "lblEndereco";
            // 
            // lblNascimento
            // 
            resources.ApplyResources(this.lblNascimento, "lblNascimento");
            this.lblNascimento.Name = "lblNascimento";
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
            // lblConfirmSenha
            // 
            resources.ApplyResources(this.lblConfirmSenha, "lblConfirmSenha");
            this.lblConfirmSenha.Name = "lblConfirmSenha";
            // 
            // txtboxNome
            // 
            this.txtboxNome.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.txtboxNome, "txtboxNome");
            this.txtboxNome.Name = "txtboxNome";
            this.txtboxNome.TextChanged += new System.EventHandler(this.txtboxNome_TextChanged);
            this.txtboxNome.Enter += new System.EventHandler(this.txtboxNome_Enter);
            this.txtboxNome.Leave += new System.EventHandler(this.txtboxNome_Leave);
            // 
            // txtboxSobrenome
            // 
            this.txtboxSobrenome.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.txtboxSobrenome, "txtboxSobrenome");
            this.txtboxSobrenome.Name = "txtboxSobrenome";
            this.txtboxSobrenome.Enter += new System.EventHandler(this.txtboxSobrenome_Enter);
            this.txtboxSobrenome.Leave += new System.EventHandler(this.txtboxSobrenome_Leave);
            // 
            // txtboxEndereco
            // 
            this.txtboxEndereco.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.txtboxEndereco, "txtboxEndereco");
            this.txtboxEndereco.Name = "txtboxEndereco";
            this.txtboxEndereco.Enter += new System.EventHandler(this.txtboxEndereco_Enter);
            this.txtboxEndereco.Leave += new System.EventHandler(this.txtboxEndereco_Leave);
            // 
            // txtboxNumero
            // 
            this.txtboxNumero.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.txtboxNumero, "txtboxNumero");
            this.txtboxNumero.Name = "txtboxNumero";
            this.txtboxNumero.Enter += new System.EventHandler(this.txtboxNumero_Enter);
            this.txtboxNumero.Leave += new System.EventHandler(this.txtboxNumero_Leave);
            // 
            // txtboxUsuario
            // 
            this.txtboxUsuario.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.txtboxUsuario, "txtboxUsuario");
            this.txtboxUsuario.Name = "txtboxUsuario";
            this.txtboxUsuario.Enter += new System.EventHandler(this.txtboxUsuario_Enter);
            this.txtboxUsuario.Leave += new System.EventHandler(this.txtboxUsuario_Leave);
            // 
            // txtboxSenha
            // 
            this.txtboxSenha.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.txtboxSenha, "txtboxSenha");
            this.txtboxSenha.Name = "txtboxSenha";
            this.txtboxSenha.Enter += new System.EventHandler(this.txtboxSenha_Enter);
            this.txtboxSenha.Leave += new System.EventHandler(this.txtboxSenha_Leave);
            // 
            // txtboxConfirmSenha
            // 
            this.txtboxConfirmSenha.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.txtboxConfirmSenha, "txtboxConfirmSenha");
            this.txtboxConfirmSenha.Name = "txtboxConfirmSenha";
            this.txtboxConfirmSenha.Enter += new System.EventHandler(this.txtboxConfirmSenha_Enter);
            this.txtboxConfirmSenha.Leave += new System.EventHandler(this.txtboxConfirmSenha_Leave);
            // 
            // dataNascimento
            // 
            this.dataNascimento.CalendarTitleForeColor = System.Drawing.Color.Silver;
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dataNascimento, "dataNascimento");
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Value = new System.DateTime(2020, 6, 14, 0, 0, 0, 0);
            // 
            // checkAdm
            // 
            resources.ApplyResources(this.checkAdm, "checkAdm");
            this.checkAdm.Name = "checkAdm";
            this.checkAdm.UseVisualStyleBackColor = true;
            this.checkAdm.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSelecionar
            // 
            resources.ApplyResources(this.btnSelecionar, "btnSelecionar");
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnDeletar
            // 
            resources.ApplyResources(this.btnDeletar, "btnDeletar");
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // picUsuario
            // 
            resources.ApplyResources(this.picUsuario, "picUsuario");
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.TabStop = false;
            // 
            // frmCadastro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.checkAdm);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.txtboxConfirmSenha);
            this.Controls.Add(this.txtboxSenha);
            this.Controls.Add(this.txtboxUsuario);
            this.Controls.Add(this.txtboxNumero);
            this.Controls.Add(this.txtboxEndereco);
            this.Controls.Add(this.txtboxSobrenome);
            this.Controls.Add(this.txtboxNome);
            this.Controls.Add(this.lblConfirmSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmSenha;
        private System.Windows.Forms.TextBox txtboxNome;
        private System.Windows.Forms.TextBox txtboxSobrenome;
        private System.Windows.Forms.TextBox txtboxEndereco;
        private System.Windows.Forms.TextBox txtboxNumero;
        private System.Windows.Forms.TextBox txtboxUsuario;
        private System.Windows.Forms.TextBox txtboxSenha;
        private System.Windows.Forms.TextBox txtboxConfirmSenha;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.CheckBox checkAdm;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}