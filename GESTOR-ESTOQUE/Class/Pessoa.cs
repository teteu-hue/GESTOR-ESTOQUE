using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GESTOR_ESTOQUE.Class
{
    abstract class Pessoa 
    {
        protected string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }   

        public string Endereco { get; set; }

        public string CPF {
            get;
            set;
        }

        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public Pessoa(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public Pessoa(string nome, string email, string telefone, string endereco)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }


 
    }
}
