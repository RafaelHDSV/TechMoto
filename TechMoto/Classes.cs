using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TechMoto.Classes;

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

            public Usuario()
            {
                _id = Guid.NewGuid();
            }

            public Usuario Clone()
            {
                var clone = (Usuario)this.MemberwiseClone();
                clone._id = this._id;
                return clone;
            }

            public override bool Equals(object obj)
            {
                var outro = obj as Usuario;
                if (outro == null) return false;

                return _id == outro._id &&
                       CPF == outro.CPF &&
                       Nome == outro.Nome &&
                       Email == outro.Email &&
                       Senha == outro.Senha &&
                       Cidade == outro.Cidade &&
                       Bairro == outro.Bairro &&
                       Rua == outro.Rua &&
                       Nivel == outro.Nivel;
            }

            public override int GetHashCode()
            {
                return _id.GetHashCode();
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
            public string Modelo { get; set; }
            public string Marca { get; set; }
            public int Ano { get; set; }
            public double KmsRodados { get; set; }
            public string Cor { get; set; }
            public int Cilindradas { get; set; }
            public double Preco { get; set; }
            public string Imagem { get; set; }
            public List<Usuario> ClientesInteressados { get; set; } = new List<Usuario>();

            public Moto()
            {
                _id = Guid.NewGuid();
            }

            public string ExibirInformacoes()
            {
                return $"Moto encontrada com sucesso:\n _id: {_id} \n Modelo: {Modelo} \n Marca: {Marca} \n Ano: {Ano} \n KmsRodados: {KmsRodados} \n Cor: {Cor} \n Cilindradas: {Cilindradas}";
            }
        }

        public class Interesse
        {
            public Guid _id { get; set; }
            public Usuario Usuario { get; set; }
            public Moto Moto { get; set; }
            public string Telefone { get; set; }
            public decimal Oferta { get; set; }
            public string Observacoes { get; set; }

            public Interesse()
            {
                _id = Guid.NewGuid();
            }
        }

        public static class GerenciamentoDeMotos
        {
            public static List<Usuario> listaUsuarios = new List<Usuario>();
            public static List<Moto> listaMotos = new List<Moto>();
            public static List<Interesse> listaInteresses = new List<Interesse>();

            public static void AdicionarUsuario(Usuario usuario)
            {
                listaUsuarios.Add(usuario);
            }

            public static void EditarUsuario(Guid id, Usuario novoUsuario)
            {
                var index = listaUsuarios.FindIndex(u => u._id == id);
                if (index != -1)
                {
                    var usuario = listaUsuarios[index];
                    var original = usuario.Clone();

                    if (!string.IsNullOrWhiteSpace(novoUsuario.CPF) && usuario.CPF != novoUsuario.CPF)
                        usuario.CPF = novoUsuario.CPF;

                    if (!string.IsNullOrWhiteSpace(novoUsuario.Nome) && usuario.Nome != novoUsuario.Nome)
                        usuario.Nome = novoUsuario.Nome;

                    if (!string.IsNullOrWhiteSpace(novoUsuario.Email) && usuario.Email != novoUsuario.Email)
                        usuario.Email = novoUsuario.Email;

                    if (!string.IsNullOrWhiteSpace(novoUsuario.Senha) && usuario.Senha != novoUsuario.Senha)
                        usuario.Senha = novoUsuario.Senha;

                    if (!string.IsNullOrWhiteSpace(novoUsuario.Cidade) && usuario.Cidade != novoUsuario.Cidade)
                        usuario.Cidade = novoUsuario.Cidade;

                    if (!string.IsNullOrWhiteSpace(novoUsuario.Bairro) && usuario.Bairro != novoUsuario.Bairro)
                        usuario.Bairro = novoUsuario.Bairro;

                    if (!string.IsNullOrWhiteSpace(novoUsuario.Rua) && usuario.Rua != novoUsuario.Rua)
                        usuario.Rua = novoUsuario.Rua;

                    if (!usuario.Equals(original))
                    {
                        listaUsuarios[index] = usuario;
                        MessageBox.Show("Usuário editado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum dado foi alterado!");
                    }
                }
            }

            public enum TipoAdicionarMoto
            {
                Mocked,
                Formulario
            }

            public static void AdicionarMoto(Moto moto, TipoAdicionarMoto tipo)
            {
                if (listaMotos.Any(m => m._id == moto._id))
                {
                    return;
                }

                listaMotos.Add(moto);
                if (tipo == TipoAdicionarMoto.Formulario) MessageBox.Show("Moto cadastrada com sucesso!");
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
                var motoExistente = listaMotos.FirstOrDefault(m => m._id == id);
                if (motoExistente != null)
                {
                    motoExistente.Modelo = novaMoto.Modelo;
                    motoExistente.Marca = novaMoto.Marca;
                    motoExistente.Ano = novaMoto.Ano;
                    motoExistente.KmsRodados = novaMoto.KmsRodados;
                    motoExistente.Cor = novaMoto.Cor;
                    motoExistente.Cilindradas = novaMoto.Cilindradas;
                    motoExistente.Preco = novaMoto.Preco;
                    motoExistente.Imagem = novaMoto.Imagem;
                }
            }

            public static void InformarInteresse(Interesse interesse)
            {
                if (interesse.Moto != null && !interesse.Moto.ClientesInteressados.Any(u => u._id == interesse.Usuario._id))
                {
                    interesse.Moto.ClientesInteressados.Add(interesse.Usuario);
                    listaInteresses.Add(interesse);
                    MessageBox.Show($"Interesse registrado para a moto: {interesse.Moto.Modelo}");
                }
                else
                {
                    MessageBox.Show("Usuário já está interessado nesta moto ou moto não encontrada.");
                }
            }

            public static List<Interesse> BuscarInteresse(Guid motoId)
            {
                var moto = listaMotos.FirstOrDefault(m => m._id == motoId);
                if (moto != null)
                {
                    var interessesDaMoto = listaInteresses.Where(i => i.Moto._id == motoId).ToList();
                    return interessesDaMoto;
                }
                else
                {
                    MessageBox.Show("Moto não encontrada.");
                    return new List<Interesse>();
                }
            }
        }
    }
}
