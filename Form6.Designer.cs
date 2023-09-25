
namespace Estudio
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescCadMod = new System.Windows.Forms.TextBox();
            this.txtPrcCadMod = new System.Windows.Forms.TextBox();
            this.txtAlCadMod = new System.Windows.Forms.TextBox();
            this.txtAuCadMod = new System.Windows.Forms.TextBox();
            this.btnCadMod = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCadMod);
            this.groupBox1.Controls.Add(this.txtAuCadMod);
            this.groupBox1.Controls.Add(this.txtAlCadMod);
            this.groupBox1.Controls.Add(this.txtPrcCadMod);
            this.groupBox1.Controls.Add(this.txtDescCadMod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qtde. Alunos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qtde. Aulas:";
            // 
            // txtDescCadMod
            // 
            this.txtDescCadMod.Location = new System.Drawing.Point(83, 26);
            this.txtDescCadMod.Name = "txtDescCadMod";
            this.txtDescCadMod.Size = new System.Drawing.Size(277, 20);
            this.txtDescCadMod.TabIndex = 4;
            // 
            // txtPrcCadMod
            // 
            this.txtPrcCadMod.Location = new System.Drawing.Point(83, 59);
            this.txtPrcCadMod.Name = "txtPrcCadMod";
            this.txtPrcCadMod.Size = new System.Drawing.Size(277, 20);
            this.txtPrcCadMod.TabIndex = 5;
            // 
            // txtAlCadMod
            // 
            this.txtAlCadMod.Location = new System.Drawing.Point(83, 94);
            this.txtAlCadMod.Name = "txtAlCadMod";
            this.txtAlCadMod.Size = new System.Drawing.Size(277, 20);
            this.txtAlCadMod.TabIndex = 6;
            // 
            // txtAuCadMod
            // 
            this.txtAuCadMod.Location = new System.Drawing.Point(83, 126);
            this.txtAuCadMod.Name = "txtAuCadMod";
            this.txtAuCadMod.Size = new System.Drawing.Size(277, 20);
            this.txtAuCadMod.TabIndex = 7;
            // 
            // btnCadMod
            // 
            this.btnCadMod.Location = new System.Drawing.Point(9, 161);
            this.btnCadMod.Name = "btnCadMod";
            this.btnCadMod.Size = new System.Drawing.Size(351, 23);
            this.btnCadMod.TabIndex = 8;
            this.btnCadMod.Text = "Cadastrar";
            this.btnCadMod.UseVisualStyleBackColor = true;
            this.btnCadMod.Click += new System.EventHandler(this.btnCadMod_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 232);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Cadastro de Modalidades";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAuCadMod;
        private System.Windows.Forms.TextBox txtAlCadMod;
        private System.Windows.Forms.TextBox txtPrcCadMod;
        private System.Windows.Forms.TextBox txtDescCadMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadMod;
    }
}