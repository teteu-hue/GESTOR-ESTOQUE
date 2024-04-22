using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GESTOR_ESTOQUE.Class
{
    class Fornecedor : Pessoa
    {
        private string cnpj;
        private string razaoSocial;
        private string nomeFantasia;

        public Fornecedor() : base()
        {
        }

        public Fornecedor(string cnpj) : base()
        {
            this.cnpj = cnpj;
        }

        public Fornecedor(string cnpj, string razaoSocial) : base()
        {
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;
        }

        public Fornecedor(string cnpj, string razaoSocial, string nomeFantasia) : base()
        {
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;
            this.nomeFantasia = nomeFantasia;
        }

        public string getCnpj()
        {
            return this.cnpj;
        }

        public void setCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public string getRazaoSocial()
        {
            return this.razaoSocial;
        }

        public void setRazaoSocial(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
        }

        public string getNomeFantasia()
        {
            return this.nomeFantasia;
        }

        public void setNomeFantasia(string nomeFantasia)
        {
            this.nomeFantasia = nomeFantasia;
        }
    }
}
