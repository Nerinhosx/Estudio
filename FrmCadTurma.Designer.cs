
namespace Estudio
{
    partial class FrmCadTurma
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
            this.txtNumAl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.txtDS = new System.Windows.Forms.TextBox();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.btnCadTurma = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumAl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.txtDS);
            this.groupBox1.Controls.Add(this.txtProf);
            this.groupBox1.Controls.Add(this.txtMod);
            this.groupBox1.Controls.Add(this.btnCadTurma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // txtNumAl
            // 
            this.txtNumAl.Location = new System.Drawing.Point(110, 171);
            this.txtNumAl.Name = "txtNumAl";
            this.txtNumAl.Size = new System.Drawing.Size(233, 20);
            this.txtNumAl.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nº Máx. de Alunos:";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(110, 137);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 7;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // txtDS
            // 
            this.txtDS.Location = new System.Drawing.Point(110, 102);
            this.txtDS.Name = "txtDS";
            this.txtDS.Size = new System.Drawing.Size(233, 20);
            this.txtDS.TabIndex = 6;
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(110, 64);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(233, 20);
            this.txtProf.TabIndex = 5;
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(110, 28);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(233, 20);
            this.txtMod.TabIndex = 4;
            // 
            // btnCadTurma
            // 
            this.btnCadTurma.Location = new System.Drawing.Point(24, 208);
            this.btnCadTurma.Name = "btnCadTurma";
            this.btnCadTurma.Size = new System.Drawing.Size(319, 23);
            this.btnCadTurma.TabIndex = 3;
            this.btnCadTurma.Text = "Cadastrar";
            this.btnCadTurma.UseVisualStyleBackColor = true;
            this.btnCadTurma.Click += new System.EventHandler(this.btnCadTurma_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia da Semana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // dgvTurma
            // 
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modalidade});
            this.dgvTurma.Location = new System.Drawing.Point(14, 266);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.Size = new System.Drawing.Size(362, 178);
            this.dgvTurma.TabIndex = 1;
            this.dgvTurma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurma_CellContentClick);
            this.dgvTurma.SelectionChanged += new System.EventHandler(this.dgvTurma_SelectionChanged);
            // 
            // modalidade
            // 
            this.modalidade.HeaderText = "Modalidade";
            this.modalidade.Name = "modalidade";
            // 
            // FrmCadTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 457);
            this.Controls.Add(this.dgvTurma);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCadTurma";
            this.Text = "Cadastrar Turma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.TextBox txtDS;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.Button btnCadTurma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidade;
        private System.Windows.Forms.TextBox txtNumAl;
        private System.Windows.Forms.Label label5;
    }
}