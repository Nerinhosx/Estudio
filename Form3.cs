﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            txtNome.Enabled = false;
            txtEnd.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCompl.Enabled = false;
            txtCEP.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtTel.Enabled = false;
            txtEmail.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] foto = ConverterFotoParaByteArray();
            Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEnd.Text, txtNumero.Text, txtBairro.Text, txtCompl.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text, foto);
            
            if (aluno.cadastrarAluno())
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastro!");
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);

            if(e.KeyChar == 13)
            {
                if (aluno.verificaCPF())
                {
                    if (aluno.consultarAluno())
                    {
                        MessageBox.Show("Aluno já cadastrado!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        txtNome.Enabled = true;
                        txtEnd.Enabled = true;
                        txtNumero.Enabled = true;
                        txtBairro.Enabled = true;
                        txtCompl.Enabled = true;
                        txtCEP.Enabled = true;
                        txtCidade.Enabled = true;
                        txtEstado.Enabled = true;
                        txtTel.Enabled = true;
                        txtEmail.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        txtNome.Focus();
                    }
                    DAO_Conexao.con.Close();
                }
                else
                {
                    MessageBox.Show("Falha no cadastro: CPF inválido.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if(dialog.ShowDialog() == DialogResult.OK)
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
