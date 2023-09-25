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

            //---ComboBox recebendo os nomes das modalidades do banco---
            Modalidade exc = new Modalidade();
            MySqlDataReader r = exc.consultarTodasModalidades();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void btnExcMod_Click(object sender, EventArgs e)
        {

        }
    }
}
