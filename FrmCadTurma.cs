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
    public partial class FrmCadTurma : Form
    {
        public FrmCadTurma()
        {
            InitializeComponent();
            txtMod.Enabled = false;
            WindowState = FormWindowState.Maximized;

            Modalidade con_mod = new Modalidade();
            MySqlDataReader r = con_mod.consultarModalidadesAtivas();
            while(r.Read()){
                dgvTurma.Rows.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void btnCadTurma_Click(object sender, EventArgs e)
        {
            int idMod = 0;
            string mod = txtMod.Text;
            string prof = txtProf.Text;
            string dia_sem = txtDS.Text;
            string hora = txtHora.Text;
            int qAl = int.Parse(txtNumAl.Text);
            Modalidade m = new Modalidade(mod);
            MySqlDataReader modDesc = m.consultarModalidade();
            while(modDesc.Read())
            {
                idMod = int.Parse(modDesc["idEstudio_Modalidade"].ToString());
            }
            DAO_Conexao.con.Close();
            Turma t = new Turma(idMod, prof, dia_sem, hora, qAl);
            if (t.verificaTurma() == false)
            {
                if (t.cadastrarTurma())
                {
                    MessageBox.Show("Turma cadastrada com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cadastro de turma falho.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Turma com tal modalidade, dias da semana e horário já existente.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMod.Text = dgvTurma.CurrentCell.Value.ToString();
        }
    }
}
