
namespace Banco
{
    partial class FormRelatorios
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
            this.listaResultados = new System.Windows.Forms.ListBox();
            this.botaoFiltraSaldo = new System.Windows.Forms.Button();
            this.botaoFiltraSaldo2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSaldoMaior = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMenorSaldo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultados
            // 
            this.listaResultados.FormattingEnabled = true;
            this.listaResultados.Location = new System.Drawing.Point(276, 23);
            this.listaResultados.Name = "listaResultados";
            this.listaResultados.Size = new System.Drawing.Size(183, 95);
            this.listaResultados.TabIndex = 0;
            // 
            // botaoFiltraSaldo
            // 
            this.botaoFiltraSaldo.Location = new System.Drawing.Point(407, 124);
            this.botaoFiltraSaldo.Name = "botaoFiltraSaldo";
            this.botaoFiltraSaldo.Size = new System.Drawing.Size(140, 23);
            this.botaoFiltraSaldo.TabIndex = 1;
            this.botaoFiltraSaldo.Text = "botão filtra saldo < 1000";
            this.botaoFiltraSaldo.UseVisualStyleBackColor = true;
            this.botaoFiltraSaldo.Click += new System.EventHandler(this.botaoFiltraSaldo_Click);
            // 
            // botaoFiltraSaldo2
            // 
            this.botaoFiltraSaldo2.Location = new System.Drawing.Point(244, 124);
            this.botaoFiltraSaldo2.Name = "botaoFiltraSaldo2";
            this.botaoFiltraSaldo2.Size = new System.Drawing.Size(125, 23);
            this.botaoFiltraSaldo2.TabIndex = 2;
            this.botaoFiltraSaldo2.Text = "filtra saldo > 5000";
            this.botaoFiltraSaldo2.UseVisualStyleBackColor = true;
            this.botaoFiltraSaldo2.Click += new System.EventHandler(this.botaoFiltraSaldo2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMenorSaldo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelSaldoTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelSaldoMaior);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(244, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaiorSaldo";
            // 
            // labelSaldoMaior
            // 
            this.labelSaldoMaior.AutoSize = true;
            this.labelSaldoMaior.Location = new System.Drawing.Point(174, 52);
            this.labelSaldoMaior.Name = "labelSaldoMaior";
            this.labelSaldoMaior.Size = new System.Drawing.Size(35, 13);
            this.labelSaldoMaior.TabIndex = 1;
            this.labelSaldoMaior.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SaldoTotal";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(173, 117);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(35, 13);
            this.labelSaldoTotal.TabIndex = 3;
            this.labelSaldoTotal.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MenorSaldo";
            // 
            // labelMenorSaldo
            // 
            this.labelMenorSaldo.AutoSize = true;
            this.labelMenorSaldo.Location = new System.Drawing.Point(175, 87);
            this.labelMenorSaldo.Name = "labelMenorSaldo";
            this.labelMenorSaldo.Size = new System.Drawing.Size(35, 13);
            this.labelMenorSaldo.TabIndex = 5;
            this.labelMenorSaldo.Text = "label4";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoFiltraSaldo2);
            this.Controls.Add(this.botaoFiltraSaldo);
            this.Controls.Add(this.listaResultados);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.Load += new System.EventHandler(this.FormRelatorios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultados;
        private System.Windows.Forms.Button botaoFiltraSaldo;
        private System.Windows.Forms.Button botaoFiltraSaldo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSaldoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSaldoMaior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMenorSaldo;
        private System.Windows.Forms.Label label2;
    }
}