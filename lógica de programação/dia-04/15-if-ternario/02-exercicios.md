# Exercícios de estrutura condicional ternária `?:`

## 1. Conceito de nota

Neste exercício, você criará um programa que avalia o **conceito** de uma nota, com base no valor informado pelo usuário, **usando apenas o operador ternário (`?:`)**.

Crie um projeto do tipo **Console**, com uma classe `App` contendo o método `Main` (entre outros), implementando em C# uma rotina que:

- Solicita ao usuário que digite uma nota de **0 a 10**;
- Armazena o conceito correspondente à nota;
- A regras de associação de conceitos são as seguintes:

  | Faixa de nota | Conceito |
  |:-------------:|:--------:|
  | `>= 9`        | A        |
  | `>= 7`        | B        |
  | `>= 5`        | C        |
  | `< 5`         | D        |

- Imprima o conceito final no console.

> Restrição: nenhuma estrutura condicional tradicional pode ser usada, use somente **ternários**.

### Exemplo de execução esperada

```markdown
Digite sua nota (0 a 10): 8.5  
Conceito: B
```

## 2. Desconto por categoria

Você foi contratado por uma loja virtual para criar um programa que calcula o **desconto final** conforme a categoria do cliente.

Crie um projeto do tipo **Console**, com uma classe `App` contendo o método `Main` (entre outros), implementando em C# uma rotina que:

- Solicita ao usuário:
  - O **preço original** do produto;
  - A **categoria** do cliente (`Bronze`, `Prata`, `Ouro` ou `VIP`);
- Aplique o desconto conforme a categoria;
- A regras de desconto por categoria são as seguintes:

  | Categoria | % Desconto |
  |:---------:|:----------:|
  | `VIP`     | 35%        |
  | `Ouro`    | 25%        |
  | `Prata`   | 10%        |
  | `Bronze`  | 5%         |

- Imprima o preço final com desconto, o percentual de desconto e a categoria do cliente no console.

> Restrição: nenhuma estrutura condicional tradicional pode ser usada, use somente **ternários**.

### Exemplo de execução esperada

```markdown
Digite o preço do produto: 100
Digite a categoria do cliente (Bronze, Prata, Ouro ou VIP): Ouro  

Preço final com desconto: R$ 75,00
Desconto aplicado: 25%
Categoria do cliente: Ouro
```
