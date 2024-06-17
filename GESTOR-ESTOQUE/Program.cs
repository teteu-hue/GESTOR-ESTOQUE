using GESTOR_ESTOQUE.Class;
using GESTOR_ESTOQUE.model;
using KMysqlNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GESTOR_ESTOQUE
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            DbProduto db = new DbProduto();
            Console.WriteLine("Bem vindo ao gerenciador de produtos");
            
            
            do
            {
                Console.WriteLine("Digite a opção 0 para sair e desconectar do banco de dados");
                Console.WriteLine("Digite a opção 1 para cadastrar um produto");
                Console.WriteLine("Digite a opção 2 para imprimir os produtos");
                Console.WriteLine("Digite a opção 3 para remover um produto");
                Produto produto = new Produto();
                option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        
                        produto.cadastrar();
                        db.InserirProduto(produto);
                        break;

                    case 2:
                        db.MostrarProdutos();
                        Console.WriteLine("Digite qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Tem certeza que quer remover?");

                        Console.WriteLine("Digite 1 para SIM e 0 para NÃO");

                        int confirm = int.Parse(Console.ReadLine());

                        Console.Clear();

                        if (confirm == 1)
                        {
                            Console.WriteLine("Digite o ID que precisa excluir!");
                            int excludedProduct = int.Parse(Console.ReadLine());
                            Console.Clear();
                            db.MostrarProduto(excludedProduct);
                            Console.WriteLine("O produto está sendo excluido");
                            Console.WriteLine("Aguarde...");
                            db.DeletarProduto(excludedProduct);
                            Thread.Sleep(2000);
                            Console.WriteLine("Produto excluído sucesso!");
                            Console.WriteLine("Tecle qualquer tecla para sair!");
                            Console.ReadKey();
                            Console.Clear();

                        } else
                        {
                            Console.WriteLine("Saindo da operação...");
                            Thread.Sleep(2000);
                        }

                        break;

                    default:
                        break;
                }
                

            } while(option != 0);
        }
    }
}
