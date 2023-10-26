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

        public AlunoEmTurma(string cpfA)
        {
            this.cpfA = cpfA;
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
                MySqlCommand upAlT = new MySqlCommand("update Estudio_Turma set nalunosmatriculadosTurma = nalunosmatriculadosTurma + 1 where idEstudio_Turma = " + idT, DAO_Conexao.con);
                upAlT.ExecuteNonQuery();
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

        public bool verificaMatriculadoEmTurma()
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

        public MySqlDataReader buscaTurmaMatriculado()
        {
            MySqlDataReader exSTM = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand sTM = new MySqlCommand("select Estudio_Turma.idEstudio_Turma, Estudio_Modalidade.descricaoModalidade, Estudio_Turma.diasemanaTurma, Estudio_Turma.horaTurma from Estudio_AlunoTurma inner join Estudio_Turma inner join Estudio_Modalidade on Estudio_AlunoTurma.idTurma = Estudio_Turma.idEstudio_Turma AND Estudio_Turma.idModalidade = Estudio_Modalidade.idEstudio_Modalidade AND Estudio_AlunoTurma.cpfAluno = '"+ cpfA +"'", DAO_Conexao.con);
                exSTM = sTM.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return exSTM;
        }

        public bool desmatricularAluno()
        {
            bool dsmu = false;
            try
            {
                //Início deletando de Estudio_AlunoTurma
                DAO_Conexao.con.Open();
                MySqlCommand dsm = new MySqlCommand("delete from Estudio_AlunoTurma where cpfAluno = '" + cpfA + "' AND idTurma = " + idT, DAO_Conexao.con);
                dsm.ExecuteNonQuery();
                DAO_Conexao.con.Close();
                //Fim deletando de Estudio_AlunoTurma

                //Início alterando nalunosmatriculadosTurma de Estudio_Turma
                DAO_Conexao.con.Open();
                MySqlCommand dm = new MySqlCommand("update Estudio_Turma set nalunosmatriculadosTurma = nalunosmatriculadosTurma - 1 where idEstudio_Turma = " + idT, DAO_Conexao.con);
                dm.ExecuteNonQuery();
                dsmu = true;
                //Fim alterando nalunosmatriculadosTurma de Estudio_Turma
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return dsmu;
        }
    }
}
