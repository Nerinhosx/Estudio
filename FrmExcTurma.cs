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
    public partial class FrmExcTurma : Form
    {
        public FrmExcTurma()
        {
            InitializeComponent();

            cbxHora.Enabled = false;
            cbxDS.Enabled = false;


            Modalidade con_mod = new Modalidade();
            MySqlDataReader r = con_mod.consultarTodasModalidades();
            while (r.Read())
            {
                cbxMod.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void cbxMod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExcTurma_Click(object sender, EventArgs e)
        {

        }
    }
}
