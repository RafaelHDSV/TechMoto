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
        private Usuario usuarioLogado;
        private Timer resizeTimer = new Timer();

        public frmListagemMotos(Usuario usuarioLogado)
        {
            InitializeComponent();
            CarregarMotos();

            this.usuarioLogado = usuarioLogado;

            flowLayoutPanelMotos.WrapContents = true;
            flowLayoutPanelMotos.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelMotos.AutoScroll = true;

            resizeTimer.Interval = 300; // 300 ms de debounce
            resizeTimer.Tick += ResizeTimer_Tick;
        }

        public void CarregarMotos()
        {
            flowLayoutPanelMotos.Controls.Clear();

            List<Moto> listaMotos = GerenciamentoDeMotos.ListarTodasMotos();

            int larguraPainel = flowLayoutPanelMotos.ClientSize.Width;
            int larguraCard = 230;
            int cardsPorLinha = Math.Max(1, larguraPainel / larguraCard);
            int espacoRestante = larguraPainel - (cardsPorLinha * larguraCard);
            int margemHorizontal = espacoRestante / (cardsPorLinha + 1); 

            foreach (var moto in listaMotos)
            {
                MotoCard card = new MotoCard();
                card.SetMoto(moto);
                card.RenderizarFavoritos(usuarioLogado, moto);
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
