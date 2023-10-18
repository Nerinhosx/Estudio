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
        public FrmCadAlunoTurma()
        {
            InitializeComponent();

            dgvTurma.Enabled = false;
            btnCad.Enabled = false;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {

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
                        string mod = r["descricaoModalidade"].ToString();
                        string ds = r["diasemanaTurma"].ToString();
                        string h = r["horaTurma"].ToString();
                        dgvTurma.Rows.Add(mod, ds, h);
                    }
                    dgvTurma.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Aluno inexistente.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
