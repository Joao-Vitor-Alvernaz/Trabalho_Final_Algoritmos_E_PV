namespace Atividade_Final.Forms
{
    partial class Form_Cadastrar_Candidato
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nome_Completo = new System.Windows.Forms.TextBox();
            this.txt_Partido = new System.Windows.Forms.TextBox();
            this.txt_Apelido = new System.Windows.Forms.TextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.dgv_Candidato = new System.Windows.Forms.DataGridView();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_Deletar = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Candidato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR CANDIDATO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME COMPLETO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELIDO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(620, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "PARTIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "NÚMERO";
            // 
            // txt_Nome_Completo
            // 
            this.txt_Nome_Completo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome_Completo.Location = new System.Drawing.Point(18, 96);
            this.txt_Nome_Completo.Name = "txt_Nome_Completo";
            this.txt_Nome_Completo.Size = new System.Drawing.Size(600, 27);
            this.txt_Nome_Completo.TabIndex = 5;
            // 
            // txt_Partido
            // 
            this.txt_Partido.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Partido.Location = new System.Drawing.Point(624, 96);
            this.txt_Partido.Name = "txt_Partido";
            this.txt_Partido.Size = new System.Drawing.Size(164, 27);
            this.txt_Partido.TabIndex = 6;
            // 
            // txt_Apelido
            // 
            this.txt_Apelido.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apelido.Location = new System.Drawing.Point(18, 148);
            this.txt_Apelido.Name = "txt_Apelido";
            this.txt_Apelido.Size = new System.Drawing.Size(383, 27);
            this.txt_Apelido.TabIndex = 7;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero.Location = new System.Drawing.Point(407, 148);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(381, 27);
            this.txt_Numero.TabIndex = 8;
            // 
            // dgv_Candidato
            // 
            this.dgv_Candidato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Candidato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nome_completo,
            this.apelido,
            this.partido});
            this.dgv_Candidato.Location = new System.Drawing.Point(18, 182);
            this.dgv_Candidato.Name = "dgv_Candidato";
            this.dgv_Candidato.RowHeadersWidth = 51;
            this.dgv_Candidato.RowTemplate.Height = 24;
            this.dgv_Candidato.Size = new System.Drawing.Size(770, 209);
            this.dgv_Candidato.TabIndex = 9;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_Salvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Salvar.Location = new System.Drawing.Point(680, 397);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(108, 41);
            this.bt_Salvar.TabIndex = 10;
            this.bt_Salvar.Text = "SALVAR";
            this.bt_Salvar.UseVisualStyleBackColor = false;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // bt_Deletar
            // 
            this.bt_Deletar.BackColor = System.Drawing.Color.Red;
            this.bt_Deletar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Deletar.Location = new System.Drawing.Point(566, 397);
            this.bt_Deletar.Name = "bt_Deletar";
            this.bt_Deletar.Size = new System.Drawing.Size(108, 41);
            this.bt_Deletar.TabIndex = 11;
            this.bt_Deletar.Text = "DELETAR";
            this.bt_Deletar.UseVisualStyleBackColor = false;
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Limpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Location = new System.Drawing.Point(452, 397);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(108, 41);
            this.bt_Limpar.TabIndex = 12;
            this.bt_Limpar.Text = "LIMPAR";
            this.bt_Limpar.UseVisualStyleBackColor = false;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // numero
            // 
            this.numero.HeaderText = "NUMERO";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 125;
            // 
            // nome_completo
            // 
            this.nome_completo.HeaderText = "NOME COMPLETO";
            this.nome_completo.MinimumWidth = 6;
            this.nome_completo.Name = "nome_completo";
            this.nome_completo.Width = 125;
            // 
            // apelido
            // 
            this.apelido.HeaderText = "APELIDO";
            this.apelido.MinimumWidth = 6;
            this.apelido.Name = "apelido";
            this.apelido.Width = 125;
            // 
            // partido
            // 
            this.partido.HeaderText = "PARTIDO";
            this.partido.MinimumWidth = 6;
            this.partido.Name = "partido";
            this.partido.Width = 125;
            // 
            // Form_Cadastrar_Candidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Deletar);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.dgv_Candidato);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.txt_Apelido);
            this.Controls.Add(this.txt_Partido);
            this.Controls.Add(this.txt_Nome_Completo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Cadastrar_Candidato";
            this.Text = "Form_Cadastrar_Candidato";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Candidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nome_Completo;
        private System.Windows.Forms.TextBox txt_Partido;
        private System.Windows.Forms.TextBox txt_Apelido;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.DataGridView dgv_Candidato;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_Deletar;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn partido;
    }
}