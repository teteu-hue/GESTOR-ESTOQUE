using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GESTOR_ESTOQUE.Class
{
    class Pessoa
    {
        private int pessoaID;
        private string nome;
        private string email;
        private string telefone;
        private string endereco;

        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public Pessoa(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }

        public Pessoa(string nome, string email, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
        }

        public Pessoa(string nome, string email, string telefone, string endereco)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
        }

    }
}
