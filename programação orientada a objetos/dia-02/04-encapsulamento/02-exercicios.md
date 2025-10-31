# Exercícios de encapsulamento

## 1. Conta bancária simples

Crie um projeto **Console** com uma classe `App`, um método `Main` e todo o conjunto restante de elementos para implementar uma **Conta Bancária Simples** com regras básicas de encapsulamento:

- Características:
  - `Número da conta`: Encapsulado - Somente leitura;
  - `CPF do titular`: Encapsulado - Somente leitura;
  - `Nome do titular`: Encapsulado - Somente leitura;
  - `Saldo`: Encapsulado - Alteração externa somente através de métodos de regra de negócio;
- Comportamentos:
  - `Depositar`: Acresce o saldo, não aceita valores menores a 0;
  - `Sacar`: Decresce do saldo, não permite saldo negativo, retorna `true` ou `false` para o sucesso ou não da operação.

Exemplo de Main criando contas:

```csharp
ContaBancaria contaJohn = new ContaBancaria("148.578.595-25", "John Doe");

contaJohn.Numero = 25; // Erro.

contaJohn.Titular = "Mary Monroe"; // Erro.

contaJohn.Saldo = 1000000; // Erro.

Console.WriteLine($"Conta {contaJohn.Numero} em nome de {contaJohn.Titular}: Saldo de {contaJohn.Saldo}.");

contaJohn.Depositar(100);

Console.WriteLine($"Saque de R$ 30,00 {(contaJohn.Sacar(30) ? "bem sucedido!" : "Não foi concluído.")}"); // Bem sucedido.

Console.WriteLine($"Saque de R$ 100,00 {(contaJohn.Sacar(100) ? "bem sucedido!" : "Não foi concluído.")}"); // Não concluído.

Console.WriteLine($"Conta {contaJohn.Numero} em nome de {contaJohn.Titular}: Saldo de {contaJohn.Saldo}.");
```
