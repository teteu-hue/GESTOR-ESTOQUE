using GESTOR_ESTOQUE.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTOR_ESTOQUE
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Digite o nome do Cliente: ");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("E-mail: ");
            cliente.Email = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            cliente.Telefone = Console.ReadLine();
            Console.WriteLine("Endereço: ");
            cliente.Endereco = Console.ReadLine();
            Console.WriteLine("CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.WriteLine("Nomes: {0}", cliente.Nome);
            Console.ReadKey();
        }
    }
}
