using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTOR_ESTOQUE.Class
{
    class Funcionario : Pessoa
    {
        private int funcionarioID;
        private int salario;

        public Funcionario() : base()
        {
        }

        public int getFuncionarioID()
        {
            return this.funcionarioID;
        }

        public void setFuncionarioID(int funcionarioID)
        {
            this.funcionarioID = funcionarioID;
        }

    }
}
