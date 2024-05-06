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
        public int PessoaID
        {
            get
            {
                return pessoaID;
            }
        }

        private string nome;
        public string Nome 
        { 
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        private string email;
        public string Email 
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }

        private string telefone;
        public string Telefone 
        {
            get
            {
                return this.telefone;
            }

            set
            {
                this.telefone = value;
            }
        }   

        private string endereco;
        public string Endereco
        {
            get
            {
                return this.endereco;
            }

            set
            {
                this.endereco = value;
            }
        }

        private string Cpf;
        public string CPF
        {
            get 
            {
                return this.Cpf;
            }
            set
            {
                this.Cpf = value;
            }
        }

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
