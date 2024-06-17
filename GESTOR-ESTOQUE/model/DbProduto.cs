using GESTOR_ESTOQUE.Class;
using KMysqlNet;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;

namespace GESTOR_ESTOQUE.model
{
    class DbProduto : Dao
    {

        public DbProduto() : base() 
        { 
        }

        public void InserirProduto(Produto produto)
        {

            try
            {
            string sqlInsert = "INSERT INTO produto (nome, preco) VALUES(@nome, @preco)";
            this.connection.Open();
            this.cmd = new MySqlCommand(sqlInsert, this.connection);

            this.cmd.Parameters.AddWithValue("@nome", produto.Nome);
            this.cmd.Parameters.AddWithValue("@preco", produto.Preco);

            Console.WriteLine("Cadastrando produto no banco de Dados!");
            Console.WriteLine("Aguarde...");
            int result = this.cmd.ExecuteNonQuery();
            Thread.Sleep(2000);


            if(result < 0)
            {
                Console.WriteLine("Algo deu errado!");
                Console.WriteLine("Tente novamente");
            }

                Console.WriteLine("Inserção realizada com sucesso!");
                this.connection.Close();
                Console.Clear();

            } catch(Exception e)
            {
                Console.WriteLine("Alguma coisa deu errado, entre em contato com o suporte!");
            }
        }

        public void MostrarProdutos()
        {
            string sqlSearch = "SELECT * FROM produto";

            try
            {
                this.connection.Open();
                this.cmd = new MySqlCommand(sqlSearch, this.connection);

                this.reader = this.cmd.ExecuteReader();

                while(this.reader.Read())
                {
                    int id = this.reader.GetInt32("id_produto");
                    string nome = this.reader.GetString("nome");
                    int preco = this.reader.GetInt32("preco");

                    Console.WriteLine($"ID: {id} \n" +
                        $"Nome: {nome}\n" +
                        $"Preço: {preco}\n\n");

                }

                this.reader.Close();
                this.connection.Close();

                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Alguma coisa deu errado, entre em contato com o suporte!");
            }
            return;
        }

        public void DeletarProduto(int id)
        {
            string sql = "DELETE FROM produto WHERE id_produto = @id";

            this.cmd = new MySqlCommand(sql, this.connection);

            this.cmd.Parameters.AddWithValue("@id", id);

            try
            {
                this.connection.Open();

                int result = this.cmd.ExecuteNonQuery();

                if(result < 0)
                {
                    Console.WriteLine("O produto não existe!");
                }

                this.connection.Close();
                return;

            } catch(Exception e)
            {
                Console.WriteLine("Alguma coisa deu errado, entre em contato com o suporte!");
            }

        }

        public void MostrarProduto(int id)
        {
            string sql = "SELECT * FROM produto where id_produto = @id";

            this.cmd = new MySqlCommand(sql, this.connection);
            this.cmd.Parameters.AddWithValue("@id", id);

            try
            {
                this.connection.Open();

                this.reader = this.cmd.ExecuteReader();

                while(this.reader.Read())
                {
                    int id_produto = this.reader.GetInt32("id_produto");
                    string nome = this.reader.GetString("nome");
                    int preco = this.reader.GetInt32("preco");

                    Console.WriteLine($"ID: {id_produto} \n" +
                        $"Nome: {nome}\n" +
                        $"Preço: {preco}\n\n");
                }

                this.reader.Close();
                this.connection.Close();

            } catch (Exception e)
            {
                Console.WriteLine("Alguma coisa deu errado, entre em contato com o suporte!");
            }

        }

    }
}
