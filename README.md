# 🏦 Cadastro de Pessoas (Física ou Jurídica) em C#

Este é um projeto de console em **C#** voltado para o cadastro e gestão de pessoas físicas e jurídicas. O sistema permite registrar nome e rendimento mensal, com diferenciação entre os tipos de pessoa.

## 📌 Funcionalidades

- ✅ Cadastro de **Pessoa Física** ou **Pessoa Jurídica**
- 📝 Registro de:
  - Nome
  - Tipo (Física ou Jurídica)
  - Rendimento Mensal
- 📊 Cálculo de impostos (simulado, se implementado)
- 🔍 Visualização dos dados cadastrados

## 🛠️ Tecnologias

- [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- .NET Core (Console Application)

## ▶️ Como executar

1. Clone o repositório:

```bash
git clone https://github.com/BarucoMarco2091/Cadastro-banco-c-.git

2. Navegue até a pasta do projeto:

```bash
cd Cadastro-banco-c-

3. Abra com sua IDE C# (Visual Studio ou VS Code com extensão C#)

4. Execute o projeto:

```bash
dotnet run

🧠 Estrutura do Projeto

Cadastro-banco-c-/
├── Program.cs               # Lógica principal e menu de opções
├── Pessoa.cs                # Classe base (se houver)
├── PessoaFisica.cs          # Dados e regras da pessoa física
├── PessoaJuridica.cs        # Dados e regras da pessoa jurídica
