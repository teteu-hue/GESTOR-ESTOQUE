using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTOR_ESTOQUE.Class
{
    class Usuario
    {
        private string Nome {  
            get
            {
                return this.Nome;
            }
            set
            {
                if(value.Length >= 21)
                {
                    Console.WriteLine("Não é possível adicionar um usuario com mais de 20 caracteres");
                    return;
                }
                this.Nome = value;
            } 
        }

        private string Senha
        {
            get 
            { 
                return this.Senha;
            }

            set
            {
                if(value.Length >= 21) 
                {
                    Console.WriteLine("Não é possível adicionar um usuario com mais de 20 caracteres");
                    return;
                }
                this.Senha = value;
            }
        }
    }
}
