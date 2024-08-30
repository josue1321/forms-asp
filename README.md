# API Produto

Este projeto é uma aplicação ASP.NET Core voltada para a criação e gerenciamento de formulários. A aplicação permite que os usuários criem, visualizem, editem e excluam formulários através de uma interface web. Além disso, a aplicação integra a **API BuscaCEP** para facilitar a obtenção de endereços a partir do CEP informado nos formulários.

## Pré-requisitos

- **.NET** (versão 8)

## Como Rodar o Projeto

1. Navegue até o diretório do projeto:
   ```bash
   cd forms-asp/WebApplication1
   ```
2. Restaure as dependências:
   ```bash
   dotnet restore
   ```

3. Baixe o dotnet-ef:
    ```bash
   dotnet tool install --global dotnet-ef --version 8.*
   ```

4. Configue o appsettings.json:
    - mude o objeto `conexao` de acordo com suas necessidades (como a string de conexão ao banco de dados).

5. Crie uma nova migration:
   ```bash
   dotnet ef migrations add NomeDaMigration
   ```

6. Aplique a nova migration:
   ```bash
   dotnet ef database update
   ```

7. Inicie o servidor:
   ```bash
   dotnet run
   ```