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
    public partial class Form7 : Form
    {
        public Form7()
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
        }

        private void btnExcMod_Click(object sender, EventArgs e)
        {
            Modalidade m = new Modalidade(comboBox1.Text);
            if(m.excluirModalidade())
            {
                MessageBox.Show("Modalidade excluída com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Exclusão de modalidade falha!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
