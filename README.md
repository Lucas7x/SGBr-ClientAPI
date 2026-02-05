# SGBr-ClientAPI

Uma API robusta para gerenciamento de clientes desenvolvida em .NET 8, estruturada sob os princípios da **Clean Architecture** para garantir manutenibilidade e baixo acoplamento.

---

## Tecnologias Utilizadas

* **Framework:** .NET 8 (C#)
* **ORM:** Entity Framework Core (EF Core)
* **Banco de Dados:** SQLite
* **Documentação:** Swagger/OpenAPI
* **Arquitetura:** Clean Architecture (Domain, Application, Infrastructure, API)
* **Padrões de Projeto:** Repository Pattern, DTOs, Fluent API

---

## Decisões Técnicas

A solução foi projetada focando na separação de preocupações e na pureza do domínio:

* **Clean Architecture:** O projeto é dividido para que as regras de negócio (**Domain**) não conheçam detalhes de implementação como Banco de Dados ou Frameworks Web.
* **Isolamento do Domínio:** A restrição de **E-mail Único** foi configurada via **Fluent API** na camada de *Infrastructure*. Isso mantém as entidades do *Domain* como classes POCO (Plain Old CLR Objects), sem dependências do Entity Framework.
* **Tratamento de Erros Padronizado:** A API utiliza o padrão de retorno `ValidationProblemDetails` (RFC 7807). Isso unifica os erros de validação do `ModelState` e exceções de negócio (como `ArgumentException`) em um JSON estruturado com dicionários de mensagens.
* **Mapeamento com DTOs:** Foram utilizados Data Transfer Objects para garantir que as entidades do banco de dados não sejam expostas diretamente, permitindo uma evolução segura do contrato da API.

---

## Como rodar o projeto

### 1. Pré-requisitos
* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* Ferramenta de linha de comando do EF Core:
  `dotnet tool install --global dotnet-ef`

### 2. Configuração e Execução
1. **Clone o repositório:**
   `git clone https://github.com/Lucas7x/SGBr-ClientAPI.git`
   `cd SGBr-ClientAPI`

2. **Inicie a aplicação:**
   `dotnet run --project SGBr.API`

3. **Acesse a documentação:**
   A API estará disponível em `http://localhost:5143`. Teste os endpoints via Swagger em: `/swagger/index.html`.

---

## Autor
* **Lucas Xavier** - [GitHub](https://github.com/Lucas7x)

