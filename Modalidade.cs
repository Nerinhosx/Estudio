using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Modalidade
    {
        private string Desc;
        private double Prc;
        private int qtde_alunos, qtde_aulas;

        public string Desc1 { get => Desc; set => Desc = value; }
        public double Prc1 { get => Prc; set => Prc = value; }
        public int Qtde_alunos { get => Qtde_alunos1; set => Qtde_alunos1 = value; }
        public int Qtde_alunos1 { get => qtde_alunos; set => qtde_alunos = value; }

        public Modalidade(string desc, double prc, int qtdeAl, int qtdeAu)
        {
            Desc = desc;
            Prc = prc;
            qtde_alunos = qtdeAl;
            qtde_aulas = qtdeAu;
        }

        public Modalidade(string desc)
        {
            Desc = desc;
        }

        public Modalidade()
        {

        }

        public bool cadastrarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values ('" + Desc + "', " + Prc + ", " + qtde_alunos + ", " + qtde_aulas + ");", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }
        /*
        public MySqlDataReader consultarModalidade()
        {

        }*/

        public MySqlDataReader consultarTodasModalidades()
        {
            MySqlDataReader mod = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consAll = new MySqlCommand("select descricaoModalidade from Estudio_Modalidade", DAO_Conexao.con);
                mod = consAll.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return mod;
        }
        /*

        public bool atualizarModalidade()
        {

        }*/

        public bool excluirModalidade()
        {
            bool exc = false;
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select idEstudio_Modalidade from Estudio_Modalidade where descricaoModalidade ='" + Desc + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    int id = int.Parse(resultado["idEstudio_Modalidade"].ToString());
                    DAO_Conexao.con.Close();
                    DAO_Conexao.con.Open();
                    MySqlCommand delete = new MySqlCommand("update Estudio_Modalidade set ativa = 1 where idEstudio_Modalidade =" + id, DAO_Conexao.con);
                    Console.WriteLine("update Estudio_Modalidade set ativa = 1 where idEstudio_Modalidade =" + id);
                    delete.ExecuteNonQuery();
                    exc = true;
                }
                else
                    Console.WriteLine("Não encontrado");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }
    }
}
