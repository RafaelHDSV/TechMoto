using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TechMoto.Classes;

namespace TechMoto
{
    public partial class frmLogin : Form
    {
        public Usuario UsuarioLogado { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
            AdicionarDadosMockados();
        }

        private void AdicionarDadosMockados()
        {
            if (!GerenciamentoDeMotos.listaMotos.Any())
            {
                var motosMockadas = Constantes.CriarMotosMockadas();
                foreach (var moto in motosMockadas)
                {
                    GerenciamentoDeMotos.AdicionarMoto(moto, GerenciamentoDeMotos.TipoAdicionarMoto.Mocked);
                }
            }

            if (!GerenciamentoDeMotos.listaUsuarios.Any())
            {
                var usuariosMockados = Constantes.CriarUsuariosMockados();
                foreach (var usuario in usuariosMockados)
                {
                    GerenciamentoDeMotos.AdicionarUsuario(usuario);
                }
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var usuario = GerenciamentoDeMotos.listaUsuarios
                .FirstOrDefault(u => u.Email == inputEmail.Text && u.Senha == inputSenha.Text);

            if (usuario != null)
            {
                UsuarioLogado = usuario;
                MessageBox.Show($"Bem-vindo, {usuario.Nome}!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }
    }
}
