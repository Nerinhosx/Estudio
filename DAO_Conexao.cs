using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class DAO_Conexao
    {
        public static MySqlConnection con;

        public static Boolean getConexao(String local, String banco, String user, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + local + ";User ID=" + user + ";" + "database=" + banco + "; password=" + senha + "; SslMode = none");
                retorno = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;
        }

        public static Boolean CadLogin(string usuario, string senha, int tipo)
        {
            bool cad = false;

            try
            {
                con.Open();
                MySqlCommand insere = new MySqlCommand("Insert into Estudio_Login (usuario, senha, tipo)" + "values ('" + usuario + "','" + senha + "'," + tipo + ")", con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return cad;
        }

        public static int Login(string usuario, string senha)
        {
            int tipo = 0;
            try
            {
                con.Open();
                MySqlCommand login = new MySqlCommand("Select * from Estudio_Login where usuario = '" + usuario + "' and senha = '" + senha + "'", con);
                MySqlDataReader resultado = login.ExecuteReader();
                if(resultado.Read())
                {
                    tipo = Convert.ToInt32(resultado["tipo"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return tipo;
        }
    }
}
