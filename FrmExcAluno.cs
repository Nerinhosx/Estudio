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
    public partial class FrmExcAluno : Form
    {
        public FrmExcAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text);
            if(aluno.consultarAluno())
            {
                DAO_Conexao.con.Close();
                if (aluno.excluirAluno())
                {
                    MessageBox.Show("Aluno excluído!");
                }
            }
        }
    }
}
