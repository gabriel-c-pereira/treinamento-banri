# Exercícios de herança e composição

## 1. Sistema de entregas

Crie um projeto **Console** com uma classe `App`, um método `Main` e todo o conjunto restante de elementos para um sistema simples para gerenciar **cálculos de fretes de pedidos**. A ideia é implementar, através de **heranças**, uma hierarquia de classes que permita tratar diferentes tipos de cálculos de fretes.

### Regras

- As entregas compartilham entre si alguns dados comuns, como:
  - Número do pedido;
  - Peso do item (Em kg).
- Os diferentes tipos de fretes aceitos são:
  - Entrega econômica: Frete custa **R\$ 5,00/kg**;
  - Entrega expressa: Frete custa **R\$ 7,00/kg** e tem uma taxa extra fixa de **R\$ 10,00** se regiões de origem e destino forem diferentes;
    - Regiões possíveis: Sul, Sudeste, Centro-Oeste, Nordeste e Norte;
  - Entrega internacional: Frete custa **R\$ 12,00/kg** e tem uma taxa extra fixa de **R\$ 40,00** se o país de origem ou destino for os _Estados Unidos_, ou de **R$ 20,00** se entre os demais países;
    - Países possíveis: Brasil, Colombia, Argentina, Uruguai e Estados Unidos;

## 2. Cadastros de funcionários

Crie um projeto **Console** com uma classe `App`, um método `Main` e todo o conjunto restante de elementos para um sistema simples para gerenciar **cadastros de funcionários**. A ideia é implementar, através de **composição**, uma relação de funcionários cadastrados e seus respectivos cargos e endereços.

### Regras

- Funcionários tem os seguintes dados:
  - Nome;
  - Idade;
  - Cargo, que por si só tem os seguintes dados:
    - Nome do cargo;
    - Carga horária (valores possíveis: 4 horas/dia ou 8 horas/dia).
  - Endereço, que por si só tem os seguintes dados:
    - Rua;
    - Numero;
    - Bairro;
    - Cidade, que por si só tem os seguintes dados:
      - Nome da cidade;
      - Estado;
      - País;

> Nota: Cada funcionário possui apenas 1 cargo e 1 endereço (e cada endereço possui apenas 1 cidade).

Deve ser possível, ao final, se imprimir todos dados do funcionário na tela, como no exemplo abaixo:

```markdown
Funcionário: John Doe
Idade: 32
Cargo: Analista de Sistemas (8 horas/dia)
Endereço: Av. Paulista, 1578, Bairro Bela Vista - São Paulo/SP (Brasil)

Funcionário: Jane Doe
Idade: 28 anos
Cargo: Arquiteto de software (4 horas/dia)
Endereço: Rua das Flores, 245, Bairro Centro - Curitiba/PR (Brasil)

Funcionário: Mary Monroe
Idade: 45 anos
Cargo: Gerente de Projetos (8 horas/dia)
Endereço: Av. Goiás, 1001, Bairro Setor Central - Goiânia/GO (Brasil)
```
