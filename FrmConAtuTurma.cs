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
    public partial class FrmConAtuTurma : Form
    {
        int option, line;
        public FrmConAtuTurma(int op)
        {
            InitializeComponent();

            option = op;
            txtMod.Enabled = false;
            btnAtv.Enabled = false;

            if (option == 0)
            {
                txtProf.Enabled = false;
                txtDS.Enabled = false;
                txtHora.Enabled = false;
                txtAl.Enabled = false;
                btnAtz.Enabled = false;
                btnAtz.Visible = false;
                btnAtv.Enabled = false;
                btnAtv.Visible = false;
            }

            Turma t = new Turma();
            MySqlDataReader consTA = null;
            if (option == 0)
            {
                consTA = t.consultarTurmasAtivasAtualizar();
            }
            else if(option == 1)
            {
                consTA = t.consultarTurmasAtualizar();
            }

            while(consTA.Read())
            {
                int idT = int.Parse(consTA["idEstudio_Turma"].ToString());
                string descM = consTA["descricaoModalidade"].ToString();
                string prof = consTA["professorTurma"].ToString();
                string ds = consTA["diasemanaTurma"].ToString();
                string hora = consTA["horaTurma"].ToString();
                int qtdAl = int.Parse(consTA["nalunosmatriculadosTurma"].ToString());

                dgvTurma.Rows.Add(idT, descM, prof, ds, hora, qtdAl);
            }
            DAO_Conexao.con.Close();
        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            line = int.Parse(dgvTurma.CurrentRow.Index.ToString());
            txtMod.Text = dgvTurma[1, line].Value.ToString();
            txtProf.Text = dgvTurma[2, line].Value.ToString();
            txtDS.Text = dgvTurma[3, line].Value.ToString();
            txtHora.Text = dgvTurma[4, line].Value.ToString();
            txtAl.Text = dgvTurma[5, line].Value.ToString();
            if(option == 1)
            {
                Turma t = new Turma();
                if(t.verificaTurmaInativa(int.Parse(dgvTurma[0, line].Value.ToString())))
                {
                    btnAtv.Enabled = true;
                }
                else
                {
                    btnAtv.Enabled = false;
                }
            }
        }

        private void btnAtz_Click(object sender, EventArgs e)
        {
            int idT = int.Parse(dgvTurma[0, line].Value.ToString());
            string prof = txtProf.Text;
            string ds = txtDS.Text;
            string hora = txtHora.Text;
            int qAl = int.Parse(txtAl.Text);
            Turma t = new Turma();
            if(t.atualizarTurma(idT, prof, ds, hora, qAl))
            {
                MessageBox.Show("Turma atualizada com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha na atualização da turma.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAtv_Click(object sender, EventArgs e)
        {
            Turma t = new Turma();
            if(t.ativarTurma(int.Parse(dgvTurma[0, line].Value.ToString())))
            {
                MessageBox.Show("Turma reativada com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha na reativação da turma.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
