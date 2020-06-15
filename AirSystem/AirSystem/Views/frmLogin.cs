using AirSystem.Models;
using AirSystem.Repositories;
using AirSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class frmLogin : Form
    {
        UsuariosRepository usuariosRepository = new UsuariosRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboIdiomas.Items.Add("Português Pt-Br");
            comboIdiomas.Items.Add("Inglês");
            lblHora.Text = DateTime.Now.ToString("HH:MM:ss");
        }


        private void txtboxUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtboxUsuario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!Utils.temCamposVazio(this))
            {
                Usuario usuario = usuariosRepository.Login(txtUsuario.Text, txtSenha.Text);
                if (usuario != null)
                {
                    if (usuario.TipoUsuario)
                    {
                        new TelaPrincipalAdm().ShowDialog();
                    }
                    else
                    {
                        new TelaPrincipalComum().ShowDialog();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha Incorretos", "Usuario não encontrado");
                }
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios.",
                                       "Aviso", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
