namespace Atividade_Final.Forms
{
    partial class Form_Votacao_Interativa
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
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btVotar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nome});
            this.dgvCandidatos.Location = new System.Drawing.Point(12, 51);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.RowHeadersWidth = 51;
            this.dgvCandidatos.RowTemplate.Height = 24;
            this.dgvCandidatos.Size = new System.Drawing.Size(394, 387);
            this.dgvCandidatos.TabIndex = 0;
            // 
            // numero
            // 
            this.numero.HeaderText = "NUMERO";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 125;
            // 
            // nome
            // 
            this.nome.HeaderText = "NOME";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "VOTAÇÂO INTERATIVA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "NUMERO";
            // 
            // btVotar
            // 
            this.btVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVotar.Location = new System.Drawing.Point(563, 233);
            this.btVotar.Name = "btVotar";
            this.btVotar.Size = new System.Drawing.Size(123, 49);
            this.btVotar.TabIndex = 3;
            this.btVotar.Text = "VOTAR";
            this.btVotar.UseVisualStyleBackColor = true;
            this.btVotar.Click += new System.EventHandler(this.btVotar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(550, 197);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(152, 30);
            this.txtNumero.TabIndex = 4;
            // 
            // Form_Votacao_Interativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btVotar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCandidatos);
            this.Name = "Form_Votacao_Interativa";
            this.Text = "Form_Votacao_Interativa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btVotar;
        private System.Windows.Forms.TextBox txtNumero;
    }
}