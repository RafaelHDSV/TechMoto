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

            nameInput.Text = usuarioLogado.Nome;
            cpfInput.Text = usuarioLogado.CPF;
            emailInput.Text = usuarioLogado.Email;
            senhaInput.Text = usuarioLogado.Senha;
            cidadeInput.Text = usuarioLogado.Cidade;
            bairroInput.Text = usuarioLogado.Bairro;
            ruaInput.Text = usuarioLogado.Rua;
            nivelInput.Text = usuarioLogado.Nivel.ToString();
        }
    }
}
