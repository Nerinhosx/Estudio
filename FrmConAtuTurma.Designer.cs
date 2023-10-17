
namespace Estudio
{
    partial class FrmConAtuTurma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.txtDS = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnAtz = new System.Windows.Forms.Button();
            this.btnAtv = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMaxAl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTurma
            // 
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.modalidade,
            this.prof,
            this.dia_semana,
            this.hora,
            this.nMaxAl});
            this.dgvTurma.Location = new System.Drawing.Point(12, 12);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.Size = new System.Drawing.Size(643, 150);
            this.dgvTurma.TabIndex = 0;
            this.dgvTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurma_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtv);
            this.groupBox1.Controls.Add(this.btnAtz);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.txtDS);
            this.groupBox1.Controls.Add(this.txtProf);
            this.groupBox1.Controls.Add(this.txtMod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(64, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia(s) da semana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horário:";
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(78, 29);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(167, 20);
            this.txtMod.TabIndex = 4;
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(78, 82);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(212, 20);
            this.txtProf.TabIndex = 5;
            // 
            // txtDS
            // 
            this.txtDS.Location = new System.Drawing.Point(362, 29);
            this.txtDS.Name = "txtDS";
            this.txtDS.Size = new System.Drawing.Size(176, 20);
            this.txtDS.TabIndex = 6;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(362, 82);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(176, 20);
            this.txtHora.TabIndex = 7;
            // 
            // btnAtz
            // 
            this.btnAtz.Location = new System.Drawing.Point(10, 114);
            this.btnAtz.Name = "btnAtz";
            this.btnAtz.Size = new System.Drawing.Size(264, 23);
            this.btnAtz.TabIndex = 8;
            this.btnAtz.Text = "Atualizar";
            this.btnAtz.UseVisualStyleBackColor = true;
            // 
            // btnAtv
            // 
            this.btnAtv.Location = new System.Drawing.Point(298, 114);
            this.btnAtv.Name = "btnAtv";
            this.btnAtv.Size = new System.Drawing.Size(240, 23);
            this.btnAtv.TabIndex = 9;
            this.btnAtv.Text = "Tornar ativo";
            this.btnAtv.UseVisualStyleBackColor = true;
            this.btnAtv.Click += new System.EventHandler(this.btnAtv_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // modalidade
            // 
            this.modalidade.HeaderText = "Modalidade";
            this.modalidade.Name = "modalidade";
            // 
            // prof
            // 
            this.prof.HeaderText = "Prof";
            this.prof.Name = "prof";
            // 
            // dia_semana
            // 
            this.dia_semana.HeaderText = "Dia da semana";
            this.dia_semana.Name = "dia_semana";
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            // 
            // nMaxAl
            // 
            this.nMaxAl.HeaderText = "Nº máx. de alunos";
            this.nMaxAl.Name = "nMaxAl";
            // 
            // FrmConAtuTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 389);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTurma);
            this.Name = "FrmConAtuTurma";
            this.Text = "Consultar Turma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtDS;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.Button btnAtv;
        private System.Windows.Forms.Button btnAtz;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMaxAl;
    }
}