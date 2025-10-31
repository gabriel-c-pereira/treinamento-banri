# Desafio dojo: Sistema bancário orientado a objetos

## Contexto

Neste segundo coding dojo, você irá evoluir o mesmo sistema bancário criado no dojo de lógica de programação — aquele em que foi implementado o sistema de `Banco`, `ContaBancaria` e `Cliente`, com operações de depósitos, saques e transferências.

A diferença é que agora o foco será **transformar o código em um sistema verdadeiramente orientado a objetos**, deixando de lado a estrutura com classes estáticas e dicionários compartilhados, para utilizar **objetos instanciáveis com características e comportamentos próprios**.

Caso entenda que não possui um resultado satisfatório do seu dojo de lógica de programação, importe o _boilerplate_ de projeto **Console** fornecido na pasta da aula.
Ele contém o resultado final funcional da aplicação do dojo anterior, pronto para ser refatorado de forma orientada a objetos.

## O que deve ser feito

- Converter as classes estáticas (`Banco`, `Cliente`, `ContaBancaria`) em **classes com recursos orientados a objetos**;
- Tornar os tipos "Corrente" e "Poupança" objetos de fato (ex.: `ContaCorrente` e `ContaPoupanca`), e não mais apenas uma característica de `ContaBancaria`;
- Reorganizar a lógica para que **cada instância** mantenha suas **próprias características e comportamentos**;
- Substituir o uso de **dicionários estáticos** por listas e objetos relacionados;
- Utilizar **construtores** para inicializar objetos;
- Usar **encapsulamento** para proteger dados sensíveis, como saldo e CPF;
- Manter a **mesma estrutura de menu interativo** e funcionalidades originais do dojo de lógica.

Além de apenas refatorar o código, procure **identificar as responsabilidades corretas de cada objeto**. Ou seja, sempre pense:

- Quem deveria saber disso?
- Essa operação pertence a quem?
- Esse método depende de qual informação?

O objetivo é **redistribuir a lógica** de maneira coerente e coesa, praticando os princípios da orientação a objetos.

## Exemplos de fluxo de teste de funcionamento

### Paulo Prates

1. **Criar** um `Cliente` "Paulo Prates" com CPF "123.456.789-00";
2. **Abrir/Criar** uma `ContaBancaria` para "Paulo Prates" com saldo inicial de _R$ 1000,00_;
3. **Fazer um depósito** de _R$ 200,00_ na `ContaBancaria` de "Paulo Prates";
4. **Fazer um saque** de _R$ 500,00_;
5. **Abrir/Criar** uma segunda `ContaBancaria` para "Paulo Prates" com saldo inicial de _R$ 0,00_;
6. **Transferir** _R$ 300,00_ da primeira para a segunda `ContaBancaria` de "Paulo Prates";
7. **Consultar o saldo** de cada `ContaBancaria` de "Paulo Prates".

### Ana Andrade

1. **Criar** um `Cliente` "Ana Andrade" com CPF "133.566.799-00";
2. **Abrir/Criar** uma `ContaBancaria` para "Ana Andrade" com saldo inicial de _R$ 5000,00_;
3. **Fazer um depósito** de _R$ 50,00_ na `ContaBancaria` de "Ana Andrade";
4. **Fazer um saque** de _R$ 1550,00_;
5. **Consultar o saldo** da `ContaBancaria` de "Ana Andrade";
6. **Transferir** _R$ 400,00_ da `ContaBancaria` de "Ana Andrade" para a primeira `ContaBancaria` de "Paulo Prates";
7. **Consultar o saldo** da primeira `ContaBancaria` de "Paulo Prates".
