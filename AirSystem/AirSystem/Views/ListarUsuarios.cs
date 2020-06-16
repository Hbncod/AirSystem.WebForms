using AirSystem.Models;
using AirSystem.Repositories;
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

namespace AirSystem.Views
{
    public partial class ListarUsuarios : Form
    {
        UsuariosRepository usuarioRepository = new UsuariosRepository();
        private static Usuario u = new Usuario();
        public ListarUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            if (frmLogin.idioma == 0)
            {
                Idioma.AjustaCultura(this, "en");
            }
            else
            {
                Idioma.AjustaCultura(this, "pt");
            }
            dgvListarUsuarios.DataSource = null;
            dgvListarUsuarios.DataSource = usuarioRepository.BuscarTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void alterarContador()
        {
            //2 itens de 10
            lblContador.Text = $"{dgvListarUsuarios.RowCount} itens de {usuarioRepository.BuscarTodos().Count}";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvListarUsuarios.DataSource = null;

            // filtra as lista recebida do repositório, verificando se o nome, 
            // email, usuario, contém o que está no campo filtro.
            dgvListarUsuarios.DataSource = usuarioRepository.BuscarTodos().FindAll(x =>
                x.Nome.ToUpper().Contains(txtFiltro.Text.ToUpper())
            );
            alterarContador();
        }

        private void dgvListarUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //captura a linha que foi selecionada
            DataGridViewRow linha = dgvListarUsuarios.Rows[e.RowIndex];
            //esse campo precisa ser convertido pois é numérico
            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
            //Joga nas propriedades do objeto usuario
            u = usuarioRepository.BuscarPorId(codigo);
            txtNome.Text = u.Nome;
            txtEndereco.Text = u.Endereco;
            txtNascimento.Text = Convert.ToString(u.DataNascimento);
            txtNumero.Text = u.Numero;
            txtSenha.Text = u.Senha;
            txtSobrenome.Text = u.Sobrenome;
            txtUsuario.Text = u.NomeUsuario;
            lblIdUsuario.Text = Convert.ToString(u.Id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuario NovosDados = new Usuario
            {
                Nome = txtNome.Text,
                Endereco = txtEndereco.Text,
                DataNascimento = Convert.ToDateTime(txtNascimento.Text),
                Numero = txtNumero.Text,
                Senha = txtSenha.Text,
                Sobrenome = txtSobrenome.Text,
                NomeUsuario = txtUsuario.Text,
                Id = u.Id,
                TipoUsuario = u.TipoUsuario

            };
            usuarioRepository.editar(NovosDados);
            MessageBox.Show("Dados editados com sucesso", "Sucesso");
            dgvListarUsuarios.DataSource = null;
            dgvListarUsuarios.DataSource = usuarioRepository.BuscarTodos();
            
                
        }
    }
}
