using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace TechMoto
{
    public partial class frmCadastroMotos : Form
    {
        public frmCadastroMotos()
        {
            InitializeComponent();

            inputQuilometragem.TextChanged += inputQuilometragem_TextChanged;
            inputCilindradas.TextChanged += inputCilindradas_TextChanged;
            inputPreco.TextChanged += inputPreco_TextChanged;
            inputPreco.Text = "R$ 0,00";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string modelo = inputModelo.Text;
            string marca = inputMarca.Text;
            string ano = inputAno.Text;
            string kmsRodadosTexto = inputQuilometragem.Text.Replace(" km", "").Replace(".", "").Trim();
            string cor = inputCor.Text;
            string cilindradasTexto = inputCilindradas.Text.Replace("cc", "").Trim();
            string precoTexto = inputPreco.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim();
            string imagem = inputImage.Text;

            bool hasRemainingInfo = string.IsNullOrWhiteSpace(modelo) || string.IsNullOrWhiteSpace(marca) ||
                string.IsNullOrWhiteSpace(ano) || string.IsNullOrWhiteSpace(kmsRodadosTexto) || string.IsNullOrWhiteSpace(cor) ||
                string.IsNullOrWhiteSpace(cilindradasTexto) || string.IsNullOrWhiteSpace(precoTexto) ||
                string.IsNullOrWhiteSpace(imagem);

            if (hasRemainingInfo)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                Classes.Moto moto = new Classes.Moto
                {
                    Modelo = modelo,
                    Marca = marca,
                    Ano = int.Parse(ano),
                    KmsRodados = int.Parse(kmsRodadosTexto),
                    Cor = cor,
                    Cilindradas = int.Parse(cilindradasTexto),
                    Preco = double.Parse(precoTexto, System.Globalization.CultureInfo.InvariantCulture),
                    Imagem = imagem
                };

                Classes.GerenciamentoDeMotos.AdicionarMoto(moto, Classes.GerenciamentoDeMotos.TipoAdicionarMoto.Formulario);

                inputModelo.Clear();
                inputMarca.Clear();
                inputAno.Clear();
                inputQuilometragem.Clear();
                inputCor.Clear();
                inputCilindradas.Clear();
                inputPreco.Clear();
                inputImage.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar moto: " + ex.Message);
            }
        }

        private void inputPreco_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputPreco.Text))
                return;

            string texto = inputPreco.Text.Replace("R$", "").Replace(".", "").Replace(",", "").Trim();

            if (decimal.TryParse(texto, out decimal valor))
            {
                valor /= 100;
                inputPreco.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:N2}", valor);
                inputPreco.SelectionStart = inputPreco.Text.Length;
            }
            else
            {
                inputPreco.Text = "R$ 0,00";
                inputPreco.SelectionStart = inputPreco.Text.Length;
            }
        }

        private void inputCilindradas_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputCilindradas.Text)) return;

            string texto = inputCilindradas.Text.Replace("cc", "").Trim();
            string numeros = new string(texto.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(numeros))
            {
                inputCilindradas.Text = "";
                return;
            }

            inputCilindradas.Text = numeros + "cc";
            inputCilindradas.SelectionStart = inputCilindradas.Text.Length - 2;
        }

        private void inputQuilometragem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputQuilometragem.Text)) return;

            string texto = inputQuilometragem.Text.Replace(" km", "").Trim();
            string numeros = new string(texto.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(numeros))
            {
                inputQuilometragem.Text = "";
                return;
            }

            if (long.TryParse(numeros, out long valor))
            {
                string formatado = valor.ToString("N0", new System.Globalization.CultureInfo("pt-BR")) + " km";
                inputQuilometragem.Text = formatado;
                inputQuilometragem.SelectionStart = formatado.Length - 3;
            }
        }
    }
}
