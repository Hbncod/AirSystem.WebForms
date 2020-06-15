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
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(28, 72);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(28, 99);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(63, 13);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(28, 158);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(28, 128);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblConfirmSenha
            // 
            this.lblConfirmSenha.AutoSize = true;
            this.lblConfirmSenha.Location = new System.Drawing.Point(28, 181);
            this.lblConfirmSenha.Name = "lblConfirmSenha";
            this.lblConfirmSenha.Size = new System.Drawing.Size(85, 13);
            this.lblConfirmSenha.TabIndex = 6;
            this.lblConfirmSenha.Text = "Confirmar Senha";
            // 
            // txtboxNome
            // 
            this.txtboxNome.ForeColor = System.Drawing.Color.Silver;
            this.txtboxNome.Location = new System.Drawing.Point(118, 43);
            this.txtboxNome.Name = "txtboxNome";
            this.txtboxNome.Size = new System.Drawing.Size(131, 20);
            this.txtboxNome.TabIndex = 7;
            this.txtboxNome.Text = "Digite seu nome...";
            this.txtboxNome.Enter += new System.EventHandler(this.txtboxNome_Enter);
            this.txtboxNome.Leave += new System.EventHandler(this.txtboxNome_Leave);
            // 
            // txtboxSobrenome
            // 
            this.txtboxSobrenome.ForeColor = System.Drawing.Color.Silver;
            this.txtboxSobrenome.Location = new System.Drawing.Point(255, 43);
            this.txtboxSobrenome.Name = "txtboxSobrenome";
            this.txtboxSobrenome.Size = new System.Drawing.Size(131, 20);
            this.txtboxSobrenome.TabIndex = 8;
            this.txtboxSobrenome.Text = "Digite seu sobrenome...";
            this.txtboxSobrenome.Enter += new System.EventHandler(this.txtboxSobrenome_Enter);
            this.txtboxSobrenome.Leave += new System.EventHandler(this.txtboxSobrenome_Leave);
            // 
            // txtboxEndereco
            // 
            this.txtboxEndereco.ForeColor = System.Drawing.Color.Silver;
            this.txtboxEndereco.Location = new System.Drawing.Point(118, 69);
            this.txtboxEndereco.Name = "txtboxEndereco";
            this.txtboxEndereco.Size = new System.Drawing.Size(182, 20);
            this.txtboxEndereco.TabIndex = 9;
            this.txtboxEndereco.Text = "Digite seu endereço...";
            this.txtboxEndereco.Enter += new System.EventHandler(this.txtboxEndereco_Enter);
            this.txtboxEndereco.Leave += new System.EventHandler(this.txtboxEndereco_Leave);
            // 
            // txtboxNumero
            // 
            this.txtboxNumero.ForeColor = System.Drawing.Color.Silver;
            this.txtboxNumero.Location = new System.Drawing.Point(321, 69);
            this.txtboxNumero.Name = "txtboxNumero";
            this.txtboxNumero.Size = new System.Drawing.Size(65, 20);
            this.txtboxNumero.TabIndex = 10;
            this.txtboxNumero.Text = "Nº";
            this.txtboxNumero.Enter += new System.EventHandler(this.txtboxNumero_Enter);
            this.txtboxNumero.Leave += new System.EventHandler(this.txtboxNumero_Leave);
            // 
            // txtboxUsuario
            // 
            this.txtboxUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtboxUsuario.Location = new System.Drawing.Point(118, 125);
            this.txtboxUsuario.Name = "txtboxUsuario";
            this.txtboxUsuario.Size = new System.Drawing.Size(131, 20);
            this.txtboxUsuario.TabIndex = 11;
            this.txtboxUsuario.Text = "Digite seu usuário";
            this.txtboxUsuario.Enter += new System.EventHandler(this.txtboxUsuario_Enter);
            this.txtboxUsuario.Leave += new System.EventHandler(this.txtboxUsuario_Leave);
            // 
            // txtboxSenha
            // 
            this.txtboxSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtboxSenha.Location = new System.Drawing.Point(118, 151);
            this.txtboxSenha.Name = "txtboxSenha";
            this.txtboxSenha.Size = new System.Drawing.Size(131, 20);
            this.txtboxSenha.TabIndex = 12;
            this.txtboxSenha.Text = "Digite sua senha...";
            this.txtboxSenha.Enter += new System.EventHandler(this.txtboxSenha_Enter);
            this.txtboxSenha.Leave += new System.EventHandler(this.txtboxSenha_Leave);
            // 
            // txtboxConfirmSenha
            // 
            this.txtboxConfirmSenha.ForeColor = System.Drawing.Color.Silver;
            this.txtboxConfirmSenha.Location = new System.Drawing.Point(118, 177);
            this.txtboxConfirmSenha.Name = "txtboxConfirmSenha";
            this.txtboxConfirmSenha.Size = new System.Drawing.Size(131, 20);
            this.txtboxConfirmSenha.TabIndex = 13;
            this.txtboxConfirmSenha.Text = "Confirme sua senha...";
            this.txtboxConfirmSenha.Enter += new System.EventHandler(this.txtboxConfirmSenha_Enter);
            this.txtboxConfirmSenha.Leave += new System.EventHandler(this.txtboxConfirmSenha_Leave);
            // 
            // dataNascimento
            // 
            this.dataNascimento.CalendarTitleForeColor = System.Drawing.Color.Silver;
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(118, 99);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(131, 20);
            this.dataNascimento.TabIndex = 14;
            this.dataNascimento.Value = new System.DateTime(2020, 6, 14, 0, 0, 0, 0);
            // 
            // checkAdm
            // 
            this.checkAdm.AutoSize = true;
            this.checkAdm.Location = new System.Drawing.Point(413, 195);
            this.checkAdm.Name = "checkAdm";
            this.checkAdm.Size = new System.Drawing.Size(56, 17);
            this.checkAdm.TabIndex = 15;
            this.checkAdm.Text = "É adm";
            this.checkAdm.UseVisualStyleBackColor = true;
            this.checkAdm.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // picUsuario
            // 
            this.picUsuario.Location = new System.Drawing.Point(413, 37);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(131, 110);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 16;
            this.picUsuario.TabStop = false;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(413, 153);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(69, 23);
            this.btnSelecionar.TabIndex = 17;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(488, 153);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(56, 23);
            this.btnDeletar.TabIndex = 18;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(118, 233);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 297);
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
            this.Text = "Novo Usuario - AirSystem";
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