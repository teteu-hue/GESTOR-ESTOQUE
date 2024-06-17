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
            this.connection.Open();

            sql = "SELECT * FROM fornecedor";

            this.cmd = new MySqlCommand(sql, this.connection);

            try 
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
                reader.Close();
                this.connection.Close();
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

    }
}
