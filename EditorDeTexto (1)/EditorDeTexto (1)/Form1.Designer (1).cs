
namespace EditorDeTexto
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
            this.textoConteudo = new System.Windows.Forms.TextBox();
            this.botaoGrava = new System.Windows.Forms.Button();
            this.textoBusca = new System.Windows.Forms.TextBox();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.textoReplace = new System.Windows.Forms.TextBox();
            this.botaoReplace = new System.Windows.Forms.Button();
            this.botaoToUpper = new System.Windows.Forms.Button();
            this.botaoToLower = new System.Windows.Forms.Button();
            this.botaoPlural = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoConteudo
            // 
            this.textoConteudo.Location = new System.Drawing.Point(294, 8);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.Size = new System.Drawing.Size(379, 136);
            this.textoConteudo.TabIndex = 0;
            // 
            // botaoGrava
            // 
            this.botaoGrava.Location = new System.Drawing.Point(294, 155);
            this.botaoGrava.Name = "botaoGrava";
            this.botaoGrava.Size = new System.Drawing.Size(75, 23);
            this.botaoGrava.TabIndex = 1;
            this.botaoGrava.Text = "Gravar";
            this.botaoGrava.UseVisualStyleBackColor = true;
            this.botaoGrava.Click += new System.EventHandler(this.botaoGrava_Click);
            // 
            // textoBusca
            // 
            this.textoBusca.Location = new System.Drawing.Point(573, 238);
            this.textoBusca.Name = "textoBusca";
            this.textoBusca.Size = new System.Drawing.Size(100, 20);
            this.textoBusca.TabIndex = 2;
            this.textoBusca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(689, 239);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 3;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // textoReplace
            // 
            this.textoReplace.Location = new System.Drawing.Point(573, 210);
            this.textoReplace.Name = "textoReplace";
            this.textoReplace.Size = new System.Drawing.Size(100, 20);
            this.textoReplace.TabIndex = 4;
            // 
            // botaoReplace
            // 
            this.botaoReplace.Location = new System.Drawing.Point(689, 210);
            this.botaoReplace.Name = "botaoReplace";
            this.botaoReplace.Size = new System.Drawing.Size(75, 23);
            this.botaoReplace.TabIndex = 5;
            this.botaoReplace.Text = "Substituir";
            this.botaoReplace.UseVisualStyleBackColor = true;
            this.botaoReplace.Click += new System.EventHandler(this.botaoReplace_Click);
            // 
            // botaoToUpper
            // 
            this.botaoToUpper.Location = new System.Drawing.Point(418, 156);
            this.botaoToUpper.Name = "botaoToUpper";
            this.botaoToUpper.Size = new System.Drawing.Size(78, 20);
            this.botaoToUpper.TabIndex = 6;
            this.botaoToUpper.Text = "Maiúsculas";
            this.botaoToUpper.UseVisualStyleBackColor = true;
            this.botaoToUpper.Click += new System.EventHandler(this.botaoToUpper_Click);
            // 
            // botaoToLower
            // 
            this.botaoToLower.Location = new System.Drawing.Point(514, 156);
            this.botaoToLower.Name = "botaoToLower";
            this.botaoToLower.Size = new System.Drawing.Size(75, 23);
            this.botaoToLower.TabIndex = 7;
            this.botaoToLower.Text = "Minúsculas";
            this.botaoToLower.UseVisualStyleBackColor = true;
            this.botaoToLower.Click += new System.EventHandler(this.botaoToLower_Click);
            // 
            // botaoPlural
            // 
            this.botaoPlural.Location = new System.Drawing.Point(598, 156);
            this.botaoPlural.Name = "botaoPlural";
            this.botaoPlural.Size = new System.Drawing.Size(75, 23);
            this.botaoPlural.TabIndex = 8;
            this.botaoPlural.Text = "Plural";
            this.botaoPlural.UseVisualStyleBackColor = true;
            this.botaoPlural.Click += new System.EventHandler(this.botaoPlural_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoPlural);
            this.Controls.Add(this.botaoToLower);
            this.Controls.Add(this.botaoToUpper);
            this.Controls.Add(this.botaoReplace);
            this.Controls.Add(this.textoReplace);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.textoBusca);
            this.Controls.Add(this.botaoGrava);
            this.Controls.Add(this.textoConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.Button botaoGrava;
        private System.Windows.Forms.TextBox textoBusca;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.TextBox textoReplace;
        private System.Windows.Forms.Button botaoReplace;
        private System.Windows.Forms.Button botaoToUpper;
        private System.Windows.Forms.Button botaoToLower;
        private System.Windows.Forms.Button botaoPlural;
    }
}

