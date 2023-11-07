
namespace Estudio
{
    partial class FrmConAtuModalidade
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
            this.btnAtivar = new System.Windows.Forms.Button();
            this.btnAtualizar_Consultar = new System.Windows.Forms.Button();
            this.txtAu = new System.Windows.Forms.TextBox();
            this.txtAl = new System.Windows.Forms.TextBox();
            this.txtPrc = new System.Windows.Forms.TextBox();
            this.cbxDesc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtivar);
            this.groupBox1.Controls.Add(this.btnAtualizar_Consultar);
            this.groupBox1.Controls.Add(this.txtAu);
            this.groupBox1.Controls.Add(this.txtAl);
            this.groupBox1.Controls.Add(this.txtPrc);
            this.groupBox1.Controls.Add(this.cbxDesc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidades";
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(174, 141);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(148, 23);
            this.btnAtivar.TabIndex = 9;
            this.btnAtivar.Text = "Tornar ativo";
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // btnAtualizar_Consultar
            // 
            this.btnAtualizar_Consultar.Location = new System.Drawing.Point(9, 142);
            this.btnAtualizar_Consultar.Name = "btnAtualizar_Consultar";
            this.btnAtualizar_Consultar.Size = new System.Drawing.Size(158, 23);
            this.btnAtualizar_Consultar.TabIndex = 8;
            this.btnAtualizar_Consultar.Text = "Atualizar";
            this.btnAtualizar_Consultar.UseVisualStyleBackColor = true;
            this.btnAtualizar_Consultar.Click += new System.EventHandler(this.btnAtualizar_Consultar_Click);
            // 
            // txtAu
            // 
            this.txtAu.Location = new System.Drawing.Point(93, 110);
            this.txtAu.Name = "txtAu";
            this.txtAu.Size = new System.Drawing.Size(229, 20);
            this.txtAu.TabIndex = 7;
            // 
            // txtAl
            // 
            this.txtAl.Location = new System.Drawing.Point(98, 79);
            this.txtAl.Name = "txtAl";
            this.txtAl.Size = new System.Drawing.Size(224, 20);
            this.txtAl.TabIndex = 6;
            // 
            // txtPrc
            // 
            this.txtPrc.Location = new System.Drawing.Point(50, 51);
            this.txtPrc.Name = "txtPrc";
            this.txtPrc.Size = new System.Drawing.Size(272, 20);
            this.txtPrc.TabIndex = 5;
            // 
            // cbxDesc
            // 
            this.cbxDesc.FormattingEnabled = true;
            this.cbxDesc.Location = new System.Drawing.Point(70, 24);
            this.cbxDesc.Name = "cbxDesc";
            this.cbxDesc.Size = new System.Drawing.Size(252, 21);
            this.cbxDesc.TabIndex = 4;
            this.cbxDesc.SelectedIndexChanged += new System.EventHandler(this.cbxDesc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qtde. de Aulas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qtde. de Alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 201);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.Text = "Consultar Modalidades";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAu;
        private System.Windows.Forms.TextBox txtAl;
        private System.Windows.Forms.TextBox txtPrc;
        private System.Windows.Forms.ComboBox cbxDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Button btnAtualizar_Consultar;
    }
}