using Projeto.Model;
using System;
using System.Data.SqlClient;

namespace Projeto.Controler
{
    public class Usuario
    {
        public bool AdicionarDados(CbdUsuario usuarios)
        {
            string stringConection = "Data Source=mybase.cqp0xehsexp2.sa-east-1.rds.amazonaws.com;Initial Catalog=teste01;Persist Security Info=True;User ID=Master;Password=Wal03&12";
            SqlConnection conexaodb = new SqlConnection(stringConection);

            try
            {
                conexaodb.Open();

                string querySQL = "INSERT INTO tab_teste (nome, rg, cpf, endereco, telefone) VALUES(@nome, @rg, @cpf, @endereco, @telefone)";

                SqlCommand cmd = new SqlCommand(querySQL, conexaodb);

                cmd.Parameters.AddWithValue("@nome", usuarios.Nome);
                cmd.Parameters.AddWithValue("@rg", usuarios.Rg);
                cmd.Parameters.AddWithValue("@cpf", usuarios.Cpf);
                cmd.Parameters.AddWithValue("@endereco", usuarios.Endereco);
                cmd.Parameters.AddWithValue("@telefone", usuarios.Telefone);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conexaodb.Close();
            }
        }
    }
}
