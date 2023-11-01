
namespace Estudio
{
    partial class FrmConAlunoTurma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.idTurmaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descModalidadeTurmaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaSemanaTurmaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioTurmaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.cpfAlunoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAlunoDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurma
            // 
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTurmaDgv,
            this.descModalidadeTurmaDgv,
            this.diaSemanaTurmaDgv,
            this.horarioTurmaDgv});
            this.dgvTurma.Location = new System.Drawing.Point(7, 52);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.Size = new System.Drawing.Size(443, 199);
            this.dgvTurma.TabIndex = 0;
            // 
            // idTurmaDgv
            // 
            this.idTurmaDgv.HeaderText = "ID";
            this.idTurmaDgv.Name = "idTurmaDgv";
            this.idTurmaDgv.Width = 65;
            // 
            // descModalidadeTurmaDgv
            // 
            this.descModalidadeTurmaDgv.HeaderText = "Modalidade";
            this.descModalidadeTurmaDgv.Name = "descModalidadeTurmaDgv";
            this.descModalidadeTurmaDgv.Width = 150;
            // 
            // diaSemanaTurmaDgv
            // 
            this.diaSemanaTurmaDgv.HeaderText = "Dia da Semana";
            this.diaSemanaTurmaDgv.Name = "diaSemanaTurmaDgv";
            this.diaSemanaTurmaDgv.Width = 115;
            // 
            // horarioTurmaDgv
            // 
            this.horarioTurmaDgv.HeaderText = "Horário";
            this.horarioTurmaDgv.Name = "horarioTurmaDgv";
            this.horarioTurmaDgv.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvAlunos);
            this.groupBox1.Controls.Add(this.dgvTurma);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 493);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma/Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alunos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turmas:";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpfAlunoDgv,
            this.nomeAlunoDgv});
            this.dgvAlunos.Location = new System.Drawing.Point(11, 297);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(244, 190);
            this.dgvAlunos.TabIndex = 1;
            this.dgvAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellClick);
            // 
            // cpfAlunoDgv
            // 
            this.cpfAlunoDgv.HeaderText = "CPF";
            this.cpfAlunoDgv.Name = "cpfAlunoDgv";
            // 
            // nomeAlunoDgv
            // 
            this.nomeAlunoDgv.HeaderText = "Nome";
            this.nomeAlunoDgv.Name = "nomeAlunoDgv";
            // 
            // FrmConAlunoTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 518);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConAlunoTurma";
            this.Text = "Consultar Alunos da Turma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurmaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn descModalidadeTurmaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaSemanaTurmaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioTurmaDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfAlunoDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAlunoDgv;
    }
}