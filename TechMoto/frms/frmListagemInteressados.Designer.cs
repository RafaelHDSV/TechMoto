namespace TechMoto.frms
{
    partial class frmListagemInteressados
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
            this.dataGridInteresse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInteresse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridInteresse
            // 
            this.dataGridInteresse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInteresse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridInteresse.Location = new System.Drawing.Point(0, 0);
            this.dataGridInteresse.Name = "dataGridInteresse";
            this.dataGridInteresse.RowHeadersWidth = 51;
            this.dataGridInteresse.RowTemplate.Height = 24;
            this.dataGridInteresse.Size = new System.Drawing.Size(800, 450);
            this.dataGridInteresse.TabIndex = 0;
            // 
            // frmListagemInteressados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridInteresse);
            this.Name = "frmListagemInteressados";
            this.Text = "Listagem de Interesse";
            this.Load += new System.EventHandler(this.frmListagemInteressados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInteresse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridInteresse;
    }
}