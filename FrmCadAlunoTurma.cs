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
        int line, id;
        public FrmCadAlunoTurma()
        {
            InitializeComponent();

            dgvTurma.Enabled = false;
            btnCad.Enabled = false;
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Aluno al = new Aluno(txtCPF.Text);
                if (al.consultarAluno())
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
            btnCad.Enabled = true;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            AlunoEmTurma alT = new AlunoEmTurma(txtCPF.Text, id);
            if(alT.verificaMatriculado())
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
    }
}
