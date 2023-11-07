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
    public partial class FrmLogin : Form
    {
        private static MySqlConnection con = new MySqlConnection();

        public FrmLogin()
        {
            InitializeComponent();

            menuStrip1.Enabled = false;

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202227", "cl202227", "cl*04042007"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de Conexão");
        }

        //Início ToolStrip Login
        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadUser form2 = new FrmCadUser();
            form2.MdiParent = this;
            form2.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Fim ToolStrip Login

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.Login(textBox1.Text, textBox2.Text);
            if(tipo==0)
            {
                MessageBox.Show("Usuário/Senha inválidos!");
            }
            else if(tipo==1)
            {
               // MessageBox.Show("Usuário adm.");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
            }
            else
            {
               // MessageBox.Show("Usuário restrito.");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarLoginToolStripMenuItem.Enabled = false;
                cadastrarModalidadeToolStripMenuItem1.Enabled = false;
                atualizarModalidadeToolStripMenuItem1.Enabled = false;
                excluirModalidadeToolStripMenuItem1.Enabled = false;
                cadastrarTurmaToolStripMenuItem.Enabled = false;
                atualizarTurmaToolStripMenuItem.Enabled = false;
                excluirTurmaToolStripMenuItem.Enabled = false;
            }
        }

        //Início ToolStrip Aluno
        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadAluno form3 = new FrmCadAluno();
            form3.MdiParent = this;
            form3.Show();
        }

        private void consultarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConAtuAluno form5 = new FrmConAtuAluno(0);
            form5.MdiParent = this;
            form5.Text = "Consultar Aluno";
            form5.Show();
        }

        private void atualizarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConAtuAluno form5 = new FrmConAtuAluno(1);
            form5.MdiParent = this;
            form5.Show();
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcAluno form4 = new FrmExcAluno();
            form4.MdiParent = this;
            form4.Show();
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Fim ToolStrip Aluno

        //Início toolStrip Modalidade
        private void cadastrarModalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadModalidade form6 = new FrmCadModalidade();
            form6.MdiParent = this;
            form6.Show();
        }

        private void consultarModalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConAtuModalidade form8 = new FrmConAtuModalidade(0);
            form8.MdiParent = this;
            form8.Show();
        }

        private void atualizarModalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConAtuModalidade form8 = new FrmConAtuModalidade(1);
            form8.MdiParent = this;
            form8.Show();
        }

        private void excluirModalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmExcModalidade form7 = new FrmExcModalidade();
            form7.MdiParent = this;
            form7.Show();
        }

        private void sairToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Fim ToolStrip Modalidade

        //Início ToolStrip Turma
        private void cadastrarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadTurma frmCadTurma = new FrmCadTurma();
            frmCadTurma.MdiParent = this;
            frmCadTurma.Show();
        }

        private void excluirTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcTurma frmExcTurma = new FrmExcTurma();
            frmExcTurma.MdiParent = this;
            frmExcTurma.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultarTurmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConAtuTurma frmConAtuTurma = new FrmConAtuTurma(0);
            frmConAtuTurma.MdiParent = this;
            frmConAtuTurma.Show();
        }

        private void atualizarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConAtuTurma frmConAtuTurma = new FrmConAtuTurma(1);
            frmConAtuTurma.MdiParent = this;
            frmConAtuTurma.Text = "Atualizar Turma";
            frmConAtuTurma.Show();
        }
        //Fim ToolStrip Turma

        //Início ToolStrip Aluno -> Turma
        private void sairToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void matricularAlunoEmTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadExcAlunoTurma frmCadAlunoTurma = new FrmCadExcAlunoTurma(0);
            frmCadAlunoTurma.MdiParent = this;
            frmCadAlunoTurma.Show();
        }

        private void desmatricularAlunoDeTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadExcAlunoTurma frmCadAlunoTurma = new FrmCadExcAlunoTurma(1);
            frmCadAlunoTurma.MdiParent = this;
            frmCadAlunoTurma.Text = "Desmatricular Aluno de Turma";
            frmCadAlunoTurma.Show();
        }

        private void consultarAlunosEmTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConAlunoTurma frmConAlunoTurma = new FrmConAlunoTurma();
            frmConAlunoTurma.MdiParent = this;
            frmConAlunoTurma.Show();
        }
        //Fim ToolStrip Aluno -> Turma
    }
}
