using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMoto
{
    public class Classes
    {
        public enum UsuarioNivel
        {
            Cliente,
            Loja
        }

        public class Usuario
        {
            public Guid _id;
            public string CPF { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Senha { get; set; }
            public string Cidade { get; set; }
            public string Bairro { get; set; }
            public string Rua { get; set; }
            public UsuarioNivel Nivel { get; set; }

            public Usuario() {
                _id = Guid.NewGuid();
            }

            public string ExibirInformacoes()
            {
                return $"Usuário encontrado com sucesso:\n _id {_id} \n CPF {CPF} \n Nome {Nome} \n Email {Email} \n Senha {Senha} \n Cidade {Cidade} \n Bairro {Bairro} \n Rua {Rua} \n Nivel {Nivel} ";
            }
        }

        public class Cliente : Usuario
        {
            public int MotosComInteresse { get; set; }
        }

        public class Loja : Usuario
        {
            public int MotosEmEstoque { get; set; }
        }

        public class Moto
        {
            public Guid _id { get; set; }
            public string Nome { get; set; }
            public string Cor { get; set; }
            public string Modelo { get; set; }
            public int Ano { get; set; }
            public double TempoUso { get; set; }
            public double KmsRodados { get; set; }

            public Moto() {
                _id = Guid.NewGuid();
            }

            public string ExibirInformacoes()
            {
                return $"Moto encontrada com sucesso:\n _id: {_id} \n Nome: {Nome} \n Cor: {Cor} \n Modelo: {Modelo} \n Ano: {Ano} \n TempoUso: {TempoUso} \n KmsRodados: {KmsRodados}";
            }
        }

        public static class GerenciamentoDeMotos
        {
            public static List<Usuario> listaUsuarios = new List<Usuario>();
            public static List<Moto> listaMotos = new List<Moto>();

            public static void AdicionarUsuario(Usuario usuario)
            {
                listaUsuarios.Add(usuario);
            }

            public static void EditarUsuario(Guid id, Usuario novoUsuario)
            {
                var index = listaUsuarios.FindIndex(u => u._id == id);
                if (index != -1)
                {
                    var usuarioAntigo = listaUsuarios[index];

                    usuarioAntigo._id = string.IsNullOrWhiteSpace(novoUsuario._id.ToString()) ? usuarioAntigo._id : novoUsuario._id;
                    usuarioAntigo.CPF = string.IsNullOrWhiteSpace(novoUsuario.CPF) ? usuarioAntigo.CPF : novoUsuario.CPF;
                    usuarioAntigo.Nome = string.IsNullOrWhiteSpace(novoUsuario.Nome) ? usuarioAntigo.Nome : novoUsuario.Nome;
                    usuarioAntigo.Email = string.IsNullOrWhiteSpace(novoUsuario.Email) ? usuarioAntigo.Email : novoUsuario.Email;
                    usuarioAntigo.Senha = string.IsNullOrWhiteSpace(novoUsuario.Senha) ? usuarioAntigo.Senha : novoUsuario.Senha;
                    usuarioAntigo.Cidade = string.IsNullOrWhiteSpace(novoUsuario.Cidade) ? usuarioAntigo.Cidade : novoUsuario.Cidade;
                    usuarioAntigo.Bairro = string.IsNullOrWhiteSpace(novoUsuario.Bairro) ? usuarioAntigo.Bairro : novoUsuario.Bairro;
                    usuarioAntigo.Rua = string.IsNullOrWhiteSpace(novoUsuario.Rua) ? usuarioAntigo.Rua : novoUsuario.Rua;
                    usuarioAntigo.Nivel = string.IsNullOrWhiteSpace(novoUsuario.Nivel.ToString()) ? usuarioAntigo.Nivel : novoUsuario.Nivel;

                    listaUsuarios[index] = usuarioAntigo;

                    MessageBox.Show("Usuário editado com sucesso!");
                }
            }

            public static void AdicionarMoto(Moto moto)
            {
                listaMotos.Add(moto);
            }

            public static void RemoverMoto(Guid id)
            {
                listaMotos.RemoveAll(m => m._id == id);
            }

            public static Moto BuscarMoto(Guid id)
            {
                return listaMotos.FirstOrDefault(m => m._id == id);
            }

            public static List<Moto> ListarTodasMotos()
            {
                return listaMotos;
            }

            public static void EditarMoto(Guid id, Moto novaMoto)
            {
                var index = listaMotos.FindIndex(m => m._id == id);
                if (index != -1)
                {
                    listaMotos[index] = novaMoto;
                }
            }
        }
    }
}
