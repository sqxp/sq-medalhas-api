# 🏅sq-medalhas-api
![](https://github.com/sqxp/sq-medalhas-api/workflows/build-dotnet-3-0-100/badge.svg)

### Api GraphQl de pessoas para uso em provas de seleção da Squadra.
* Quando a API sobe ela cria um playground que pode ser utilizado para testar as consultas
  * Path do playground na API: **/ui/playground**
* Obs: A Api expõe atualmente apenas um método de consulta que sana as necessidades da prova atual.

## Subir
### Pre-requisitos
1. Docker
2. Docker Compose

### Comandos
```sh
git clone https://github.com/sqxp/sq-medalhas-api.git
cd sq-medalhas-api
docker build -t sqxp/sq-medalhas-api .
docker-compose up -d
```

* Feito isto a aplicação sobe em localhost porta 8081, caso queira alterar a porta, alterar o docker-compose.yml.
* Para acessar o playground após a subida da API acesse: http://localhost:8081/ui/playground

## GraphQL Schemas
```graphql

```
## Documentação
### 1.xxx
  * xxx
```graphql
query{
}
```
