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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListagemMotosTabela));
            this.dataGridMotos = new System.Windows.Forms.DataGridView();
            this.gerenciamentoDeMotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciamentoDeMotosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMotos
            // 
            this.dataGridMotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMotos.Location = new System.Drawing.Point(0, 0);
            this.dataGridMotos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridMotos.Name = "dataGridMotos";
            this.dataGridMotos.RowHeadersWidth = 51;
            this.dataGridMotos.Size = new System.Drawing.Size(1067, 554);
            this.dataGridMotos.TabIndex = 0;
            // 
            // gerenciamentoDeMotosBindingSource
            // 
            this.gerenciamentoDeMotosBindingSource.DataSource = typeof(TechMoto.Classes.GerenciamentoDeMotos);
            // 
            // frmListagemMotosTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridMotos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListagemMotosTabela";
            this.Text = "TechMoto - Listagem de Motos (Tabela)";
            this.Load += new System.EventHandler(this.frmListagemMotosTabela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciamentoDeMotosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMotos;
        private System.Windows.Forms.BindingSource gerenciamentoDeMotosBindingSource;
    }
}