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
                    Modelo = "R15",
                    Marca = "Yamaha",
                    Ano = 2026,
                    KmsRodados = 0,
                    Cor = "Preta",
                    Cilindradas = 150,
                    Preco = 23300,
                    Imagem = "https://imgs.search.brave.com/RG56tr6U7PK3Senlsxx8c2Ck_r_17v9yWXXo0V0W-_A/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWdz/LnNlYXJjaC5icmF2/ZS5jb20vNUVkMkNZ/dmNsYWZuelJKMXFG/T0NZb1M2aTNGcWh1/dG5pVHNQTGpZUkZh/by9yczpmaXQ6NTAw/OjA6MDowL2c6Y2Uv/YUhSMGNITTZMeTl0/YkdacC9aMnh1ZFho/bVozUXVhUzV2L2NI/UnBiVzlzWlM1amIy/MHYvVWtwMllXRllk/eTEyWm1kWS9aVlJv/VkM5M09tRjFkRzh2/L2FEcGhkWFJ2TDNF/NllYVjAvYnk5b2RI/Undjem92TDJSMi9j/bTF2ZEc5emVXRnRZ/V2hoL0xtTnZiUzVp/Y2k5M2NDMWovYjI1/MFpXNTBMM1Z3Ykc5/aC9aSE12TWpBeU15/OHdOaTh5L01ESTFY/ek0yTUY5U01UVmYv/VFVsRVRrbEhTRlJm/UWt4Qi9RMHN0TVRr/eU55MDNOakI0L05U/Y3dMV010WkdWbVlY/VnMvZEM1d2JtYw",
                },
                new Classes.Moto
                {
                    Modelo = "Fazer FZ25",
                    Marca = "Yamaha",
                    Ano = 2025,
                    KmsRodados = 45500,
                    Cor = "Azul",
                    Cilindradas = 250,
                    Preco = 24990,
                    Imagem = "https://www.yamaha-motor.com.br/file/products/30124.BC5A00010B.condicao.desktop.jpg",
                },
                new Classes.Moto
                {
                    Modelo = "MT-03",
                    Marca = "Yamaha",
                    Ano = 2024,
                    KmsRodados = 3200,
                    Cor = "Branca",
                    Cilindradas = 321,
                    Preco = 28990,
                    Imagem = "https://www.yamaha-motor.com.br/file/products/30141.BRH100010B.condicao.desktop.jpg",
                },
                new Classes.Moto
                {
                    Modelo = "CB 500F",
                    Marca = "Honda",
                    Ano = 2023,
                    KmsRodados = 8000,
                    Cor = "Laranja",
                    Cilindradas = 500,
                    Preco = 33500,
                    Imagem = "https://mobilidade.estadao.com.br/wp-content/uploads/2020/12/HondaCB500F2.jpg",
                },
                new Classes.Moto
                {
                    Modelo = "XRE 300",
                    Marca = "Honda",
                    Ano = 2025,
                    KmsRodados = 0,
                    Cor = "Vemelho",
                    Cilindradas = 300,
                    Preco = 28450,
                    Imagem = "https://imgs.search.brave.com/uA5r_EdcAooVT97Fc9KV0RJPeEZjEuZciCTbVnENjQc/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWdz/LnNlYXJjaC5icmF2/ZS5jb20vbXdrVm5E/RGoxSGR3WXZFRFpB/QU8zTlIzZHBHZlpj/Wm1FVF9OelRfRW5l/Zy9yczpmaXQ6NTAw/OjA6MDowL2c6Y2Uv/YUhSMGNITTZMeTl0/YjNSdi9ibXhwYm1V/dVkyOXRMbUp5L0wz/TjBiM0poWjJVdloz/VnAvWkdWekwyaHZi/bVJoTDNoeS9aUzB6/TURBdWFuQm4",
                },
                new Classes.Moto
                {
                    Modelo = "Ninja 400",
                    Marca = "Kawasaki",
                    Ano = 2024,
                    KmsRodados = 1500,
                    Cor = "Azul",
                    Cilindradas = 399,
                    Preco = 34700,
                    Imagem = "https://content2.kawasaki.com/ContentStorage/CKM/Products/5290/bbd24ee5-b99a-4a93-b126-e92eb7e44f75.png",
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
                    Nome = "Rafael Vieira",
                    CPF = "538.972.328-71",
                    Email = "cliente@gmail.com",
                    Senha = "cliente",
                    Cidade = "Xique Xique",
                    Bairro = "Centro",
                    Rua = "Rua Exemplo, 123",
                    Nivel = Classes.UsuarioNivel.Cliente,
                    MotosComInteresse = 15
                },
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
