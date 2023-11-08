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
        string descHora;
            
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
            btnExcTurma.Enabled = false;
        }

        private void cbxMod_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxDS.Items.Clear();
            cbxDS.Text = null;
            cbxHora.Items.Clear();
            cbxHora.Text = null;

            btnExcTurma.Enabled = false;

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
            cbxHora.Text = null;

            btnExcTurma.Enabled = false;

            cbxHora.Enabled = true;

            descDia = cbxDS.SelectedItem.ToString();
            result = t.consultarHoraTurmas(descMod, descDia);
            while (result.Read())
            {
                cbxHora.Items.Add(result["horaTurma"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void cbxHora_SelectedValueChanged(object sender, EventArgs e)
        {
            descMod = cbxMod.SelectedItem.ToString();
            descDia = cbxDS.SelectedItem.ToString();
            descHora = cbxHora.SelectedItem.ToString();

            btnExcTurma.Enabled = false;

            if (t.verficaTurmaAtiva(descMod, descDia, descHora))
            {
                btnExcTurma.Enabled = true;
            }
        }

        private void btnExcTurma_Click(object sender, EventArgs e)
        {
            descMod = cbxMod.SelectedItem.ToString();
            descDia = cbxDS.SelectedItem.ToString();
            descHora = cbxHora.SelectedItem.ToString();

            if (t.excluirTurma(descMod, descDia, descHora))
            {
                MessageBox.Show("Turma excluída com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxDS.Text = "";
                cbxDS.Items.Clear();
                cbxDS.Enabled = false;

                cbxHora.Text = "";
                cbxHora.Items.Clear();
                cbxHora.Enabled = false;

                cbxMod.Text = "";
                cbxMod.Items.Clear();
                result = t.consultarModTurmas();
                while (result.Read())
                {
                    cbxMod.Items.Add(result["descricaoModalidade"].ToString());
                }
                DAO_Conexao.con.Close();
            }
            else
            {
                MessageBox.Show("Exclusão de turma falha.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
