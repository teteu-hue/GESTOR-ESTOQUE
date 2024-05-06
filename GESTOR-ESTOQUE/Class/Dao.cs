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

        private string conexaostring;
        public MySqlCommand cmd;

        public MySqlConnection conexao;

        public MySqlDataReader reader;


        public Dao()

        {

        }

        public void inserirUsuario(string usuario, string senha)

        {

        }

        public void removerUsuario(int id)

        {

        }

    }

}


