namespace TechMoto
{
    partial class frmInteresseCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInteresseCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputOferta = new System.Windows.Forms.TextBox();
            this.inputTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInteresse = new System.Windows.Forms.Button();
            this.inputObservacoes = new System.Windows.Forms.TextBox();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputMotos = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.inputMotos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputOferta);
            this.groupBox1.Controls.Add(this.inputTelefone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInteresse);
            this.groupBox1.Controls.Add(this.inputObservacoes);
            this.groupBox1.Controls.Add(this.inputNome);
            this.groupBox1.Location = new System.Drawing.Point(264, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(16);
            this.groupBox1.Size = new System.Drawing.Size(527, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de Interesse";
            // 
            // inputOferta
            // 
            this.inputOferta.Location = new System.Drawing.Point(298, 130);
            this.inputOferta.Margin = new System.Windows.Forms.Padding(4);
            this.inputOferta.Name = "inputOferta";
            this.inputOferta.Size = new System.Drawing.Size(200, 22);
            this.inputOferta.TabIndex = 3;
            this.inputOferta.TextChanged += new System.EventHandler(this.inputOferta_TextChanged);
            // 
            // inputTelefone
            // 
            this.inputTelefone.Location = new System.Drawing.Point(22, 130);
            this.inputTelefone.Mask = "(00) 00000-0000";
            this.inputTelefone.Name = "inputTelefone";
            this.inputTelefone.Size = new System.Drawing.Size(200, 22);
            this.inputTelefone.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observações";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Oferta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // btnInteresse
            // 
            this.btnInteresse.Location = new System.Drawing.Point(172, 339);
            this.btnInteresse.Margin = new System.Windows.Forms.Padding(4);
            this.btnInteresse.Name = "btnInteresse";
            this.btnInteresse.Size = new System.Drawing.Size(196, 49);
            this.btnInteresse.TabIndex = 5;
            this.btnInteresse.Text = "Estou interessado";
            this.btnInteresse.UseVisualStyleBackColor = true;
            this.btnInteresse.Click += new System.EventHandler(this.btnInteresse_Click);
            // 
            // inputObservacoes
            // 
            this.inputObservacoes.Location = new System.Drawing.Point(22, 199);
            this.inputObservacoes.Margin = new System.Windows.Forms.Padding(4);
            this.inputObservacoes.Multiline = true;
            this.inputObservacoes.Name = "inputObservacoes";
            this.inputObservacoes.Size = new System.Drawing.Size(476, 110);
            this.inputObservacoes.TabIndex = 4;
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(22, 64);
            this.inputNome.Margin = new System.Windows.Forms.Padding(4);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(200, 22);
            this.inputNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Moto";
            // 
            // inputMotos
            // 
            this.inputMotos.FormattingEnabled = true;
            this.inputMotos.Location = new System.Drawing.Point(298, 64);
            this.inputMotos.Name = "inputMotos";
            this.inputMotos.Size = new System.Drawing.Size(200, 24);
            this.inputMotos.TabIndex = 13;
            // 
            // frmInteresseCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInteresseCliente";
            this.Text = "TechMoto - Formulário de Interesse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInteresse;
        private System.Windows.Forms.TextBox inputObservacoes;
        private System.Windows.Forms.MaskedTextBox inputTelefone;
        private System.Windows.Forms.TextBox inputOferta;
        private System.Windows.Forms.ComboBox inputMotos;
        private System.Windows.Forms.Label label2;
    }
}