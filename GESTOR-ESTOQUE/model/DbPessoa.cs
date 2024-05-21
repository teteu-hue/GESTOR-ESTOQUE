using KMysqlNet;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTOR_ESTOQUE.model
{
    class DbPessoa : Dao
    {

        public DbPessoa() : base() { }

        public void mostrarPessoas()
        {
            this.connection.OpenAsync();

            this.sql = "SELECT * FROM pessoa";

            this.cmd = new MySqlCommand(this.sql, this.connection);

            this.reader = cmd.ExecuteReader();

            while (this.reader.Read())
            {
                Console.WriteLine(this.reader[0]);    
            }
            reader.Close();
            this.connection.Close();
        }

    }
}
