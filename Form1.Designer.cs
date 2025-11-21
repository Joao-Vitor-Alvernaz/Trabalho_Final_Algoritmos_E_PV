namespace Atividade_Final
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
            this.btCadastrarCandidato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarCandidato
            // 
            this.btCadastrarCandidato.BackColor = System.Drawing.Color.PaleGreen;
            this.btCadastrarCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarCandidato.Location = new System.Drawing.Point(284, 74);
            this.btCadastrarCandidato.Name = "btCadastrarCandidato";
            this.btCadastrarCandidato.Size = new System.Drawing.Size(252, 55);
            this.btCadastrarCandidato.TabIndex = 0;
            this.btCadastrarCandidato.Text = "Cadastrar Candidato";
            this.btCadastrarCandidato.UseVisualStyleBackColor = false;
            this.btCadastrarCandidato.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCadastrarCandidato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarCandidato;
    }
}

