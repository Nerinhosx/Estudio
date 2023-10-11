using MySql.Data.MySqlClient;
using System;
using System.Collections;
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

            Turma t = new Turma();
            MySqlDataReader result = t.consultarTurmas01();
            while (result.Read())
            {
                cbxMod.Items.Add(result["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();

            cbxHora.Enabled = false;
            cbxDS.Enabled = false;
        }

        private void btnExcTurma_Click(object sender, EventArgs e)
        {

        }

        private void cbxMod_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxDS.Enabled = true;
        }
    }
}
