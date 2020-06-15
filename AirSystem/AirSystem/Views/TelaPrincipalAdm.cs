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
    public partial class TelaPrincipalAdm : Form
    {
        public TelaPrincipalAdm()
        {
            InitializeComponent();
        }

        private void TelaPrincipalAdm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ListarUsuarios().ShowDialog();
            this.Close();
        }
    }
}
