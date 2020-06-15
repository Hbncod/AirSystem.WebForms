using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Models
{
    class Usuario
    {
        public int Id {get;set;}
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public string NomeUsuario { get; set; }
        public bool TipoUsuario { get; set; }
        public static int contador = 1; 
        public Usuario()
        {
            Id = contador;
            contador++;
        }
    }
}
