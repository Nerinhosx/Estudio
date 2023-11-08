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
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text);
            if(aluno.consultarAluno())
            {
                if (aluno.verificaInativo())
                {
                    MessageBox.Show("Aluno já excluído.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (aluno.excluirAluno())
                    {
                        MessageBox.Show("Aluno excluído!", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro na exclusão.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado.", "O sistema informa:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            maskedTextBox1.Clear();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
