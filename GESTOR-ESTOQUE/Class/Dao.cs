using System.Data.SqlClient;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using MySql.Data.MySqlClient;
 
namespace KMysqlNet

{

    class Dao

    {

        private string sql;
        private string server = "192.168.8.10";
        private string port = "3306";
        private string dbname = "grupo03";
        private string username = "grupo03";
        private string password = "password";

        protected MySqlCommand cmd;

        protected MySqlConnection connection;

        protected MySqlDataReader reader;


        public Dao()
        {

            this.connection = this.getConnection();

        }

        private MySqlConnection getConnection()
        {
            string connectionString = $"Server={this.server};Port={this.port};Database={this.dbname};Uid={username};Pwd='{password}';";

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            } 
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

    }

}


