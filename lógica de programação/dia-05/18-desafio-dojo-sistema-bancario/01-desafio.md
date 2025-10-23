# O que é um coding dojo?

Um coding dojo é um ambiente colaborativo onde desenvolvedores se reúnem para praticar suas habilidades de programação em grupo. O foco está no aprendizado, compartilhamento de conhecimento e na melhoria contínua, so invés de competição.

## Como funciona

- Desafio de programação: Um problema de programação (geralmente simples) é apresentado;
- Pair programming: Os participantes trabalham em pares, onde uma pessoa escreve o código (driver) e a outra observa e ajuda (navigator);
- Feedback e rotação: O código é revisado em tempo real pelos demais participantes, com feedback constante. Após um tempo, os papéis são trocados entre os pares.

## Objetivos

- Melhorar a qualidade do código;
- Desenvolver habilidades de trabalho em equipe;
- Aprender novas abordagens e linguagens de programação.

## Desafio dojo: Sistema bancário

### Problema

Você precisa criar um sistema simples para um banco que gerencia contas de clientes. O sistema deve permitir que os clientes façam **depósitos**, **saques** e **visualizem o saldo de suas contas**. Além disso, o sistema deve **suportar transferências entre contas**. **Cada cliente pode ter várias contas**.

### Requisitos funcionais

- Cadastro: `Banco` deve permitir a **criação de clientes** e **contas para clientes**;
- Listagem: `Banco` deve permitir a **listagem de clientes e suas respectivas contas**;
- Visualização de saldo: O `Banco` deve permitir a **consulta do saldo de uma `ContaBancaria`**;
- Depósito: `Banco` deve permitir que um `Cliente` possa **depositar um valor positivo** em uma `ContaBancaria`;
- Saque: `Banco` deve permitir que um `Cliente` possa **sacar um valor que não seja maior que o saldo disponível** de uma `ContaBancaria`;
- Transferência: `Banco` deve permitir que um `Cliente` possa **transferir um valor que não seja maior que o saldo disponível de uma `ContaBancaria` de origem**, para uma `ContaBancaria` de destino. Essa conta pode ser:
  - Uma outra `ContaBancaria` sua;
  - Uma `ContaBancaria` de outro `Cliente`.

### Pré-análise técnica

- Serão necessárias classes para representar ao menos estes 3 objetos do mundo real (comumente chamamos de **entidades**):
  - `Cliente`: Contém informações do cliente, como **nome**, **CPF**, e **uma lista de contas associadas**;
  - `ContaBancaria`: Representa uma conta bancária, com informações como **número da conta**, **tipo ("Corrente" ou "Poupança")** e **saldo**;
  - `Banco`: Responsável por gerenciar as operações de clientes e contas.

### Regras de negócio

- `ContaBancaria` **não deve trabalhar no negativo**. Ou seja, saldo nunca pode baixar de _R$ 0,00_;
- Não é permitido **transferir ou sacar valores maiores que o saldo disponível** da `ContaBancaria`;
- Toda `ContaBancaria` precisa obrigatoriamente ser ou do tipo "Corrente" ou do tipo "Poupança";
- Cada `ContaBancaria` deve conter uma numeração única, gerenciada pelo `Banco`.

### Exemplos de fluxo de teste de funcionamento

#### Paulo Prates

1. **Criar** um `Cliente` "Paulo Prates" com CPF "123.456.789-00";
2. **Abrir/Criar** uma `ContaBancaria` para "Paulo Prates" com saldo inicial de _R$ 1000,00_;
3. **Fazer um depósito** de _R$ 200,00_ na `ContaBancaria` de "Paulo Prates";
4. **Fazer um saque** de _R$ 500,00_;
5. **Abrir/Criar** uma segunda `ContaBancaria` para "Paulo Prates" com saldo inicial de _R$ 0,00_;
6. **Transferir** _R$ 300,00_ da primeira para a segunda `ContaBancaria` de "Paulo Prates";
7. **Consultar o saldo** de cada `ContaBancaria` de "Paulo Prates".

#### Ana Andrade

1. **Criar** um `Cliente` "Ana Andrade" com CPF "133.566.799-00";
2. **Abrir/Criar** uma `ContaBancaria` para "Ana Andrade" com saldo inicial de _R$ 5000,00_;
3. **Fazer um depósito** de _R$ 50,00_ na `ContaBancaria` de "Ana Andrade";
4. **Fazer um saque** de _R$ 1550,00_;
5. **Consultar o saldo** da `ContaBancaria` de "Ana Andrade";
6. **Transferir** _R$ 400,00_ da `ContaBancaria` de "Ana Andrade" para a primeira `ContaBancaria` de "Paulo Prates";
7. **Consultar o saldo** da primeira `ContaBancaria` de "Paulo Prates".
