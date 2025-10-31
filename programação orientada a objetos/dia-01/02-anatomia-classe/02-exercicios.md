# Exercícios de anatomia de uma classe C\#

## 1. Sistema de extrato bancário

Crie um projeto **Console** com uma classe `App`, um método `Main` e todo o conjunto restante de elementos necessários para representar **extratos bancários e suas movimentações**.  
A ideia é implementar uma **relação entre os objetos** `ExtratoBancario` e `Movimentacao`.

### Requisitos

- Cada `Movimentacao` deve conter:
  - Um identificador do dia (ex: int `1` ou string `Dia 1`, etc.);
  - Um valor (positivo para créditos ou negativo para débitos);
  - Uma descrição (ex: "Depósito", "Compra no mercado", "Pix recebido", etc.).
- Um `ExtratoBancario` deve conter:
  - CPF do titular;
  - Nome do titular;
  - Saldo inicial (com qualquer valor de sua escolha);
  - Lista de movimentações (`Movimentacao`);
  - Saldo final (calculado com base no saldo inicial e aplicadas as movimentações);
  - Um método público `ApurarSaldoFinal()`, responsável por calcular o valor do saldo final do extrato, com base no saldo inicial e a aplicação de todas as movimentações;
  - Um método público `ImprimirRelatorio()`, responsável por imprimir na tela o extrato bancário, em um formato semelhante a este:

   ```markdown
   Extrato bancário de: John Doe (CPF: 123.456.789-00)  
   
   Saldo inicial: R$ 1000,00  

   Dia 1: (+) R$ 200,00 (Depósito em conta)
   Dia 2: (-) R$ 20,00 (Padaria)
   Dia 3: (+) R$ 170,00 (Pix recebido)
   Dia 4: (-) R$ 20,00 (Pix enviado)
   Dia 5: (+) R$ 10,00 (Rendimentos conta)
   Dia 5: (+) R$ 10,00 (Rendimentos investimento)

   Saldo final: R$ 1350,00
   ```

### Regras

- Deve-se garantir que o saldo final já esteja calculado (`ApurarSaldoFinal()`) antes de a impressão (`ImprimirRelatorio()`) acontecer;
- Um extrato bancário deve conter **pelo menos 5 dias de movimentações**, sendo que em **um dos dias deve haver ao menos 2 movimentações**.

### Desafio Extra (não é obrigatório)

O que precisaria ser feito no sistema para que no método `ImprimirRelatorio()` também fosse possível mostrar o **saldo acumulado** após cada movimentação?

```markdown
   Extrato bancário de: John Doe (CPF: 123.456.789-00)  
   
   Saldo inicial: R$ 1000,00  

   <!-- Dia 1: (+) R$ 200,00 (Depósito em conta) --> - Acumulado R$ 1200,00
   <!-- Dia 2: (-) R$ 20,00 (Padaria) --> - Acumulado R$ 1180,00
   <!-- Dia 3: (+) R$ 170,00 (Pix recebido) --> - Acumulado R$ 1350,00
   <!-- Dia 4: (-) R$ 20,00 (Pix enviado) --> - Acumulado R$ 1330,00
   <!-- Dia 5: (+) R$ 10,00 (Rendimentos conta) --> - Acumulado R$ 1340,00
   <!-- Dia 5: (+) R$ 10,00 (Rendimentos investimento) --> - Acumulado R$ 1350,00

   Saldo final: R$ 1350,00
```
