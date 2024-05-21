using GESTOR_ESTOQUE.Class;
using GESTOR_ESTOQUE.model;
using KMysqlNet;
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
            DbPessoa dbPessoa = new DbPessoa();
            dbPessoa.mostrarPessoas();
            Console.ReadKey();
        }
    }
}
