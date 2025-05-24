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
        public frmListagemMotos()
        {
            InitializeComponent();
            CarregarMotos();
        }

        private void CarregarMotos()
        {
            List<Classes.Moto> listaMotos = Classes.GerenciamentoDeMotos.ListarTodasMotos();

            foreach (var moto in listaMotos)
            {
                MotoCard card = new MotoCard();
                card.SetMoto(moto);
                flowLayoutPanelMotos.Controls.Add(card);
            }
        }
    }
}
