using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMoto.frms
{
    public partial class frmListagemInteressados: Form
    {
        private List<Classes.Interesse> clientesInteressados;

        public frmListagemInteressados(List<Classes.Interesse> clientesInteressados)
        {
            InitializeComponent();

            this.clientesInteressados = clientesInteressados;
        }

        private void frmListagemInteressados_Load(object sender, EventArgs e)
        {
            dataGridInteresse.Rows.Clear();
            dataGridInteresse.DataSource = clientesInteressados;
        }
    }
}
