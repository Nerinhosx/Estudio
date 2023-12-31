﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Modalidade
    {
        private string Desc, nDesc;
        private float Prc;
        private int qtde_alunos, qtde_aulas;

        public string Desc1 { get => Desc; set => Desc = value; }
        public float Prc1 { get => Prc; set => Prc = value; }
        public int Qtde_alunos { get => Qtde_alunos1; set => Qtde_alunos1 = value; }
        public int Qtde_alunos1 { get => qtde_alunos; set => qtde_alunos = value; }

        public Modalidade(string desc, float prc, int qtdeAl, int qtdeAu)
        {
            Desc = desc;
            Prc = prc;
            qtde_alunos = qtdeAl;
            qtde_aulas = qtdeAu;
        }

        public Modalidade(string desc, string ndesc, float prc, int qtdeAl, int qtdeAu)
        {
            Desc = desc;
            nDesc = ndesc;
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
        
        public MySqlDataReader consultarModalidade()
        {
            MySqlDataReader result = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultar = new MySqlCommand("select * from Estudio_Modalidade where descricaoModalidade = '" + Desc +"'", DAO_Conexao.con);
                result = consultar.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

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

        public MySqlDataReader consultarModalidadesAtivas()
        {
            MySqlDataReader modAtv = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consAtv = new MySqlCommand("select descricaoModalidade from Estudio_Modalidade where ativa = 0", DAO_Conexao.con);
                modAtv = consAtv.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return modAtv;
        }

        public bool atualizarModalidade()
        {
            bool atualizou = false;
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
                    MySqlCommand atual = new MySqlCommand("update Estudio_Modalidade set descricaoModalidade = '"+ Desc +"', precoModalidade = " + Prc + ", qtdeAlunos = " + qtde_alunos + ", qtdeAulas = " + qtde_aulas + " where idEstudio_Modalidade = " + id, DAO_Conexao.con);
                    atual.ExecuteNonQuery();
                    atualizou = true;
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
            return atualizou;
        }

        public bool atualizarModalidadeComDesc()
        {
            bool atualizou = false;
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
                    MySqlCommand atual = new MySqlCommand("update Estudio_Modalidade set descricaoModalidade = '" + nDesc + "', precoModalidade = " + Prc + ", qtdeAlunos = " + qtde_alunos + ", qtdeAulas = " + qtde_aulas + " where idEstudio_Modalidade = " + id, DAO_Conexao.con);
                    atual.ExecuteNonQuery();
                    atualizou = true;
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
            return atualizou;
        }

        public bool tornarAtivo()
        {
            bool ativou = false;
            MySqlDataReader result = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand cons = new MySqlCommand("select idEstudio_Modalidade from Estudio_Modalidade where descricaoModalidade ='" + Desc + "'", DAO_Conexao.con);
                result = cons.ExecuteReader();
                if(result.Read())
                {
                    int id = int.Parse(result["idEstudio_Modalidade"].ToString());
                    DAO_Conexao.con.Close();
                    DAO_Conexao.con.Open();
                    MySqlCommand ativa = new MySqlCommand("update Estudio_Modalidade set ativa = 0 where idEstudio_Modalidade = "+ id, DAO_Conexao.con);
                    ativa.ExecuteNonQuery();
                    ativou = true;
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
            return ativou;
        }

        public bool verificaInativo()
        {
            bool ativo = false;
            MySqlDataReader vAtiva = null;
            int atv = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand vAtiv = new MySqlCommand("select ativa from Estudio_Modalidade where descricaoModalidade = '" + Desc +"'", DAO_Conexao.con);
                vAtiva = vAtiv.ExecuteReader();
                while(vAtiva.Read())
                {
                    atv = int.Parse(vAtiva["ativa"].ToString());
                }
                if(atv == 1)
                {
                    ativo = true;
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
            return ativo;
        }

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

        public void desativaTurmaPorModalidade(int id)
        {
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand des = new MySqlCommand("update Estudio_Turma set ativa = 1 where idModalidade =" + id, DAO_Conexao.con);
                des.ExecuteNonQuery();
                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public bool consultarModalidadeExistente()
        {
            bool ex = true;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand vExist = new MySqlCommand("Select descricaoModalidade from Estudio_Modalidade", DAO_Conexao.con);
                MySqlDataReader vE = vExist.ExecuteReader();
                while(vE.Read())
                {
                    if(Desc == vE["descricaoModalidade"].ToString())
                    {
                        ex = false;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return ex;
        }

        public string consultarDescPorId(int id)
        {
            string desc = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand cDI = new MySqlCommand("select descricaoModalidade from Estudio_Modalidade where idEstudio_Modalidade =" + id, DAO_Conexao.con);
                MySqlDataReader exCDI = cDI.ExecuteReader();
                while(exCDI.Read())
                {
                    desc = exCDI["descricaoModalidade"].ToString();
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
            return desc;
        }

        public int consultarIdPorDesc(string desc)
        {
            int id = -1;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand iDC = new MySqlCommand("select idEstudio_Modalidade from Estudio_Modalidade where descricaoModalidade = '" + desc +"'", DAO_Conexao.con);
                MySqlDataReader exIDC = iDC.ExecuteReader();
                while (exIDC.Read())
                {
                    id = int.Parse(exIDC["idEstudio_Modalidade"].ToString());
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
            return id;
        }

        public int buscarMaxAlunosModalidade(int idM)
        {
            int qtdeMxA = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand schMaxAl = new MySqlCommand("select qtdeAlunos from Estudio_Modalidade where idEstudio_Modalidade = " + idM, DAO_Conexao.con);
                MySqlDataReader exSchMaxAl = schMaxAl.ExecuteReader();
                while(exSchMaxAl.Read())
                {
                    qtdeMxA = int.Parse(exSchMaxAl["qtdeAlunos"].ToString());
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
            return qtdeMxA;
        }
    }
}
