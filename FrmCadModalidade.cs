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
    public partial class FrmCadModalidade : Form
    {
        public FrmCadModalidade()
        {
            InitializeComponent();
        }

        private void btnCadMod_Click(object sender, EventArgs e)
        {
            float prc = float.Parse(txtPrcCadMod.Text);
            int al = int.Parse(txtAlCadMod.Text);
            int au = int.Parse(txtAuCadMod.Text);
            Modalidade mod = new Modalidade(txtDescCadMod.Text, prc, al, au);

            if(mod.consultarModalidadeExistente())
            {
                if (mod.cadastrarModalidade())
                {
                    MessageBox.Show("Modalidade cadastrada com sucesso!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cadastro de modalidade falho.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Cadastro de modalidade falho: modalidade com a referida Descrição já cadastrada.", "O sistema infoma:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
