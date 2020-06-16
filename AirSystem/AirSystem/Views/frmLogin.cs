using AirSystem.Models;
using AirSystem.Repositories;
using AirSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class frmLogin : Form
    {
        public static int idioma = -1;
        UsuariosRepository usuariosRepository = new UsuariosRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            
            Usuario usuario = usuariosRepository.Login(txtUsuario.Text, txtSenha.Text);
            if (txtUsuario.Text.Trim().Length != 0 && txtUsuario.ForeColor != Color.Black)// 
            {
                MessageBox.Show("o campo \"Usuario\" é obrigatório", "Campo não preenchido");
            }
            else if (txtSenha.Text.Trim().Length != 0 && txtSenha.ForeColor != Color.Black)
            {
                MessageBox.Show("o campo \"Senha\" é obrigatório", "Campo não preenchido");
            }
            else if (usuario != null)
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

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            Utils.EnterPlaceHolder(txtUsuario, "Digite seu usuário...");
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
                Utils.LeavePlaceHolder(txtUsuario, "Digite seu usuário...");
            
            //if (txtUsuario.Text == "")
            //{
              //  txtUsuario.Text = "Digite seu usuário...";

                //txtUsuario.ForeColor = Color.Silver;
            //}
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            
            txtSenha.PasswordChar = '*';
            Utils.EnterPlaceHolder(txtSenha, "Digite Sua Senha...");

            //if (txtSenha.Text == "Digite Sua Senha...")
            //{
            //    txtSenha.Text = "";

            //    txtSenha.ForeColor = Color.Black;
            //    txtSenha.PasswordChar = '*';
            //}

        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            
            Utils.LeavePlaceHolder(txtSenha, "Digite Sua Senha...");
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }

        private void comboIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            idioma = comboIdiomas.SelectedIndex;
            if (idioma == 0)
            {
                Idioma.AjustaCultura(this, "en");
                txtSenha.PasswordChar = '\0';
                txtSenha.ForeColor = Color.Silver;
                txtUsuario.ForeColor = Color.Silver;
            }
            else
            {
                Idioma.AjustaCultura(this, "pt");
                txtSenha.PasswordChar = '\0';
                txtSenha.ForeColor = Color.Silver;
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
