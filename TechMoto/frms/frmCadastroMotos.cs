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
    public partial class frmCadastroMotos : Form
    {
        public frmCadastroMotos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string modelo = inputModelo.Text;
            string marca = inputMarca.Text;
            string ano = inputAno.Text;
            string kmsRodados = inputQuilometragem.Text;
            string cor = inputCor.Text;
            string cilindradas = inputCilindradas.Text;
            string preco = inputPreco.Text;
            string imagem = inputImage.Text;

            bool hasRemainingInfo = string.IsNullOrWhiteSpace(modelo) || string.IsNullOrWhiteSpace(marca) ||
                string.IsNullOrWhiteSpace(ano) || string.IsNullOrWhiteSpace(kmsRodados) || string.IsNullOrWhiteSpace(cor) ||
                string.IsNullOrWhiteSpace(cilindradas) || string.IsNullOrWhiteSpace(preco) ||
                string.IsNullOrWhiteSpace(imagem);

            if (hasRemainingInfo)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            Classes.Moto moto = new Classes.Moto
            {
                Modelo = modelo,
                Marca = marca,
                Ano = int.Parse(ano),
                KmsRodados = int.Parse(kmsRodados),
                Cor = cor,
                Cilindradas = int.Parse(cilindradas),
                Preco = double.Parse(preco),
                Imagem = imagem
            };

            Classes.GerenciamentoDeMotos.AdicionarMoto(moto);
        }
    }
}
