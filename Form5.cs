using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class Form5 : Form
    {
        int option;
        public Form5(int op)
        {
            InitializeComponent();
            txtNome.Enabled = false;
            txtEnd.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtComp.Enabled = false;
            txtCEP.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtTel.Enabled = false;
            txtEmail.Enabled = false;
            btnAtualizar.Enabled = false;
            button1.Enabled = false;
            btnAtivar.Enabled = false;

            option = op;

            if(option == 0)
            {
                button1.Visible = false;
                btnAtualizar.Visible = false;
                btnAtivar.Visible = false;
                groupBox1.Text = "Consulta";
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            byte[] foto = ConverterFotoParaByteArray();
            Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEnd.Text, txtNumero.Text, txtBairro.Text, txtComp.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text, foto);
            if (aluno.atualizarAluno())
            {
                MessageBox.Show("Aluno atualizado com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Atualização falha.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);
            if (e.KeyChar == 13)
            {
                if(option == 1)
                {
                    if (aluno.consultarAluno())
                    {
                        DAO_Conexao.con.Close();
                        txtNome.Enabled = true;
                        txtEnd.Enabled = true;
                        txtNumero.Enabled = true;
                        txtBairro.Enabled = true;
                        txtComp.Enabled = true;
                        txtCEP.Enabled = true;
                        txtCidade.Enabled = true;
                        txtEstado.Enabled = true;
                        txtTel.Enabled = true;
                        txtEmail.Enabled = true;
                        btnAtualizar.Enabled = true;
                        button1.Enabled = true;
                        txtCPF.Enabled = false;

                        MySqlDataReader r = aluno.buscarDadosAluno();
                        if (r.Read())
                        {
                            txtNome.Text = r["nomeAluno"].ToString();
                            txtEnd.Text = r["ruaAluno"].ToString();
                            txtNumero.Text = r["numeroAluno"].ToString();
                            txtBairro.Text = r["bairroAluno"].ToString();
                            txtComp.Text = r["complementoAluno"].ToString();
                            txtCEP.Text = r["CEPAluno"].ToString();
                            txtCidade.Text = r["cidadeAluno"].ToString();
                            txtEstado.Text = r["estadoAluno"].ToString();
                            txtTel.Text = r["telefoneAluno"].ToString();
                            txtEmail.Text = r["emailAluno"].ToString();
                            try
                            {
                                string imagem = Convert.ToString(DateTime.Now.ToFileTime());
                                byte[] bimage = (byte[])r["fotoAluno"];
                                FileStream fs = new FileStream(imagem, FileMode.CreateNew, FileAccess.Write);
                                fs.Write(bimage, 0, bimage.Length - 1);
                                fs.Close();
                                pictureBox1.Image = Image.FromFile(imagem);
                                r.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Erro ao carregar a foto");
                            }
                        }
                        DAO_Conexao.con.Close();
                        if(aluno.verificaInativo())
                        {
                            btnAtivar.Enabled = true;
                        }
                    }
                    else
                    {
                        DAO_Conexao.con.Close();
                        MessageBox.Show("Impossível prosseguir com atualização: aluno não cadastrado.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if(option == 0)
                {
                    if (aluno.consultarAluno())
                    {
                        DAO_Conexao.con.Close();
                        txtNome.Enabled = false;
                        txtEnd.Enabled = false;
                        txtNumero.Enabled = false;
                        txtBairro.Enabled = false;
                        txtComp.Enabled = false;
                        txtCEP.Enabled = false;
                        txtCidade.Enabled = false;
                        txtEstado.Enabled = false;
                        txtTel.Enabled = false;
                        txtEmail.Enabled = false;
                        btnAtualizar.Enabled = false;
                        button1.Enabled = false;
                        txtCPF.Enabled = false;

                        MySqlDataReader r = aluno.buscarDadosAluno();
                        if (r.Read())
                        {
                            txtNome.Text = r["nomeAluno"].ToString();
                            txtEnd.Text = r["ruaAluno"].ToString();
                            txtNumero.Text = r["numeroAluno"].ToString();
                            txtBairro.Text = r["bairroAluno"].ToString();
                            txtComp.Text = r["complementoAluno"].ToString();
                            txtCEP.Text = r["CEPAluno"].ToString();
                            txtCidade.Text = r["cidadeAluno"].ToString();
                            txtEstado.Text = r["estadoAluno"].ToString();
                            txtTel.Text = r["telefoneAluno"].ToString();
                            txtEmail.Text = r["emailAluno"].ToString();
                            try
                            {
                                string imagem = Convert.ToString(DateTime.Now.ToFileTime());
                                byte[] bimage = (byte[])r["fotoAluno"];
                                FileStream fs = new FileStream(imagem, FileMode.CreateNew, FileAccess.Write);
                                fs.Write(bimage, 0, bimage.Length - 1);
                                fs.Close();
                                pictureBox1.Image = Image.FromFile(imagem);
                                r.Close();
                            }
                            catch
                            {
                                pictureBox1.Image = Image.FromFile("negado.png");
                                MessageBox.Show("Erro ao carregar a foto");
                            }
                        }
                        DAO_Conexao.con.Close();
                    }
                    else
                    {
                        DAO_Conexao.con.Close();
                        MessageBox.Show("Impossível prosseguir com a consulta: aluno não cadastrado.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            Aluno al = new Aluno(txtCPF.Text);
            if(al.ativar())
            {
                MessageBox.Show("Aluno reativado com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha na reativação.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: não foi possível carregar a foto.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dialog.Dispose();
        }

        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }
    }
}
