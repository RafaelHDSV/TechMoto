namespace TechMoto
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeMotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulárioDeInteresseDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemDeMotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemDeMotosTabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeMotosToolStripMenuItem,
            this.formulárioDeInteresseDeClienteToolStripMenuItem,
            this.listagemDeMotosToolStripMenuItem,
            this.listagemDeMotosTabelaToolStripMenuItem,
            this.configuraçõesDeUsuárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2047, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeMotosToolStripMenuItem
            // 
            this.cadastroDeMotosToolStripMenuItem.Name = "cadastroDeMotosToolStripMenuItem";
            this.cadastroDeMotosToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.cadastroDeMotosToolStripMenuItem.Text = "Cadastro de Motos";
            this.cadastroDeMotosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMotosToolStripMenuItem_Click);
            // 
            // formulárioDeInteresseDeClienteToolStripMenuItem
            // 
            this.formulárioDeInteresseDeClienteToolStripMenuItem.Name = "formulárioDeInteresseDeClienteToolStripMenuItem";
            this.formulárioDeInteresseDeClienteToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.formulárioDeInteresseDeClienteToolStripMenuItem.Text = "Formulário de Interesse de Cliente";
            this.formulárioDeInteresseDeClienteToolStripMenuItem.Click += new System.EventHandler(this.formulárioDeInteresseDeClienteToolStripMenuItem_Click);
            // 
            // listagemDeMotosToolStripMenuItem
            // 
            this.listagemDeMotosToolStripMenuItem.Name = "listagemDeMotosToolStripMenuItem";
            this.listagemDeMotosToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.listagemDeMotosToolStripMenuItem.Text = "Listagem de Motos";
            this.listagemDeMotosToolStripMenuItem.Click += new System.EventHandler(this.listagemDeMotosToolStripMenuItem_Click);
            // 
            // listagemDeMotosTabelaToolStripMenuItem
            // 
            this.listagemDeMotosTabelaToolStripMenuItem.Name = "listagemDeMotosTabelaToolStripMenuItem";
            this.listagemDeMotosTabelaToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.listagemDeMotosTabelaToolStripMenuItem.Text = "Listagem de Motos (Tabela)";
            this.listagemDeMotosTabelaToolStripMenuItem.Click += new System.EventHandler(this.listagemDeMotosTabelaToolStripMenuItem_Click);
            // 
            // configuraçõesDeUsuárioToolStripMenuItem
            // 
            this.configuraçõesDeUsuárioToolStripMenuItem.Name = "configuraçõesDeUsuárioToolStripMenuItem";
            this.configuraçõesDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.configuraçõesDeUsuárioToolStripMenuItem.Text = "Configurações de Usuário";
            this.configuraçõesDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesDeUsuárioToolStripMenuItem_Click);
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.Location = new System.Drawing.Point(1917, 44);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(118, 39);
            this.btnDeslogar.TabIndex = 3;
            this.btnDeslogar.Text = "Deslogar";
            this.btnDeslogar.UseVisualStyleBackColor = true;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2047, 554);
            this.Controls.Add(this.btnDeslogar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "TechMoto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulárioDeInteresseDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemDeMotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemDeMotosTabelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.Button btnDeslogar;
    }
}