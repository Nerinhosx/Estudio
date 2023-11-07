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
    public partial class FrmConAtuModalidade : Form
    {
        int opcao;
        public FrmConAtuModalidade(int op)
        {
            InitializeComponent();
            opcao = op;
            Modalidade exc = new Modalidade();
            MySqlDataReader r = exc.consultarTodasModalidades();
            while (r.Read())
            {
                cbxDesc.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if(opcao == 0)
            {
                btnAtualizar_Consultar.Text = ("Consultar");
                btnAtivar.Visible = false;
                btnAtivar.Enabled = true;

                txtPrc.Enabled = false;
                txtAu.Enabled = false;
                txtAl.Enabled = false;
            }
            if(opcao == 1)
            {
                this.Text = "Atualizar Modalidades";
                btnAtualizar_Consultar.Text = ("Atualizar");
                btnAtivar.Visible = true;
                btnAtivar.Enabled = false;

                txtPrc.Enabled = true;
                txtAu.Enabled = true;
                txtAl.Enabled = true;
            }
        }

        private void btnAtualizar_Consultar_Click(object sender, EventArgs e)
        {
            if(opcao == 0)
            {
                Modalidade m = new Modalidade(cbxDesc.Text);
                MySqlDataReader r = m.consultarModalidade();
                while (r.Read())
                {
                    txtPrc.Text = r["precoModalidade"].ToString();
                    txtAl.Text = r["qtdeAlunos"].ToString();
                    txtAu.Text = r["qtdeAulas"].ToString();
                }
                DAO_Conexao.con.Close();
            }
            if(opcao == 1)
            {
                String desc = cbxDesc.Text;
                float prc = float.Parse(txtPrc.Text);
                int qAl = int.Parse(txtAl.Text);
                int qAu = int.Parse(txtAu.Text);
                Modalidade m = new Modalidade(desc, prc, qAl, qAu);
                if(m.atualizarModalidade())
                {
                    MessageBox.Show("Modalidade atualizada com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Atualização de modalidade falha.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opcao == 1)
            {
                Modalidade m = new Modalidade(cbxDesc.Text);
                MySqlDataReader r = m.consultarModalidade();
                while (r.Read())
                {
                    txtPrc.Text = r["precoModalidade"].ToString();
                    txtAl.Text = r["qtdeAlunos"].ToString();
                    txtAu.Text = r["qtdeAulas"].ToString();
                }
                DAO_Conexao.con.Close();
                if(m.verificaInativo())
                {
                    btnAtivar.Enabled = true;
                }
                else
                {
                    btnAtivar.Enabled = false;
                }
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade(cbxDesc.Text);
            if(m.tornarAtivo())
            {
                MessageBox.Show("Modalidade ativada com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ativação de modalidade falha.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
