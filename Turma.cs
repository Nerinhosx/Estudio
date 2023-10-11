using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Turma
    {
        private string professor, dia_da_semana, hora;
        private int modalidade, qtdAl;

        public int Modalidade { get => modalidade; set => modalidade = value; }
        public string Professor { get => professor; set => professor = value; }
        public string Dia_da_semana { get => dia_da_semana; set => dia_da_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int QtdAl { get => qtdAl; set => qtdAl = value; }

        public Turma(int modalidade, string professor, string dia_da_semana, string hora, int qtdAl)
        {
            this.modalidade = modalidade;
            this.professor = professor;
            this.dia_da_semana = dia_da_semana;
            this.hora = hora;
            this.qtdAl = qtdAl;
        }

        public Turma(int modalidade, string dia_da_semana)
        {
            this.modalidade = modalidade;
            this.dia_da_semana = dia_da_semana;
            this.hora = hora;
        }

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma() {}

        public bool cadastrarTurma()
        {
            bool cad = false;
            try{
                DAO_Conexao.con.Open();
                MySqlCommand cadastar = new MySqlCommand("insert into Estudio_Turma (idModalidade, professorTurma, diasemanaTurma, horaTurma, nalunosmatriculadosTurma) values (" + modalidade + ", '" + professor + "', '" + dia_da_semana + "', '" + hora + "', "+ qtdAl +")", DAO_Conexao.con);
                cadastar.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
            finally{
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public bool excluirTurma(string descMod, string DS, string time)
        {
            bool exc = false;
            int idMod = -1;
            int idT = 0;
            try{
                DAO_Conexao.con.Open();
                MySqlCommand consIdMod = new MySqlCommand("select distinct idModalidade from Estudio_Turma inner join Estudio_Modalidade on Estudio_Modalidade.descricaoModalidade = '" + descMod + "' AND Estudio_Turma.ativa = 0", DAO_Conexao.con);
                MySqlDataReader consIdModReader = consIdMod.ExecuteReader();
                while (consIdModReader.Read())
                {
                    idMod = int.Parse(consIdModReader["idModalidade"].ToString());
                }
                DAO_Conexao.con.Close();
                //====================================================================================
                DAO_Conexao.con.Open();
                MySqlCommand consIdTurma = new MySqlCommand("select idEstudio_Turma from Estudio_Turma where idModalidade = " + idMod + " AND diasemanaTurma = '" + DS + "' AND horaTurma = '" + time + "' AND ativa = 0", DAO_Conexao.con);
                MySqlDataReader consIdTReader = consIdTurma.ExecuteReader();
                while (consIdTReader.Read())
                {
                    idT = int.Parse(consIdTReader["idEstudio_Turma"].ToString());
                }
                DAO_Conexao.con.Close();
                //====================================================================================
                DAO_Conexao.con.Open();
                MySqlCommand excT = new MySqlCommand("update Estudio_Turma set ativa = 1 where idEstudio_Turma = " + idT, DAO_Conexao.con);
                excT.ExecuteNonQuery();
                exc = true;
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

        public bool verficaTurmaAtiva(string descMod, string DS, string time)
        {
            bool vTA = false;

            int idMod = -1;
            MySqlDataReader bsTurmaAtiva = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consIdMod = new MySqlCommand("select distinct idModalidade from Estudio_Turma inner join Estudio_Modalidade where Estudio_Modalidade.descricaoModalidade = '" + descMod + "'", DAO_Conexao.con);
                MySqlDataReader consIdModReader = consIdMod.ExecuteReader();
                while (consIdModReader.Read())
                {
                    idMod = int.Parse(consIdModReader["idModalidade"].ToString());
                }
                DAO_Conexao.con.Close();
                //=======================================================================================
                DAO_Conexao.con.Open();
                MySqlCommand consTurmaAtiv = new MySqlCommand("select ativa from Estudio_Turma where idModalidade = " + idMod + " AND diasemanaTurma = '" + DS + "' AND horaTurma = '" + time + "'", DAO_Conexao.con);
                bsTurmaAtiva = consTurmaAtiv.ExecuteReader();
                while (bsTurmaAtiva.Read())
                {
                    if(0 == int.Parse(bsTurmaAtiva["ativa"].ToString()))
                    {
                        vTA = true;
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
            return vTA;
        }

        /*public MySqlDataReader consultarTurma()
        {
            
        }*/

        public bool verificaTurma()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand ex = new MySqlCommand("select * from Estudio_Turma where idModalidade = " + modalidade + " and diasemanaTurma = '" + dia_da_semana + "' and horaTurma = '" + hora + "'", DAO_Conexao.con);
                MySqlDataReader exr = ex.ExecuteReader();
                while (exr.Read())
                {
                    existe = true;
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
            return existe;
        }

        public MySqlDataReader consultarModTurmas()
        {
            MySqlDataReader modAtv = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consAtv = new MySqlCommand("select distinct descricaoModalidade from Estudio_Modalidade inner join Estudio_Turma on Estudio_Modalidade.idEstudio_Modalidade = Estudio_Turma.idModalidade", DAO_Conexao.con);
                modAtv = consAtv.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return modAtv;
        }

        public MySqlDataReader consultarDiaTurmas(string modDesc)
        {
            MySqlDataReader diaAtv = null;
            try{
                DAO_Conexao.con.Open();
                MySqlCommand consAtv = new MySqlCommand("select distinct diasemanaTurma from Estudio_Turma inner join Estudio_Modalidade on Estudio_Turma.idModalidade = Estudio_Modalidade.idEstudio_Modalidade AND Estudio_Modalidade.descricaoModalidade = '" + modDesc +"'", DAO_Conexao.con);
                diaAtv = consAtv.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return diaAtv;
        }

        public MySqlDataReader consultarHoraTurmas(string modDesc, string diaDesc)
        {
            MySqlDataReader horaAtv = null;
            try{
                DAO_Conexao.con.Open();
                MySqlCommand consAtv = new MySqlCommand("select distinct horaTurma from Estudio_Turma inner join Estudio_Modalidade on Estudio_Turma.idModalidade = Estudio_Modalidade.idEstudio_Modalidade AND Estudio_Modalidade.descricaoModalidade = '" + modDesc + "' AND Estudio_Turma.diasemanaTurma = '" + diaDesc + "'", DAO_Conexao.con);
                horaAtv = consAtv.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return horaAtv;
        }
    }
}
