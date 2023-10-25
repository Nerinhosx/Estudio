using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class AlunoEmTurma
    {
        private string cpfA;
        private int idT;

        public string CpfA { get => cpfA; set => cpfA = value; }
        public int IdT { get => idT; set => idT = value; }

        public AlunoEmTurma(string cpfA, int idT)
        {
            this.cpfA = cpfA;
            this.idT = idT;
        }

        public bool matricularAluno()
        {
            bool matriculou = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand matr = new MySqlCommand("insert into Estudio_AlunoTurma (cpfAluno, idTurma) values ('" + cpfA + "', " + idT + ")", DAO_Conexao.con);
                matr.ExecuteNonQuery();
                matriculou = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return matriculou;
        }

        public bool verificaMatriculado()
        {
            bool jaMatriculado = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand jaMatr = new MySqlCommand("select idTurma from Estudio_AlunoTurma where cpfAluno = '" + cpfA + "'", DAO_Conexao.con);
                MySqlDataReader exJaMatr = jaMatr.ExecuteReader();
                while (exJaMatr.Read())
                {
                    int idTurma = int.Parse(exJaMatr["idTurma"].ToString());
                    if(idTurma == idT)
                    {
                        jaMatriculado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return jaMatriculado;
        }
    }
}
