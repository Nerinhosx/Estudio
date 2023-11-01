using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Aluno
    {
        private string CPF;
        private string Nome;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string CEP;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Email;
        private byte[] Foto;
        private bool Ativo;

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email, byte[] foto)
        {
            setCPF(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCEP(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            setFoto(foto);
        }

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email)
        {
            setCPF(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCEP(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
        }

        public Aluno() {}

        public Aluno(string cpf)
        {
            setCPF(cpf);
        }

        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("Select * from Estudio_Aluno where CPFAluno='" + CPF + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if(resultado.Read())
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

        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno, fotoAluno) values ('" + CPF + "','" + Nome + "','" + Rua + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" + CEP + "','" + Cidade + "','" + Estado + "','" + Telefone + "','" + Email + "', @foto)", DAO_Conexao.con);
                insere.Parameters.AddWithValue("foto", this.Foto);
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

        public bool verificaCPF() //string CPF - sem parâmetro
        {
            int soma, resto, cont = 0;
            string cpf;
            soma = 0;

            cpf = CPF.Trim();
            cpf = cpf.Replace(",", "");
            cpf = cpf.Replace("-", "");

            for (int i = 0; i < cpf.Length; i++)
            {
                int a = cpf[0] - '0';
                int b = cpf[i] - '0';

                if (a == b) cont++;
            }

            if (cont == 11) return false;

            for (int i = 1; i <= 9; i++)
            {
                soma += int.Parse(cpf.Substring(i - 1, 1)) * (11 - i);
            }

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11))
            {
                resto = 0;
            }

            if (resto != int.Parse(cpf.Substring(9, 1)))
            {
                return false;
            }

            soma = 0;

            for (int i = 1; i <= 10; i++)
            {
                soma += int.Parse(cpf.Substring(i - 1, 1)) * (12 - i);
            }

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11))
            {
                resto = 0;
            }

            if (resto != int.Parse(cpf.Substring(10, 1)))
            {
                return false;
            }

            return true;
        }

        public bool excluirAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno set ativo = 1 where CPFAluno = '" + CPF + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
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

        public bool atualizarAluno()
        {
            bool alt = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Aluno set nomeAluno = '" + Nome + "', ruaAluno = '"+ Rua +"', numeroAluno = '"+ Numero +"', bairroAluno = '"+ Bairro +"', complementoAluno = '"+ Complemento +"', CEPAluno = '"+ CEP + "', cidadeAluno = '"+ Cidade +"', estadoAluno = '"+ Estado +"', telefoneAluno = '"+ Telefone +"', emailAluno = '"+ Email +"' where CPFAluno = '"+ CPF +"';", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                alt = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return alt;
        }

        public MySqlDataReader buscarDadosAluno()
        {
            MySqlDataReader result = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("Select * from Estudio_Aluno where CPFAluno='" + CPF + "'", DAO_Conexao.con);
                result = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        public bool verificaInativo()
        {
            bool inAtv = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand verIn = new MySqlCommand("select ativo from Estudio_Aluno where CPFAluno = '"+ CPF +"'", DAO_Conexao.con);
                MySqlDataReader exVerIn = verIn.ExecuteReader();
                while(exVerIn.Read())
                {
                    if(int.Parse(exVerIn["ativo"].ToString()) == 1)
                    {
                        inAtv = true;
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
            return inAtv;
        }

        public bool ativar()
        {
            bool reativ = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand reA = new MySqlCommand("update Estudio_Aluno set ativo = 0 where CPFAluno = '" + CPF + "'", DAO_Conexao.con);
                MySqlDataReader exReA = reA.ExecuteReader();
                reativ = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return reativ;
        }

        public string getCPF()
        {
            return CPF;
        }

        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }

        public string getNome()
        {
            return Nome;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public string getRua()
        {
            return Rua;
        }

        public void setRua(string rua)
        {
            Rua = rua;
        }

        public string getNumero()
        {
            return Numero;
        }

        public void setNumero(string numero)
        {
            Numero = numero;
        }

        public string getBairro()
        {
            return Bairro;
        }

        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }

        public string getComplemento()
        {
            return Complemento;
        }

        public void setComplemento(string complemento)
        {
            Complemento = complemento;
        }

        public string getCEP()
        {
            return CEP;
        }

        public void setCEP(string CEP)
        {
            this.CEP = CEP;
        }

        public string getCidade()
        {
            return Cidade;
        }

        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }

        public string getEstado()
        {
            return Estado;
        }

        public void setEstado(string estado)
        {
            Estado = estado;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public string getEmail()
        {
            return Email;
        }

        public void setEmail(string email)
        {
            Email = email;
        }

        public byte[] getFoto()
        {
            return Foto;
        }

        public void setFoto(byte[] foto)
        {
            Foto = foto;
        }

        public bool getAtivo()
        {
            return Ativo;
        }

        public void setAtivo(bool ativo)
        {
            Ativo = ativo;
        }
    }
}
