using GESTOR_ESTOQUE.Class;
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
            Dao db = new Dao();
            
            Console.WriteLine(db);
            Console.ReadKey();
        }
    }
}
