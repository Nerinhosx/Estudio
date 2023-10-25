
namespace Estudio
{
    partial class FrmCadExcAlunoTurma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadExc = new System.Windows.Forms.Button();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.idTurmaCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadExc);
            this.groupBox1.Controls.Add(this.dgvTurma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno/Turma";
            // 
            // btnCadExc
            // 
            this.btnCadExc.Location = new System.Drawing.Point(9, 279);
            this.btnCadExc.Name = "btnCadExc";
            this.btnCadExc.Size = new System.Drawing.Size(410, 29);
            this.btnCadExc.TabIndex = 3;
            this.btnCadExc.Text = "Cadastrar";
            this.btnCadExc.UseVisualStyleBackColor = true;
            this.btnCadExc.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // dgvTurma
            // 
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTurmaCad,
            this.modalidade,
            this.diaSemana,
            this.hora});
            this.dgvTurma.Location = new System.Drawing.Point(6, 63);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.Size = new System.Drawing.Size(413, 210);
            this.dgvTurma.TabIndex = 2;
            this.dgvTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurma_CellClick);
            // 
            // idTurmaCad
            // 
            this.idTurmaCad.HeaderText = "ID";
            this.idTurmaCad.Name = "idTurmaCad";
            this.idTurmaCad.Width = 70;
            // 
            // modalidade
            // 
            this.modalidade.HeaderText = "Modalidade";
            this.modalidade.Name = "modalidade";
            // 
            // diaSemana
            // 
            this.diaSemana.HeaderText = "Dia da Semana";
            this.diaSemana.Name = "diaSemana";
            // 
            // hora
            // 
            this.hora.HeaderText = "Horário";
            this.hora.Name = "hora";
            this.hora.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF do Aluno:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(87, 23);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(84, 20);
            this.txtCPF.TabIndex = 0;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // FrmCadAlunoTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 339);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCadAlunoTurma";
            this.Text = "Matricular Aluno em Turma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnCadExc;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurmaCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
    }
}