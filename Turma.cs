using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Turma
    {
        private string professor, dia_da_semana, hora;
        private int modalidade;

        public int Modalidade { get => modalidade; set => modalidade = value; }
        public string Professor { get => professor; set => professor = value; }
        public string Dia_da_semana { get => dia_da_semana; set => dia_da_semana = value; }
        public string Hora { get => hora; set => hora = value; }

        public Turma(int modalidade, string professor, string dia_da_semana, string hora)
        {
            this.modalidade = modalidade;
            this.professor = professor;
            this.dia_da_semana = dia_da_semana;
            this.hora = hora;
        }

        public Turma(int modalidade, string dia_da_semana)
        {
            this.modalidade = modalidade;
            this.dia_da_semana = dia_da_semana;
        }

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public bool cadastrarTurma()
        {
            bool cad = false;
            try{
                DAO_Conexao.con.Open();
                MySqlCommand cadastar = new MySqlCommand("insert into Estudio_Turma (idModalidade, professorTurma, diasemanaTurma, horaTurma) values (" + modalidade + ", '" + professor + "', '" + dia_da_semana + "', '" + hora + "')", DAO_Conexao.con);
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

        /*public bool excluirTurma()
        {
            bool exc = false;
            try{
                DAO_Conexao.con.Open();
                MySqlCommand excluir = new MySqlCommand("update Estudio_Turma set ativa = 1 where idModalidade");
            }
        }

        public MySqlDataReader consultarTurma()
        {
            
        }

        public MySqlDataReader consultarTurma01()
        {

        }*/
    }
}
