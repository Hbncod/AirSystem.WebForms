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
    public partial class TelaPrincipalComum : Form
    {
        public TelaPrincipalComum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ListarUsuarios().ShowDialog();
            this.Close();
        }

        private void TelaPrincipalComum_Load(object sender, EventArgs e)
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
    }
}
