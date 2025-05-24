using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TechMoto.Classes;

namespace TechMoto
{
    public partial class frmListagemMotos : Form
    {
        private Timer resizeTimer = new Timer();

        public frmListagemMotos()
        {
            InitializeComponent();
            CarregarMotos();

            flowLayoutPanelMotos.WrapContents = true;
            flowLayoutPanelMotos.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelMotos.AutoScroll = true;

            resizeTimer.Interval = 300; // 300 ms de debounce
            resizeTimer.Tick += ResizeTimer_Tick;
        }

        private void CarregarMotos()
        {
            flowLayoutPanelMotos.Controls.Clear();

            List<Classes.Moto> listaMotos = Classes.GerenciamentoDeMotos.ListarTodasMotos();

            // Largura do painel
            int larguraPainel = flowLayoutPanelMotos.ClientSize.Width;

            // Largura fixa do card (pode ser ajustado)
            int larguraCard = 250;

            // Quantos cards cabem por linha
            int cardsPorLinha = Math.Max(1, larguraPainel / larguraCard);

            // Espaço restante que será distribuído como margem
            int espacoRestante = larguraPainel - (cardsPorLinha * larguraCard);

            // Espaço entre os cards (como margin horizontal)
            int margemHorizontal = espacoRestante / (cardsPorLinha + 1); // +1 para espaço à esquerda e direita

            foreach (var moto in listaMotos)
            {
                MotoCard card = new MotoCard();
                card.SetMoto(moto);
                card.Width = larguraCard;
                card.Margin = new Padding(margemHorizontal, 10, 0, 10);
                flowLayoutPanelMotos.Controls.Add(card);
            }
        }

        private void frmListagemMotos_Resize(object sender, EventArgs e)
        {
            resizeTimer.Stop();
            resizeTimer.Start();
        }

        private void ResizeTimer_Tick(object sender, EventArgs e)
        {
            resizeTimer.Stop();
            CarregarMotos();
        }

    }
}
