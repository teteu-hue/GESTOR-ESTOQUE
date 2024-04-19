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
    }
}
