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

            this.Text = "Lista de Interessados - " + clientesInteressados.Count + " interessados";
        }

        private void frmListagemInteressados_Load(object sender, EventArgs e)
        {
            dataGridInteresse.Rows.Clear();
            var dadosFormatados = clientesInteressados.Select(i => new
            {
                NomeUsuario = i.Usuario.Nome,
                EmailUsuario = i.Usuario.Email,
                i.Telefone,
                ModeloMoto = i.Moto.Modelo,
                MarcaMoto = i.Moto.Marca,
                i.Oferta,
                i.Observacoes
            }).ToList();
            dataGridInteresse.DataSource = dadosFormatados;
        }
    }
}
