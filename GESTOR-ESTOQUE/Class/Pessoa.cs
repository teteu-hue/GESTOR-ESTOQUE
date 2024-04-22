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
        private string CPF;

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

        public int getPessoaID()
        {
            return this.pessoaID;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getTelefone()
        {
            return this.telefone;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getEndereco()
        {
            return this.endereco;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string getCPF()
        {
            return this.CPF;
        }

        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }
    }
}
