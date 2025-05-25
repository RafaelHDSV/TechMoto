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
            var formAberto = Application.OpenForms.OfType<frmCadastroMotos>().FirstOrDefault();

            if (formAberto == null)
            {
                frmCadastroMotos frmCadastroMotos = new frmCadastroMotos();
                frmCadastroMotos.MdiParent = this;
                frmCadastroMotos.Show();
            }
            else
            {
                formAberto.BringToFront();
            }
        }

        private void formulárioDeInteresseDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAberto = Application.OpenForms.OfType<frmInteresseCliente>().FirstOrDefault();

            if (formAberto == null)
            {
                frmInteresseCliente frmInteresseCliente = new frmInteresseCliente(usuarioLogado, null);
                frmInteresseCliente.MdiParent = this;
                frmInteresseCliente.Show();
            } else
            {
                formAberto.BringToFront();
            }   
        }

        private void listagemDeMotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAberto = Application.OpenForms.OfType<frmListagemMotos>().FirstOrDefault();

            if (formAberto == null)
            {
                frmListagemMotos frm = new frmListagemMotos(usuarioLogado);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                formAberto.BringToFront();
            }
        }

        private void listagemDeMotosTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAberto = Application.OpenForms.OfType<frmListagemMotosTabela>().FirstOrDefault();

            if (formAberto == null)
            {
                frmListagemMotosTabela frmListagemMotosTabela = new frmListagemMotosTabela();
                frmListagemMotosTabela.MdiParent = this;
                frmListagemMotosTabela.Show();
            } else
            {
                formAberto.BringToFront();
            }
        }

        private void configuraçõesDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAberto = Application.OpenForms.OfType<frmConfiguracaoUsuario>().FirstOrDefault();

            if (formAberto == null)
            {
                frmConfiguracaoUsuario frmConfiguracaoUsuario = new frmConfiguracaoUsuario(usuarioLogado);
                frmConfiguracaoUsuario.MdiParent = this;
                frmConfiguracaoUsuario.Show();
            } else
            {
                formAberto.BringToFront();
            }
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (frmLogin loginForm = new frmLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Program.UsuarioTroca = loginForm.UsuarioLogado;
                }
            }

            this.Close();
        }
    }
}
