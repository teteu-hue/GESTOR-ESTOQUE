using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GESTOR_ESTOQUE.Class
{

    class Produto
    {
        public string nome;
        public int preco;

        public Produto()
        {
        }
        public string Nome {  
            get 
            {
                return this.nome;
            } 
            set
            {
                
                while(value.Length < 0)
                {
                    Console.WriteLine("Digite um nome válido por favor");
                    value = Console.ReadLine();
                    this.nome = value;
                }
                    this.nome = value;    
            }
        }
        public int Preco {
            get
            {
                return this.preco;
            }
            set
            {
                
                while (value < -1)
                {
                    Console.WriteLine("Digite um valor válido por favor");
                    value = int.Parse(Console.ReadLine());
                    this.preco = value;
                }             
                    this.preco = value;               
            } 
        }

        public void cadastrar()
        {
            Console.WriteLine("Qual o nome produto?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o preço do produto?");
            int preco = int.Parse(Console.ReadLine());

            this.Nome = nome;
            this.Preco = preco;
        }

        
    }
}
