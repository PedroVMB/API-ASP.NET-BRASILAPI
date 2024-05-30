
# Título do Projeto

Uma api que consome o servico do Brasil api, para retornar bancos e endereços.
 

## Documentação da API

#### Retorna todos os bancos

```http
  GET /api/v1/Banco/busca/todos
```

#### Retorna um banco
```http
  GET /api/v1/Banco/busca/{codigoBanco}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `codigoBanco`      | `string` | **Obrigatório**. O codigo do banco que você quer |


#### Retorna um cep

```http
  GET api/v1/Endereco/busca/{cep}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `cep`      | `string` | **Obrigatório**. O cep do item que você quer |


## Apêndice

Projeto baseado na referência. 


## Referência

 - [artigotech-integra-brasilapi](https://github.com/ivisconfessor/artigotech-integra-brasilapi)
 - [Brasil-API](https://brasilapi.com.br/)

## Autores

- [@PedroVMB]([https://www.github.com/octokatherine](https://github.com/PedroVMB))

