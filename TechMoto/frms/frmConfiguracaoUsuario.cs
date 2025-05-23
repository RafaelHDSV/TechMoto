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
    public partial class frmConfiguracaoUsuario : Form
    {
        public frmConfiguracaoUsuario(Classes.Usuario usuarioLogado)
        {
            InitializeComponent();

            groupBoxConfiguracaoUsuario.Text = $"Configuração do Usuário: {usuarioLogado.Nome}";

            idInput.Text = usuarioLogado._id.ToString();
            nameInput.Text = usuarioLogado.Nome;
            cpfInput.Text = usuarioLogado.CPF;
            emailInput.Text = usuarioLogado.Email;
            senhaInput.Text = usuarioLogado.Senha;
            cidadeInput.Text = usuarioLogado.Cidade;
            bairroInput.Text = usuarioLogado.Bairro;
            ruaInput.Text = usuarioLogado.Rua;
            nivelInput.Text = usuarioLogado.Nivel.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Classes.Usuario novoUsuario = new Classes.Usuario()
            {
                Nome = nameInput.Text,
                CPF = cpfInput.Text,
                Email = emailInput.Text,
                Senha = senhaInput.Text,
                Cidade = cidadeInput.Text,
                Bairro = bairroInput.Text,
                Rua = ruaInput.Text,
            };

            Classes.GerenciamentoDeMotos.EditarUsuario(
                Guid.Parse(idInput.Text),
                novoUsuario
            );
        }
    }
}
