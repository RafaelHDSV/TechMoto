# 🏍️ TechMoto

![C# language](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)
![Visual Studio 2022](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)
![GitHub language count](https://img.shields.io/github/languages/count/RafaelHDSV/TechMoto?style=for-the-badge)
![GitHub repo size](https://img.shields.io/github/repo-size/RafaelHDSV/TechMoto?style=for-the-badge)

<p align="center">
  <img src="https://github.com/user-attachments/assets/dd44ff70-77dc-45f8-bd9e-1a24cf322ec6" alt="Tela Principal do Sistema" width="600">
</p>

<p align="center">
    <a href="#about">📌 Sobre</a> • 
    <a href="#features">✨ Funcionalidades</a> • 
    <a href="#started">🚀 Como Executar</a> • 
    <a href="#structure">🏗️ Estrutura do Projeto</a> • 
    <a href="#screenshots">📷 Screenshots</a>
</p>

<h2 id="about">📌 Sobre o Projeto</h2>

TechMoto é um sistema desktop desenvolvido em Windows Forms com C#, projetado para gerenciar o estoque de motos em lojas e permitir que clientes demonstrem interesse pelos veículos disponíveis. O objetivo principal é facilitar a compra e venda de motos em um ambiente similar a um marketplace.

⚠️ **Observação:** O sistema não utiliza banco de dados permanente - todas as informações são armazenadas apenas em memória e serão perdidas ao fechar a aplicação.

<h2 id="features">✨ Funcionalidades</h2>

- 🏪 **Loja**
  - Cadastro de novas motos com foto, modelo, marca, cilindrada, cor, preço e descrição
  - Listagem de motos com visualização por imagem e em tabela
  - Edição e exclusão de motos cadastradas.
  - Visualização de clientes interessados em cada moto.

- 👤 **Cliente**
  - Cadastro e atualização de dados pessoais (nome, CPF, e-mail, telefone)
  - Visualização do catálogo de motos disponíveis
  - Demonstração de interesse por uma moto específica (com mensagem personalizada, telefone e proposta)

<h2 id="started">🚀 Como Executar o Projeto</h2>

### Pré-requisitos
- Visual Studio 2022
- .NET Framework 4.7.2 ou superior

### Passo a Passo

1. Clone o repositório:
  ```bash
  git clone https://github.com/RafaelHDSV/TechMoto.git
  ```

2.  Acesse a pasta do projeto:
  ```bash
  cd Controle-de-Estoque-CSharp-IPOO
  ```

3.  Abra o arquivo .sln no Visual Studio 2022

4.  Compile e execute o projeto (F5)

<h2 id="structure">🏗️ Estrutura do Projeto</h2>

| Formulário | Descrição
|----------------------|-----------------------------------------------------
| frmMain | tela principal (MDI), que abre os outros formulários
| frmCadastroMotos | cadastro de motos no estoque
| frmListagemMotos | controle de estoque (adicionar/remover motos, visualizar interessados)
| frmListagemMotosTabela | controle de estoque em tabela
| frmLogin | tela de autenticação
| frmConfiguracaoUsuario | atualização de conta do usuário (loja ou cliente)
| frmInteresseCliente | formulário para clientes demonstrarem interesse em uma moto
| frmListagemInteressados | listagem de clientes interessados por moto

<h2 id="screenshots">📷 Screenshots</h2>

frmLogin
![image](https://github.com/user-attachments/assets/2a5be513-c0ea-4c45-8431-570299427437)

frmMain
![image](https://github.com/user-attachments/assets/74bf6234-8808-4493-93f4-f5466f77d21c)

frmInteresseCliente
![image](https://github.com/user-attachments/assets/1ed10be4-e749-473b-a264-178c447d1df4)

frmCadastroMotos
![image](https://github.com/user-attachments/assets/4f4211a6-fc46-4dde-aa61-2e5f4294e11c)

frmListagemMotos
![image](https://github.com/user-attachments/assets/ddd19c83-5ae2-472d-9608-c7cf80148802)
_nível cliente_

![image](https://github.com/user-attachments/assets/80876fe6-766b-453f-966e-b9645088aa1f)
_nível loja_

frmListagemMotosTabela
![image](https://github.com/user-attachments/assets/1fbea2f2-adf4-43a5-8d34-0985374b6718)

frmConfiguracaoUsuario
![image](https://github.com/user-attachments/assets/07891814-d52d-4beb-9d30-389c21d57038)

frmListagemInteressados
![image](https://github.com/user-attachments/assets/8b873269-afd4-4cfc-8f44-d79242b56bfb)

<p align="center"> Desenvolvido com ❤️ por <a href="https://github.com/RafaelHDSV">RafaelHDSV</a> </p>
