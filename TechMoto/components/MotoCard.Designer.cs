namespace TechMoto
{
    partial class MotoCard
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotoCard));
            this.labelClientesInteressados = new System.Windows.Forms.Label();
            this.labelKm = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCores = new System.Windows.Forms.Label();
            this.labelCilindradas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientesInteressados
            // 
            this.labelClientesInteressados.AutoSize = true;
            this.labelClientesInteressados.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientesInteressados.Location = new System.Drawing.Point(21, 415);
            this.labelClientesInteressados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientesInteressados.Name = "labelClientesInteressados";
            this.labelClientesInteressados.Size = new System.Drawing.Size(153, 16);
            this.labelClientesInteressados.TabIndex = 7;
            this.labelClientesInteressados.Text = "Nenhum Interessado";
            this.labelClientesInteressados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKm.Location = new System.Drawing.Point(21, 380);
            this.labelKm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(83, 17);
            this.labelKm.TabIndex = 4;
            this.labelKm.Text = "45.500 km";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreco.Location = new System.Drawing.Point(13, 318);
            this.labelPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(200, 42);
            this.labelPreco.TabIndex = 6;
            this.labelPreco.Text = "R$ 24.990";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.Location = new System.Drawing.Point(235, 380);
            this.labelAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(44, 17);
            this.labelAno.TabIndex = 3;
            this.labelAno.Text = "2025";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(20, 276);
            this.labelModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(104, 20);
            this.labelModelo.TabIndex = 2;
            this.labelModelo.Text = "Fazer FZ25";
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.White;
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(20, 20);
            this.image.Margin = new System.Windows.Forms.Padding(4);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(260, 252);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(213, 279);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(66, 17);
            this.labelMarca.TabIndex = 8;
            this.labelMarca.Text = "Yamaha";
            this.labelMarca.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCores
            // 
            this.labelCores.AutoSize = true;
            this.labelCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCores.Location = new System.Drawing.Point(150, 380);
            this.labelCores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCores.Name = "labelCores";
            this.labelCores.Size = new System.Drawing.Size(39, 17);
            this.labelCores.TabIndex = 9;
            this.labelCores.Text = "Azul";
            // 
            // labelCilindradas
            // 
            this.labelCilindradas.AutoSize = true;
            this.labelCilindradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCilindradas.Location = new System.Drawing.Point(228, 415);
            this.labelCilindradas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCilindradas.Name = "labelCilindradas";
            this.labelCilindradas.Size = new System.Drawing.Size(51, 17);
            this.labelCilindradas.TabIndex = 10;
            this.labelCilindradas.Text = "250cc";
            // 
            // MotoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.labelCilindradas);
            this.Controls.Add(this.labelCores);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelClientesInteressados);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelKm);
            this.Controls.Add(this.image);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelAno);
            this.Name = "MotoCard";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(300, 447);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientesInteressados;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCores;
        private System.Windows.Forms.Label labelCilindradas;
    }
}
