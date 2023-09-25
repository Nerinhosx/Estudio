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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnCadMod_Click(object sender, EventArgs e)
        {
            double prc = double.Parse(txtPrcCadMod.Text);
            int al = int.Parse(txtAlCadMod.Text);
            int au = int.Parse(txtAuCadMod.Text);
            Modalidade mod = new Modalidade(txtDescCadMod.Text, prc, al, au);

            if(mod.cadastrarModalidade())
            {
                MessageBox.Show("Modalidade cadastrada com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cadastro de modalidade falho.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
