using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
    class UsuariosRepository
    {
        private static List<Usuario> Usuarios;

        public UsuariosRepository()
        {
            if (Usuarios == null)
            {
                Usuarios = new List<Usuario>();

                Usuarios.Add(new Usuario
                {
                    Nome = "Henrique",
                    Sobrenome = "Barbosa",
                    DataNascimento = Convert.ToDateTime("03/04/2001"),
                    Endereco = "Tijuco Preto",
                    Numero = "255",
                    NomeUsuario = "adm",
                    Senha = "adm",
                    TipoUsuario = true // logo é adm
                });
                Usuarios.Add(new Usuario
                {
                    Nome = "Rafael",
                    Sobrenome = "Souza",
                    DataNascimento = Convert.ToDateTime("07/02/2000"),
                    Endereco = "Rua 12",
                    Numero = "33",
                    NomeUsuario = "comum",
                    Senha = "comum",
                    TipoUsuario = false // logo não é adm
                });

            }
        }

        public List<Usuario> BuscarTodos()
        {
            return Usuarios;
        }
        public void Adicionar(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }
        public Usuario Login(string Usuario, String Senha)
        {
            return Usuarios.Find(u => u.NomeUsuario == Usuario && u.Senha == Senha);
        }
    }
}
