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
    public partial class FrmExcModalidade : Form
    {
        public FrmExcModalidade()
        {
            InitializeComponent();

            //---ComboBox recebendo os nomes das modalidades do banco de dados---
            Modalidade exc = new Modalidade();
            MySqlDataReader r = exc.consultarModalidadesAtivas();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
            btnExcMod.Enabled = false;
        }

        private void btnExcMod_Click(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade(comboBox1.Text);
            if (m.verificaInativo())
            {
                MessageBox.Show("Modalidade já excluída.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (m.excluirModalidade())
                {
                    MessageBox.Show("Modalidade excluída com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int id = m.consultarIdPorDesc(comboBox1.Text);
                    Console.WriteLine(id);
                    m.desativaTurmaPorModalidade(id);
                    btnExcMod.Enabled = false;
                    comboBox1.Text = "";
                    comboBox1.Items.Clear();
                    MySqlDataReader r = m.consultarModalidadesAtivas();
                    while (r.Read())
                    {
                        comboBox1.Items.Add(r["descricaoModalidade"].ToString());
                    }
                    DAO_Conexao.con.Close();
                }
                else
                {
                    MessageBox.Show("Exclusão de modalidade falha!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExcMod.Enabled = true;
        }
    }
}
