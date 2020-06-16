using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    class Utils
    {
        public static void EnterPlaceHolder(TextBox txt, string frase)
        {
            if (txt.Text == frase)
            {
                txt.Text = "";

                txt.ForeColor = Color.Black;
            }
        }
        public static void LeavePlaceHolder(TextBox txt,string frase)
        {
            if (txt.Text == "")
            {
                txt.Text = frase;

                txt.ForeColor = Color.Silver;
                txt.PasswordChar = '\0';
            }
        }
        /* public static bool temcamposvazio(form form)
        {
            varrer os objeos do formulário
            foreach (control c in form.controls)
            {
                guardar as caixas de texto
                textbox tbx = c as textbox;
                verificar se estão preenchidas
                if (tbx.text.trim().length == 0 && tbx.forecolor == color.silver)
                {
                    retorna que tem campos vazios
                    return true;
                }
            }
            retornar que não tem campos vazios
            return false;
        } */
    }
}
