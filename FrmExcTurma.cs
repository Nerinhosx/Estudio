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
        Turma t = new Turma();
        MySqlDataReader result;

        string descMod;
        string descDia;
            
        public FrmExcTurma()
        {
            InitializeComponent();

            result = t.consultarModTurmas();
            while (result.Read())
            {
                cbxMod.Items.Add(result["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();

            cbxHora.Enabled = false;
            cbxDS.Enabled = false;
        }

        private void cbxMod_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxDS.Items.Clear();
            cbxDS.Text = "";
            cbxHora.Items.Clear();
            cbxHora.Text = "";

            cbxDS.Enabled = true;

            descMod = cbxMod.SelectedItem.ToString();
            result = t.consultarDiaTurmas(descMod);
            while (result.Read())
            {
                cbxDS.Items.Add(result["diasemanaTurma"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void cbxDS_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxHora.Items.Clear();
            cbxHora.Text = "";

            cbxHora.Enabled = true;

            descDia = cbxDS.SelectedItem.ToString();
            result = t.consultarHoraTurmas(descMod, descDia);
            while (result.Read())
            {
                cbxHora.Items.Add(result["horaTurma"].ToString());
            }
            DAO_Conexao.con.Close();
        }
    }
}
