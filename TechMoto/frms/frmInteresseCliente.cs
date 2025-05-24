using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMoto
{
    public partial class frmInteresseCliente : Form
    {
        public frmInteresseCliente()
        {
            InitializeComponent();

            inputOferta.TextChanged += inputOferta_TextChanged;
            inputOferta.Text = "R$ 0,00";
        }

        private void inputOferta_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputOferta.Text))
                return;

            string texto = inputOferta.Text.Replace("R$", "").Replace(".", "").Replace(",", "").Trim();

            if (decimal.TryParse(texto, out decimal valor))
            {
                valor /= 100; 
                inputOferta.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:N2}", valor);
                inputOferta.SelectionStart = inputOferta.Text.Length; 
            }
            else
            {
                inputOferta.Text = "R$ 0,00";
                inputOferta.SelectionStart = inputOferta.Text.Length;
            }
        }
    }
}
