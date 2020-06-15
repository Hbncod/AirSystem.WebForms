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
    public partial class ListarUsuarios : Form
    {
        UsuariosRepository usuarioRepository = new UsuariosRepository();
        public ListarUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            dgvListarUsuarios.DataSource = null;
            dgvListarUsuarios.DataSource = usuarioRepository.BuscarTodos();
        }
    }
}
