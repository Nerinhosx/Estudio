using MySql.Data.MySqlClient;
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
    public partial class FrmCadAlunoTurma : Form
    {
        int line, id, option;
        public FrmCadAlunoTurma(int op)
        {
            InitializeComponent();

            option = op;

            dgvTurma.Enabled = false;
            btnCadExc.Enabled = false;

            if(option == 1)
            {
                btnCadExc.Text = "Excluir";
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Aluno al = new Aluno(txtCPF.Text);
                if (al.consultarAluno())
                {
                    if (option == 0)
                    {
                        Turma t = new Turma();
                        MySqlDataReader r = t.consultarTurmasAtivas();
                        while (r.Read())
                        {
                            int idT = int.Parse(r["idEstudio_Turma"].ToString());
                            string mod = r["descricaoModalidade"].ToString();
                            string ds = r["diasemanaTurma"].ToString();
                            string h = r["horaTurma"].ToString();
                            dgvTurma.Rows.Add(idT, mod, ds, h);
                        }
                        DAO_Conexao.con.Close();
                        dgvTurma.Enabled = true;
                    }
                    else if (option == 1)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Erro na busca de aluno: aluno inexistente.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            line = dgvTurma.CurrentRow.Index;
            id = (int)dgvTurma[0, line].Value;
            btnCadExc.Enabled = true;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade();
            Turma t = new Turma();
            AlunoEmTurma alT = new AlunoEmTurma(txtCPF.Text, id);
            int idM = t.buscaIdModalidadePorIdTurma(id);
            int qtdeMaxAl = m.buscarMaxAlunosModalidade(idM);
            int totAlMat = t.buscaAlTotalEmMod(idM);
            if(totAlMat < qtdeMaxAl)
            {
                if (alT.verificaMatriculado())
                {
                    MessageBox.Show("Erro na matrícula: Aluno já cadastrado nessa Turma.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (alT.matricularAluno())
                    {
                        MessageBox.Show("Aluno matriculado com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro na matrícula.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Limite de alunos atingido.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
