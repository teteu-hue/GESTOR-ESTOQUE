using KMysqlNet;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTOR_ESTOQUE.model
{
    class DbUsuario : Dao
    {
        public DbUsuario() : base() { }

        public void mostrarUsuarios()
        {
            string sql = "select * from usuario;";

            this.connection.OpenAsync();

            this.cmd = new MySqlCommand(sql, this.connection);

            try
            {
                MySqlDataReader reader = this.cmd.ExecuteReader();

                while(reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
                reader.Close();
                this.connection.Close();

            } catch(KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
