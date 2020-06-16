using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsuariosRepository usuariosRepository = new UsuariosRepository();
            Regex senha = new Regex(
                @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", RegexOptions.IgnorePatternWhitespace);
            if(txtboxNome.Text.Trim().Length != 0 && txtboxNome.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Nome\" é obrigatório", "Campo não preenchido");
            }
            else if (txtboxSobrenome.Text.Trim().Length != 0 && txtboxSobrenome.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Sobrenome\" é obrigatório", "Campo não preenchido");
            }
            else if(txtboxUsuario.Text.Trim().Length != 0 && txtboxUsuario.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Usuário\" é obrigatório", "Campo não preenchido");
            }
            else if(txtboxSenha.Text.Trim().Length != 0 && txtboxSenha.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Senha\" é obrigatório", "Campo não preenchido");
            }
            else if(txtboxConfirmSenha.Text.Trim().Length != 0 && txtboxConfirmSenha.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Confirmar senha\" é obrigatório", "Campo não preenchido");
            }
            else if (!senha.IsMatch(txtboxSenha.Text))
            {
                MessageBox.Show("O Campo \"Senha \" é inválido, A senha deve ter pelo menos 8 caracteres – pelo menos 1 letra maiúscula, 1 letra minúscula e um número.", "Senha inválida");
            }
            else if(txtboxConfirmSenha.Text != txtboxSenha.Text)
                {
                    MessageBox.Show("O Campo \"Senha \" e o Campo \"Confirmar Senha\" Devem ser iguais", "Erro");
                }
                else
                {
                    Usuario usuario = new Usuario
                    {
                        Nome = txtboxNome.Text,
                        Endereco = txtboxEndereco.Text,
                        Numero = txtboxNumero.Text,
                        DataNascimento = dataNascimento.Value,
                        NomeUsuario = txtboxUsuario.Text,
                        Sobrenome = txtboxSobrenome.Text,
                        Senha = txtboxSenha.Text,
                        TipoUsuario = checkAdm.Checked
                    };
                    usuariosRepository.Adicionar(usuario);
                    MessageBox.Show("Usuário Cadastrado com Sucesso", "Sucesso", MessageBoxButtons.OK);
                    new frmLogin().ShowDialog();
                    this.Close();
                }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
           
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Carregar a imagem selecionada no picturebox
                picUsuario.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (frmLogin.idioma == 0)
            {
                Idioma.AjustaCultura(this, "en");
            }
            else 
            {
                Idioma.AjustaCultura(this, "pt");
            }
            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            picUsuario.Image = null;
        }

        private void txtboxNome_Enter(object sender, EventArgs e)
        {
            Utils.EnterPlaceHolder(txtboxNome, "Digite seu nome...");
        }

        private void txtboxSobrenome_Enter(object sender, EventArgs e)
        {
            Utils.EnterPlaceHolder(txtboxSobrenome, "Digite seu sobrenome...");
        }

        private void txtboxNome_Leave(object sender, EventArgs e)
        {
            Utils.LeavePlaceHolder(txtboxNome, "Digite seu nome...");
        }

        private void txtboxSobrenome_Leave(object sender, EventArgs e)
        {
            Utils.LeavePlaceHolder(txtboxSobrenome, "Digite seu sobrenome...");
        }

        private void txtboxEndereco_Enter(object sender, EventArgs e)
        {
            Utils.EnterPlaceHolder(txtboxEndereco, "Digite seu endereço...");
        }

        private void txtboxEndereco_Leave(object sender, EventArgs e)
        {
            Utils.LeavePlaceHolder(txtboxEndereco, "Digite seu endereço...");
        }

        private void txtboxNumero_Enter(object sender, EventArgs e)
        {
            Utils.EnterPlaceHolder(txtboxNumero, "Nº");
        }

        private void txtboxNumero_Leave(object sender, EventArgs e)
        {
            Utils.LeavePlaceHolder(txtboxNumero, "Nº");
        }

        private void txtboxUsuario_Enter(object sender, EventArgs e)
        {
            Utils.EnterPlaceHolder(txtboxUsuario, "Digite seu usuário");
        }

        private void txtboxUsuario_Leave(object sender, EventArgs e)
        {
            Utils.LeavePlaceHolder(txtboxUsuario, "Digite seu usuário");
        }

        private void txtboxSenha_Enter(object sender, EventArgs e)
        {
            Utils.EnterPlaceHolder(txtboxSenha, "Digite sua senha...");
            txtboxSenha.PasswordChar = '*';
        }

        private void txtboxSenha_Leave(object sender, EventArgs e)
        {
            Utils.LeavePlaceHolder(txtboxSenha, "Digite sua senha...");
            
        }

        private void txtboxConfirmSenha_Enter(object sender, EventArgs e)
        {
            Utils.EnterPlaceHolder(txtboxConfirmSenha, "Confirme sua senha...");
            txtboxConfirmSenha.PasswordChar = '*';
        }

        private void txtboxConfirmSenha_Leave(object sender, EventArgs e)
        {
            Utils.LeavePlaceHolder(txtboxConfirmSenha, "Confirme sua senha...");
        }

        private void txtboxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
