﻿
namespace Estudio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarModalidadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarModalidadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarModalidadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirModalidadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTurmaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.alunoToolStripMenuItem,
            this.modalidadeToolStripMenuItem,
            this.turmaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLoginToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.arquivoToolStripMenuItem.Text = "Login";
            // 
            // cadastrarLoginToolStripMenuItem
            // 
            this.cadastrarLoginToolStripMenuItem.Name = "cadastrarLoginToolStripMenuItem";
            this.cadastrarLoginToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cadastrarLoginToolStripMenuItem.Text = "Cadastrar Login";
            this.cadastrarLoginToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLoginToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.consultarAlunoToolStripMenuItem,
            this.atualizarAlunoToolStripMenuItem,
            this.excluirAlunoToolStripMenuItem,
            this.toolStripSeparator3,
            this.sairToolStripMenuItem2});
            this.alunoToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar aluno";
            this.cadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem_Click);
            // 
            // consultarAlunoToolStripMenuItem
            // 
            this.consultarAlunoToolStripMenuItem.Name = "consultarAlunoToolStripMenuItem";
            this.consultarAlunoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.consultarAlunoToolStripMenuItem.Text = "Consultar aluno";
            this.consultarAlunoToolStripMenuItem.Click += new System.EventHandler(this.consultarAlunoToolStripMenuItem_Click);
            // 
            // atualizarAlunoToolStripMenuItem
            // 
            this.atualizarAlunoToolStripMenuItem.Name = "atualizarAlunoToolStripMenuItem";
            this.atualizarAlunoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.atualizarAlunoToolStripMenuItem.Text = "Atualizar aluno";
            this.atualizarAlunoToolStripMenuItem.Click += new System.EventHandler(this.atualizarAlunoToolStripMenuItem_Click);
            // 
            // excluirAlunoToolStripMenuItem
            // 
            this.excluirAlunoToolStripMenuItem.Name = "excluirAlunoToolStripMenuItem";
            this.excluirAlunoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.excluirAlunoToolStripMenuItem.Text = "Excluir aluno";
            this.excluirAlunoToolStripMenuItem.Click += new System.EventHandler(this.excluirAlunoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(166, 6);
            // 
            // sairToolStripMenuItem2
            // 
            this.sairToolStripMenuItem2.Name = "sairToolStripMenuItem2";
            this.sairToolStripMenuItem2.Size = new System.Drawing.Size(169, 22);
            this.sairToolStripMenuItem2.Text = "Sair";
            this.sairToolStripMenuItem2.Click += new System.EventHandler(this.sairToolStripMenuItem2_Click);
            // 
            // modalidadeToolStripMenuItem
            // 
            this.modalidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarModalidadeToolStripMenuItem1,
            this.consultarModalidadeToolStripMenuItem1,
            this.atualizarModalidadeToolStripMenuItem1,
            this.excluirModalidadeToolStripMenuItem1,
            this.toolStripSeparator4,
            this.sairToolStripMenuItem3});
            this.modalidadeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalidadeToolStripMenuItem.Name = "modalidadeToolStripMenuItem";
            this.modalidadeToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.modalidadeToolStripMenuItem.Text = "Modalidade";
            // 
            // cadastrarModalidadeToolStripMenuItem1
            // 
            this.cadastrarModalidadeToolStripMenuItem1.Name = "cadastrarModalidadeToolStripMenuItem1";
            this.cadastrarModalidadeToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.cadastrarModalidadeToolStripMenuItem1.Text = "Cadastrar modalidade";
            this.cadastrarModalidadeToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarModalidadeToolStripMenuItem1_Click);
            // 
            // consultarModalidadeToolStripMenuItem1
            // 
            this.consultarModalidadeToolStripMenuItem1.Name = "consultarModalidadeToolStripMenuItem1";
            this.consultarModalidadeToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.consultarModalidadeToolStripMenuItem1.Text = "Consultar modalidade";
            this.consultarModalidadeToolStripMenuItem1.Click += new System.EventHandler(this.consultarModalidadeToolStripMenuItem1_Click);
            // 
            // atualizarModalidadeToolStripMenuItem1
            // 
            this.atualizarModalidadeToolStripMenuItem1.Name = "atualizarModalidadeToolStripMenuItem1";
            this.atualizarModalidadeToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.atualizarModalidadeToolStripMenuItem1.Text = "Atualizar modalidade";
            this.atualizarModalidadeToolStripMenuItem1.Click += new System.EventHandler(this.atualizarModalidadeToolStripMenuItem1_Click);
            // 
            // excluirModalidadeToolStripMenuItem1
            // 
            this.excluirModalidadeToolStripMenuItem1.Name = "excluirModalidadeToolStripMenuItem1";
            this.excluirModalidadeToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.excluirModalidadeToolStripMenuItem1.Text = "Excluir modalidade";
            this.excluirModalidadeToolStripMenuItem1.Click += new System.EventHandler(this.excluirModalidadeToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // sairToolStripMenuItem3
            // 
            this.sairToolStripMenuItem3.Name = "sairToolStripMenuItem3";
            this.sairToolStripMenuItem3.Size = new System.Drawing.Size(204, 22);
            this.sairToolStripMenuItem3.Text = "Sair";
            this.sairToolStripMenuItem3.Click += new System.EventHandler(this.sairToolStripMenuItem3_Click);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTurmaToolStripMenuItem,
            this.consultarTurmaToolStripMenuItem1,
            this.atualizarTurmaToolStripMenuItem,
            this.excluirTurmaToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem1});
            this.turmaToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.turmaToolStripMenuItem.Text = "Turma";
            // 
            // cadastrarTurmaToolStripMenuItem
            // 
            this.cadastrarTurmaToolStripMenuItem.Name = "cadastrarTurmaToolStripMenuItem";
            this.cadastrarTurmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarTurmaToolStripMenuItem.Text = "Cadastrar Turma";
            this.cadastrarTurmaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTurmaToolStripMenuItem_Click);
            // 
            // consultarTurmaToolStripMenuItem1
            // 
            this.consultarTurmaToolStripMenuItem1.Name = "consultarTurmaToolStripMenuItem1";
            this.consultarTurmaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.consultarTurmaToolStripMenuItem1.Text = "Consultar Turma";
            this.consultarTurmaToolStripMenuItem1.Click += new System.EventHandler(this.consultarTurmaToolStripMenuItem1_Click);
            // 
            // atualizarTurmaToolStripMenuItem
            // 
            this.atualizarTurmaToolStripMenuItem.Name = "atualizarTurmaToolStripMenuItem";
            this.atualizarTurmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarTurmaToolStripMenuItem.Text = "Atualizar Turma";
            // 
            // excluirTurmaToolStripMenuItem
            // 
            this.excluirTurmaToolStripMenuItem.Name = "excluirTurmaToolStripMenuItem";
            this.excluirTurmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirTurmaToolStripMenuItem.Text = "Excluir Turma";
            this.excluirTurmaToolStripMenuItem.Click += new System.EventHandler(this.excluirTurmaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(209, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validação";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "12343";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Arthur Nero";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Estúdio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarModalidadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarModalidadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atualizarModalidadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirModalidadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultarTurmaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atualizarTurmaToolStripMenuItem;
    }
}

