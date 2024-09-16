# CreditEvaluationAPI


## Integrantes do Grupo
- Razyel Ferrari rm551875
- Rayzor Anael rm551832
<<<<<<< HEAD
- Derick Ara�jo rm551007
- Kalel Schlichting rm550620

## Arquitetura
A API segue uma arquitetura *monol�tica* por ser mais adequada para o escopo deste projeto. Essa escolha simplifica a implementa��o e facilita a manuten��o.

## Design Patterns Utilizados
- *Singleton*: Usado para gerenciar configura��es.
- *Repository Pattern*: Implementado para gerenciar o acesso aos dados dos produtos.

## Instru��es para Rodar a API

1. Clone o reposit�rio:
   bash
   git clone https://github.com/seu_usuario/nome_do_repositorio.git

2. Navegue at� o diret�rio do projeto:
=======
- Derick Araújo rm551007
- Kalel Schlichting rm550620

## Arquitetura
A API segue uma arquitetura *monolítica* por ser mais adequada para o escopo deste projeto. Essa escolha simplifica a implementação e facilita a manutenção.

## Design Patterns Utilizados
- *Singleton*: Usado para gerenciar configurações.
- *Repository Pattern*: Implementado para gerenciar o acesso aos dados dos produtos.

## Instruções para Rodar a API

1. Clone o repositório:
   bash
   git clone https://github.com/seu_usuario/nome_do_repositorio.git

2. Navegue até o diretório do projeto:
>>>>>>> 347007908fc1ef03546822a425c3146653fcf52e

cd nome_do_projeto


3. Restaure os pacotes NuGet:

dotnet restore


<<<<<<< HEAD
4. Configure a string de conex�o no arquivo appsettings.json para o seu banco Oracle.


5. Execute a aplica��o:
=======
4. Configure a string de conexão no arquivo appsettings.json para o seu banco Oracle.


5. Execute a aplicação:
>>>>>>> 347007908fc1ef03546822a425c3146653fcf52e

dotnet run



<<<<<<< HEAD
A documenta��o da API est� dispon�vel atrav�s do Swagger em http://localhost:{porta}/swagger ap�s rodar a aplica��o.

#### 6. **Fazer o Commit e Push do README.md**
   - No Visual Studio, adicione o `README.md` ao reposit�rio (Team Explorer > Changes).
   - Fa�a o commit com a mensagem `Add README.md`.
   - Sincronize as mudan�as com o GitHub clicando em **Sync** e depois em **Push**.

### Alternativa: Usar VS Code para o Push

Se preferir usar o **VS Code**, voc� pode seguir os passos abaixo:
=======
A documentação da API está disponível através do Swagger em http://localhost:{porta}/swagger após rodar a aplicação.

#### 6. **Fazer o Commit e Push do README.md**
   - No Visual Studio, adicione o `README.md` ao repositório (Team Explorer > Changes).
   - Faça o commit com a mensagem `Add README.md`.
   - Sincronize as mudanças com o GitHub clicando em **Sync** e depois em **Push**.

### Alternativa: Usar VS Code para o Push

Se preferir usar o **VS Code**, você pode seguir os passos abaixo:
>>>>>>> 347007908fc1ef03546822a425c3146653fcf52e

1. Abra o terminal no **VS Code** e inicialize o Git no projeto:
   bash
   git init
   git add .
   git commit -m "Initial commit"

<<<<<<< HEAD
2. Adicione o reposit�rio remoto e fa�a o push:

git remote add origin https://github.com/seu_usuario/nome_do_repositorio.git
git push -u origin master
=======
2. Adicione o repositório remoto e faça o push:

git remote add origin https://github.com/seu_usuario/nome_do_repositorio.git
git push -u origin master
>>>>>>> 347007908fc1ef03546822a425c3146653fcf52e
