namespace TechMoto
{
    partial class frmListagemMotosTabela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListagemMotosTabela));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempo_de_uso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quilometragem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Cor,
            this.Modelo,
            this.Ano,
            this.Tempo_de_uso,
            this.Quilometragem});
            this.dataGridView1.Location = new System.Drawing.Point(111, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(860, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.MinimumWidth = 6;
            this.Cor.Name = "Cor";
            this.Cor.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 125;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.MinimumWidth = 6;
            this.Ano.Name = "Ano";
            this.Ano.Width = 125;
            // 
            // Tempo_de_uso
            // 
            this.Tempo_de_uso.HeaderText = "Tempo_de_uso";
            this.Tempo_de_uso.MinimumWidth = 6;
            this.Tempo_de_uso.Name = "Tempo_de_uso";
            this.Tempo_de_uso.Width = 125;
            // 
            // Quilometragem
            // 
            this.Quilometragem.HeaderText = "Quilometragem";
            this.Quilometragem.MinimumWidth = 6;
            this.Quilometragem.Name = "Quilometragem";
            this.Quilometragem.Width = 125;
            // 
            // frmListagemMotosTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListagemMotosTabela";
            this.Text = "testes5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo_de_uso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quilometragem;
    }
}