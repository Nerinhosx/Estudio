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
    public partial class Form8 : Form
    {
        int opcao;
        public Form8(int op)
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
        }
    }
}
