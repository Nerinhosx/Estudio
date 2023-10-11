﻿using MySql.Data.MySqlClient;
using System;
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
    public partial class Form5 : Form
    {
        public Form5()
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
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEnd.Text, txtNumero.Text, txtBairro.Text, txtComp.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text);
            if(aluno.atualizarAluno())
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
                if(aluno.consultarAluno())
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
                    }
                    DAO_Conexao.con.Close();
                }
                else
                {
                    DAO_Conexao.con.Close();
                    MessageBox.Show("Impossível prosseguir com atualização: aluno não cadastrado.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}