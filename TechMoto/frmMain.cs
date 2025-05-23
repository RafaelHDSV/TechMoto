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

    public partial class frmMain : Form
    {
        private Classes.Usuario usuarioLogado;
        public frmMain(Classes.Usuario usuarioLogado)
        {
            InitializeComponent();
            this.usuarioLogado = usuarioLogado;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            listagemDeMotosToolStripMenuItem.Visible=true;
            listagemDeMotosTabelaToolStripMenuItem.Visible = true;
            configuraçõesDeUsuárioToolStripMenuItem.Visible=true;

            switch (usuarioLogado.Nivel)
            {
                case Classes.UsuarioNivel.Cliente:
                    cadastroDeMotosToolStripMenuItem.Visible = false;
                    formulárioDeInteresseDeClienteToolStripMenuItem.Visible = true;
                    break;
                case Classes.UsuarioNivel.Loja:
                    cadastroDeMotosToolStripMenuItem.Visible = true;
                    formulárioDeInteresseDeClienteToolStripMenuItem.Visible = false;
                    break;
                default:
                    cadastroDeMotosToolStripMenuItem.Visible = false;
                    formulárioDeInteresseDeClienteToolStripMenuItem.Visible = false;
                    break;
            }
        }

        private void cadastroDeMotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMotos frmCadastroMotos = new frmCadastroMotos();
            frmCadastroMotos.MdiParent = this;
            frmCadastroMotos.Show();
        }

        private void formulárioDeInteresseDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInteresseCliente frmInteresseCliente = new frmInteresseCliente();
            frmInteresseCliente.MdiParent = this;
            frmInteresseCliente.Show();
        }

        private void listagemDeMotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListagemMotos frmListagemMotos = new frmListagemMotos();
            frmListagemMotos.MdiParent = this;
            frmListagemMotos.Show();
        }

        private void listagemDeMotosTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListagemMotosTabela frmListagemMotosTabela = new frmListagemMotosTabela();
            frmListagemMotosTabela.MdiParent = this;
            frmListagemMotosTabela.Show();
        }

        private void configuraçõesDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracaoUsuario frmConfiguracaoUsuario = new frmConfiguracaoUsuario(usuarioLogado);
            frmConfiguracaoUsuario.MdiParent = this;
            frmConfiguracaoUsuario.Show();
        }
    }
}
