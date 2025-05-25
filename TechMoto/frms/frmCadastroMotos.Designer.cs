namespace TechMoto
{
    partial class frmCadastroMotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroMotos));
            this.inputModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputImage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputPreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputCilindradas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.inputCor = new System.Windows.Forms.TextBox();
            this.inputQuilometragem = new System.Windows.Forms.TextBox();
            this.inputMarca = new System.Windows.Forms.TextBox();
            this.inputAno = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputModelo
            // 
            this.inputModelo.Location = new System.Drawing.Point(20, 73);
            this.inputModelo.Margin = new System.Windows.Forms.Padding(4);
            this.inputModelo.Name = "inputModelo";
            this.inputModelo.Size = new System.Drawing.Size(200, 22);
            this.inputModelo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.inputAno);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.inputImage);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.inputPreco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.inputCilindradas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.inputCor);
            this.groupBox1.Controls.Add(this.inputQuilometragem);
            this.groupBox1.Controls.Add(this.inputMarca);
            this.groupBox1.Controls.Add(this.inputModelo);
            this.groupBox1.Location = new System.Drawing.Point(268, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(16);
            this.groupBox1.Size = new System.Drawing.Size(500, 436);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Motos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 251);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Imagem (url)";
            // 
            // inputImage
            // 
            this.inputImage.Location = new System.Drawing.Point(280, 271);
            this.inputImage.Margin = new System.Windows.Forms.Padding(4);
            this.inputImage.Name = "inputImage";
            this.inputImage.Size = new System.Drawing.Size(200, 22);
            this.inputImage.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Preço";
            // 
            // inputPreco
            // 
            this.inputPreco.Location = new System.Drawing.Point(20, 271);
            this.inputPreco.Margin = new System.Windows.Forms.Padding(4);
            this.inputPreco.Name = "inputPreco";
            this.inputPreco.Size = new System.Drawing.Size(200, 22);
            this.inputPreco.TabIndex = 6;
            this.inputPreco.TextChanged += new System.EventHandler(this.inputPreco_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cilindradas";
            // 
            // inputCilindradas
            // 
            this.inputCilindradas.Location = new System.Drawing.Point(280, 205);
            this.inputCilindradas.Margin = new System.Windows.Forms.Padding(4);
            this.inputCilindradas.Name = "inputCilindradas";
            this.inputCilindradas.Size = new System.Drawing.Size(200, 22);
            this.inputCilindradas.TabIndex = 5;
            this.inputCilindradas.TextChanged += new System.EventHandler(this.inputCilindradas_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Quilometragem (km)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Modelo";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(172, 351);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(163, 34);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // inputCor
            // 
            this.inputCor.Location = new System.Drawing.Point(20, 205);
            this.inputCor.Margin = new System.Windows.Forms.Padding(4);
            this.inputCor.Name = "inputCor";
            this.inputCor.Size = new System.Drawing.Size(200, 22);
            this.inputCor.TabIndex = 4;
            // 
            // inputQuilometragem
            // 
            this.inputQuilometragem.Location = new System.Drawing.Point(280, 139);
            this.inputQuilometragem.Margin = new System.Windows.Forms.Padding(4);
            this.inputQuilometragem.Name = "inputQuilometragem";
            this.inputQuilometragem.Size = new System.Drawing.Size(200, 22);
            this.inputQuilometragem.TabIndex = 3;
            this.inputQuilometragem.TextChanged += new System.EventHandler(this.inputQuilometragem_TextChanged);
            // 
            // inputMarca
            // 
            this.inputMarca.Location = new System.Drawing.Point(280, 73);
            this.inputMarca.Margin = new System.Windows.Forms.Padding(4);
            this.inputMarca.Name = "inputMarca";
            this.inputMarca.Size = new System.Drawing.Size(200, 22);
            this.inputMarca.TabIndex = 1;
            // 
            // inputAno
            // 
            this.inputAno.Location = new System.Drawing.Point(20, 139);
            this.inputAno.Mask = "0000";
            this.inputAno.Name = "inputAno";
            this.inputAno.Size = new System.Drawing.Size(200, 22);
            this.inputAno.TabIndex = 2;
            // 
            // frmCadastroMotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroMotos";
            this.Text = "TechMoto - Cadastro de Motos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox inputCor;
        private System.Windows.Forms.TextBox inputQuilometragem;
        private System.Windows.Forms.TextBox inputMarca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputPreco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputCilindradas;
        private System.Windows.Forms.MaskedTextBox inputAno;
    }
}