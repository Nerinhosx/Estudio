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
    public partial class FrmConAlunoTurma : Form
    {
        int line;
        public FrmConAlunoTurma()
        {
            InitializeComponent();

            AlunoEmTurma alT = new AlunoEmTurma();
            MySqlDataReader r = alT.turmasComMatricula();
            while(r.Read())
            {
                int idT = int.Parse(r["idEstudio_Turma"].ToString());
                string desc = r["descricaoModalidade"].ToString();
                string ds = r["diasemanaTurma"].ToString();
                string hr = r["horaTurma"].ToString();
                dgvTurma.Rows.Add(idT, desc, ds, hr);
            }
            DAO_Conexao.con.Close();
        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvAlunos.Rows.Clear();
            line = dgvTurma.CurrentRow.Index;
            int idT = (int)dgvTurma[0, line].Value;
            AlunoEmTurma alT = new AlunoEmTurma();
            MySqlDataReader r = alT.buscaAlunosEmTurma(idT);
            while(r.Read())
            {
                string cpf = r["CPFAluno"].ToString();
                string nome = r["nomeAluno"].ToString();
                dgvAlunos.Rows.Add(cpf, nome);
            }
            DAO_Conexao.con.Close();
        }
    }
}
