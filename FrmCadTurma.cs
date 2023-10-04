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
    public partial class FrmCadTurma : Form
    {
        public FrmCadTurma()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            Modalidade con_mod = new Modalidade();
            MySqlDataReader r = con_mod.consultarTodasModalidades();
            while(r.Read()){
                dgvTurma.Rows.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }
    }
}
