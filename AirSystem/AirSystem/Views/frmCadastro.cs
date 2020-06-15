using AirSystem.Models;
using AirSystem.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (!Utils.temCamposVazio(this))
            {
                if (txtboxConfirmSenha.Text != txtboxSenha.Text)
                {
                    MessageBox.Show("O Campo \"Senha \" e o Campo \"Confirmar Senha\" Devem ser iguais", "Erro");
                }

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
            else
            {   
                MessageBox.Show("Todos os campos são obrigatórios.",
                                   "Aviso", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
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
            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            picUsuario.Image = null;
        }
    }
}
