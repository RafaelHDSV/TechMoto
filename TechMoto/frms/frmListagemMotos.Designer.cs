namespace TechMoto
{
    partial class frmListagemMotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListagemMotos));
            this.flowLayoutPanelMotos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMotos
            // 
            this.flowLayoutPanelMotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMotos.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMotos.Name = "flowLayoutPanelMotos";
            this.flowLayoutPanelMotos.Size = new System.Drawing.Size(1092, 734);
            this.flowLayoutPanelMotos.TabIndex = 0;
            // 
            // frmListagemMotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 734);
            this.Controls.Add(this.flowLayoutPanelMotos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListagemMotos";
            this.Text = "TechMoto - Listagem de Motos";
            this.Resize += new System.EventHandler(this.frmListagemMotos_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMotos;
    }
}