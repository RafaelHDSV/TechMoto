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

namespace TechMoto
{
    public partial class MotoCard : UserControl
    {
        public MotoCard()
        {
            InitializeComponent();
        }

        public void SetMoto(Classes.Moto moto)
        {
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

            string clientesInteressadosMessage = moto.ClientesInteressados.Count > 0 ? moto.ClientesInteressados.Count > 1 ? moto.ClientesInteressados.Count + " Interessados" : moto.ClientesInteressados.Count + " Interessado" : "Nenhum Interessado";
            labelClientesInteressados.Text = clientesInteressadosMessage;
        }
    }
}
