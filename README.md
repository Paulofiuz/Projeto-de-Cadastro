

# Projeto de Cadastro

Este projeto é um exemplo de aplicação para gerenciamento de usuários e endereços, utilizando o Entity Framework Core para acesso e manipulação de dados.

## Estrutura do Projeto

### Diretórios Principais

- `Cadastro.Data`: Contém a configuração do banco de dados e as classes de mapeamento.
- `Cadastro.Models`: Contém as classes de modelo `User` e `Address`.

### Principais Arquivos

- **AppDbContext.cs:** Classe de contexto do Entity Framework Core que gerencia as entidades `User` e `Address`.
- **AddressMap.cs:** Configuração de mapeamento para a entidade `Address`.
- **UserMap.cs:** Configuração de mapeamento para a entidade `User`.

## Entidades

### User

A entidade `User` representa um usuário no sistema. Esta classe contém as propriedades essenciais para identificar e descrever um usuário, incluindo seu ID, nome, data e destino, além de uma referência ao endereço do usuário.

### Address

A entidade `Address` representa um endereço no sistema. Esta classe contém as propriedades necessárias para descrever um endereço, incluindo ID, rua, cidade, estado, código postal e país, bem como uma referência ao usuário correspondente.

## Mapeamento

### AddressMap

Configura o mapeamento da entidade `Address` para a tabela de banco de dados `Address`, incluindo suas chaves primárias e propriedades.

### UserMap

Configura o mapeamento da entidade `User` para a tabela de banco de dados `User`, especificando suas chaves primárias e propriedades, e definindo o relacionamento um-para-um com a entidade `Address`.

## Configuração do Projeto

O projeto utiliza o SDK .NET e inclui pacotes do Entity Framework Core necessários para a manipulação dos dados e interação com o banco de dados SQL Server.

