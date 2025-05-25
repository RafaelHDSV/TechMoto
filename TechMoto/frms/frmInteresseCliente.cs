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
        private Classes.Usuario usuarioLogado;

        public frmInteresseCliente(Classes.Usuario usuarioLogado, Classes.Moto moto)
        {
            InitializeComponent();

            this.usuarioLogado = usuarioLogado;

            inputNome.Text = usuarioLogado.Nome;

            inputMotos.DataSource = Classes.GerenciamentoDeMotos.listaMotos;
            inputMotos.DisplayMember = "Modelo";
            inputMotos.ValueMember = "_id";

            if (moto != null)
            {
                inputMotos.SelectedValue = moto._id;
            }

            inputOferta.TextChanged += inputOferta_TextChanged;
            inputOferta.Text = "R$ 0,00";
        }

        public void AtualizarMotoSelecionada(Classes.Moto moto)
        {
            if (moto != null)
            {
                inputMotos.SelectedValue = moto._id;
            }
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

        private void btnInteresse_Click(object sender, EventArgs e)
        {
            bool hasRemainingInfo =
                string.IsNullOrWhiteSpace(inputNome.Text) ||
                inputMotos.SelectedValue == null ||
                string.IsNullOrWhiteSpace(inputTelefone.Text) || inputTelefone.Text == "(  )      -" ||
                string.IsNullOrWhiteSpace(inputOferta.Text) || inputOferta.Text == "R$ 0,00";

            if (hasRemainingInfo)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            string nome = inputNome.Text;
            string moto = inputMotos.SelectedValue.ToString();
            string telefone = inputTelefone.Text;
            string oferta = inputOferta.Text.Replace("R$", "").Replace(".", "").Replace(",", "").Trim();
            string observacoes = inputObservacoes.Text;

            Classes.GerenciamentoDeMotos.InformarInteresse(moto, usuarioLogado);

            var formListagemAberta = Application.OpenForms.OfType<frmListagemMotos>().FirstOrDefault();
            formListagemAberta?.CarregarMotos();

            inputNome.Clear();
            inputTelefone.Clear();
            inputOferta.Clear();
            inputObservacoes.Clear();
            this.Close();
        }
    }
}
