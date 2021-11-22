# desafioAPI

Teste .NET

Criar uma projeto WebApi, sem autenticação;

Criar endpoints para um CRUD de usuário;
Seguindo os verbos HTTP: GET, POST, PUT e DELETE;
5 Endpoints: Adicionar, atualizar, remover, obter todos e obter por id;

Utilizar Entity Framework Core, para persistir e obter dados no banco;

Entidade de Usuário precisa ter nome, e-mail e número de telefone celular;

Seguir os 5 princípios do acrônimo SOLID;

 
## Pré-requisitos:
  - Visual Studio 2019;
  - SQL Server Express 2017 + SQL Server Management Studio;
  - .NET Core Framework 3.1;
  - Entity Framework Core;
  - Postman, para testar o REST API. 

## Orientações

Web API rodando com banco de dados em memória (Microsoft.EntityFrameworkCore.InMemory):

``` csharp
services.AddDbContext<CadastroCRUDContext>(options => options.UseInMemoryDatabase(databaseName: "CrudCadastroDatabase"));
```

Na próxima etapa, será implementada a opção de persistir e obter dados de um banco no SQL Server.

## Referências

- [Udemy: Entity Framework Core + ASP.NET Core Web API + SQL Server] (https://www.udemy.com/course/efcore-aspnetcore-webapi-sqlserver/learn/lecture/16213056#questions)
  [GitHub] (https://github.com/vsandrade/EFCoreCurso/blob/master/EFCore.WebAPI/Startup.cs)

- [André Baltieri: Criando uma API com ASP.NET Core 3 e EF Core 3 em menos de 15 minutos] (https://www.youtube.com/watch?v=but7jqjopKM&t=82s)

- [André Baltieri: Como fazer uma API (Fácil e moderna) com ASP.NET, EF Core e SQLite] (https://www.youtube.com/watch?v=QzCSN9wN4JA)
  [GitHub] (https://github.com/balta-io/api-aspnet-5-ef-core-sqlite/blob/main/Controllers/TodoController.cs)

- Pendente: [thedevlife - Web API Entity Framework CRUD Tutorial For Beginners Using ASP.NET EF Core] (https://www.youtube.com/watch?v=VtaBalFQcso&t=1095s)

- Pendente: [Sameer Saini - Asp.Net Core Web API - CRUD operations in REST API Tutorial using Entity Framework Core] (https://www.youtube.com/watch?v=r4LlIhyQ9GY)

- [CRUD Operation With .NET Core 3.1 And Entity Framework Core] (https://www.c-sharpcorner.com/article/build-crud-operation-with-net-core-3-1/)

- [DIO: O que é Postman?] (https://digitalinnovation.one/artigos/o-que-e-postman)

- [TREINAWEB: O que é ORM?] (https://www.treinaweb.com.br/blog/o-que-e-orm)

- [DEVMEDIA: ORM - Object Relational Mapper] (https://www.devmedia.com.br/orm-object-relational-mapper/19056)

- [Venturus: O que é SOLID?] (https://www.venturus.org.br/o-que-e-solid/)

- [RockContent: Entenda o que é Rest API e a importância dele para o site da sua empresa] (https://rockcontent.com/br/blog/rest-api/)













