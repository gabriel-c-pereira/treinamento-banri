# Exercícios de polimorfismo

## 1. Sistema de reservas de hospedagem

Crie um projeto **Console** com uma classe `App`, um método `Main` e todo o conjunto restante de elementos necessários para um sistema simples de **reservas de hospedagem**.  
O objetivo técnico é implementar a criação de **reservas** através de **overloading de construtores**, permitindo se criar reservas de diferentes formas — a depender das informações disponíveis no momento da criação.

### Contexto

O sistema deve permitir criar reservas de um hotel com base nas informações do cliente, do quarto e das datas de entrada e saída.
Entretanto, nem sempre todas as informações estão disponíveis no momento da reserva — por isso, será necessário implementar **múltiplos construtores** que representem essas situações.

### Regras

- A classe `Reserva` deve possuir as seguintes propriedades:
  - Nome do cliente;
  - Número do quarto;
  - Número de dias;
  - Valor da diária;
  - Valor total (calculado automaticamente: Número de dias x Valor da diária);
  - Status da reserva (com valores possíveis `PENDENTE` e `CONFIRMADA`).

- Deve haver um **polimorfismo de construção** que permita:
  - **Reserva completa:** Com nome do cliente, número do quarto, número de dias e o valor da diária. O status para essa reserva é `CONFIRMADA`;
  - **Reserva parcial:** Com nome do cliente, número do quarto e valor da diária (número de dias estipulado para o mínimo **2**). O status para essa reserva é `CONFIRMADA`;
  - **Reserva mínima:** Com apenas o número do quarto e o valor da diária (cliente **"A definir"** e número de dias estipulado para o mínimo **2**). O status para essa reserva é `PENDENTE`.
- Deve haver um método `ExibirResumo()`, que imprime os dados da reserva, conforme o formato abaixo:

```markdown
<!-- Ao criar o objeto -->
Reserva completa criada com sucesso!

<!-- Ao chamar o método ExibirResumo() -->
Cliente: John Doe
Quarto: 305
Número de dias: 5
Valor da diária: R$ 250,00
Valor total: R$ 1.250,00
Status: CONFIRMADA

<!-- Ao criar o objeto -->
Reserva mínima criada com sucesso!

<!-- Ao chamar o método ExibirResumo() -->
Cliente: A definir
Quarto: 102
Número de dias: 2
Valor da diária: R$ 180,00
Valor total: R$ 360,00
Status: PENDENTE
```
