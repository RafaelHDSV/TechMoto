using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMoto
{
    internal static class Constantes
    {
        public static List<Classes.Moto> CriarMotosMockadas()
        {
            List<Classes.Moto> motos = new List<Classes.Moto>
            {
                new Classes.Moto
                {
                    Nome = "R15",
                    Cor = "Preta",
                    Modelo = "R",
                    Ano = 2026,
                    TempoUso = 0,
                    KmsRodados = 0
                },
                new Classes.Moto
                {
                    Nome = "Yamaha Fazer FZ250",
                    Cor = "Azul",
                    Modelo = "Fazer",
                    Ano = 2025,
                    TempoUso = 6,
                    KmsRodados = 45500
                }
            };
            return motos;
        }

        public static List<Classes.Usuario> CriarUsuariosMockados()
        {
            List<Classes.Usuario> usuarios = new List<Classes.Usuario>
            {
                new Classes.Cliente
                {
                    Nome = "Travis Scott",
                    CPF = "777.777.777-77",
                    Email = "travis@gmail.com",
                    Senha = "fein",
                    Cidade = "Xique Xique",
                    Bairro = "Centro",
                    Rua = "Rua Exemplo, 123",
                    Nivel = Classes.UsuarioNivel.Cliente,
                    MotosComInteresse = 5
                },
                new Classes.Loja
                {
                    Nome = "TRR",
                    CPF = "987.654.321-00",
                    Email = "trr@gmail.com",
                    Senha = "take",
                    Cidade = "Xique Xique",
                    Bairro = "Centro",
                    Rua = "Avenida das Motos, 100",
                    Nivel = Classes.UsuarioNivel.Loja,
                    MotosEmEstoque = 20
                }
            };
            return usuarios;
        }
    }
}
