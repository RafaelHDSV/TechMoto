using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using TechMoto.frms;

namespace TechMoto
{
    public partial class MotoCard : UserControl
    {
        private Classes.Usuario usuarioLogado;
        private Classes.Moto moto;
        private List<Classes.Interesse> interesse;

        public MotoCard()
        {
            InitializeComponent();
        }

        public void SetMoto(Classes.Moto moto)
        {
            this.moto = moto;

            try
            {
                using (var client = new WebClient())
                {
                    var stream = client.OpenRead(moto.Imagem);
                    image.Image = Image.FromStream(stream);
                }
            }
            catch
            {
                image.Image = Image.FromStream(new WebClient().OpenRead("https://imgs.search.brave.com/VOnq_c1-tNc42ruMDUJXyx5fWx8CB4VvZ7iolJTiWJc/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWdz/LnNlYXJjaC5icmF2/ZS5jb20vZzU3MndN/aWU2R21WU3FvVWhV/bG1TLVlsT2daZm85/N1EyN2ZjNTJpcVYz/MC9yczpmaXQ6NTAw/OjA6MDowL2c6Y2Uv/YUhSMGNITTZMeTkw/TXk1bS9kR05rYmk1/dVpYUXZhbkJuL0x6/RXhMemN3THpReEx6/QTIvTHpNMk1GOUdY/ekV4TnpBMC9NVEEy/TWpSZlpWTlVZMm8z/L2RrbzNPRVJET1hO/YVowWm4vUWxKS1Yx/TTNWek40Y21Fdy9R/WGd1YW5Cbg"));
            }

            image.ImageLocation = moto.Imagem;
            labelModelo.Text = moto.Modelo;
            labelMarca.Text = moto.Marca;
            labelAno.Text = moto.Ano.ToString();
            labelKm.Text = moto.KmsRodados.ToString("N0", new System.Globalization.CultureInfo("pt-BR")) + " kms";
            labelCores.Text = moto.Cor;
            labelCilindradas.Text = moto.Cilindradas.ToString() + "cc";
            labelPreco.Text = moto.Preco.ToString("C", new System.Globalization.CultureInfo("pt-BR"));

            this.interesse = Classes.GerenciamentoDeMotos.BuscarInteresse(moto._id);

            string clientesInteressadosMessage = interesse.Count > 0 ? interesse.Count > 1 ? interesse.Count + " Interessados" : interesse.Count + " Interessado" : "Nenhum Interessado";
            labelClientesInteressados.Text = clientesInteressadosMessage;
        }

        public void RenderizarPorCliente(Classes.Usuario usuarioLogado, Classes.Moto moto)
        {
            if (usuarioLogado == null)
            {
                editIcon.Visible = false;
                trashIcon.Visible = false;
                heartIcon.Visible = false;
                labelClientesInteressados.Visible = false;
                return;
            }

            this.usuarioLogado = usuarioLogado;

            switch (usuarioLogado.Nivel)
            {

                case Classes.UsuarioNivel.Cliente:
                    editIcon.Visible = false;
                    trashIcon.Visible = false;
                    heartIcon.Visible = true;
                    labelClientesInteressados.Visible = false;

                    try
                    {
                        string basePath = AppDomain.CurrentDomain.BaseDirectory;
                        string heartIconImage = Path.Combine(basePath, "assets",
                            moto.ClientesInteressados.Contains(usuarioLogado) ? "heart-fill.png" : "heart.png");
                        heartIcon.Image = Image.FromFile(heartIconImage); 
                    }
                    catch
                    {
                        heartIcon.Image = Image.FromStream(new WebClient().OpenRead("https://imgs.search.brave.com/VOnq_c1..."));
                    }

                    break;
                case Classes.UsuarioNivel.Loja:
                    editIcon.Visible = true;
                    trashIcon.Visible = true;
                    heartIcon.Visible = false;
                    labelClientesInteressados.Visible = true;
                    break;
                default:
                    editIcon.Visible = false;
                    trashIcon.Visible = false;
                    heartIcon.Visible = false;
                    labelClientesInteressados.Visible = false;
                    break;
            }
        }

        private void heartIcon_Click(object sender, EventArgs e)
        {
            var formAberto = Application.OpenForms.OfType<frmInteresseCliente>().FirstOrDefault();

            if (formAberto == null)
            {
                frmInteresseCliente frm = new frmInteresseCliente(usuarioLogado, moto);
                Form parentForm = this.FindForm();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Show(parentForm);
            }
            else
            {
                formAberto.AtualizarMotoSelecionada(moto);
                formAberto.BringToFront();
                formAberto.Activate();
            }
        }

        private void editIcon_Click(object sender, EventArgs e)
        {
            var formAberto = Application.OpenForms.OfType<frmCadastroMotos>().FirstOrDefault();

            if (formAberto == null)
            {
                frmCadastroMotos frmCadastroMotos = new frmCadastroMotos(moto);
                Form parentForm = this.FindForm();
                frmCadastroMotos.StartPosition = FormStartPosition.CenterParent;
                frmCadastroMotos.Show(parentForm);
            }
            else
            {
                formAberto.BringToFront();
                formAberto.Activate();
            }
        }

        private void trashIcon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Tem certeza que deseja excluir esta moto?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Classes.GerenciamentoDeMotos.RemoverMoto(moto._id);
                this.Parent.Controls.Remove(this);

                MessageBox.Show("Moto excluída com sucesso!");
            }
        }

        private void labelClientesInteressados_Click(object sender, EventArgs e)
        {
            var formAberto = Application.OpenForms.OfType<frmListagemInteressados>().FirstOrDefault();

            if (formAberto == null)
            {
                frmListagemInteressados frmListagemInteressados = new frmListagemInteressados(interesse);
                Form parentForm = this.FindForm();
                frmListagemInteressados.StartPosition = FormStartPosition.CenterParent;
                frmListagemInteressados.Show(parentForm);
            }
            else
            {
                formAberto.BringToFront();
                formAberto.Activate();
            }
        }
    }
}
