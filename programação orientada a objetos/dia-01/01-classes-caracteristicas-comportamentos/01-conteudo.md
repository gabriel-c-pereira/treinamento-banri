# Classes, características e comportamentos

## Começando pelo básico

**Classe** é a definição de um tipo de algo que representa características ou comportamentos em orientação a objetos (POO). **(Geralmente damos à classe um nome que descreve o que ela representa, como `ExtratoBancario` ou `Cliente`)**.
**Objeto** é a realização (ou instância) de uma classe.

A classe agrega **características** (campos/atributos) e **comportamentos** (ações/métodos). Em alto nível, a classe nos ajuda a "modelar o mundo real".

A classe, para ser utilizada, é **"instanciada"** (ou seja, seu objeto é criado na memória).

**Juntando tudo, a classe é a definição (o molde) que, quando "nasce" (é instanciada), GERA um objeto, e este objeto é a instância da classe.**

## Modelagem do mundo real

Modelar o mundo real, o que isso significa?

Vamos pensar que, para a Programação Orientada a Objetos, precisamos traduzir o mundo real em algo que possa ser desenvolvido em um programa de computador.
Isso significa que queremos, com código, representar um problema ou uma coisa que existe.

Vamos materializar um pouco mais.

Um extrato bancário, sabemos o que é, correto? É um documento que representa as movimentações que fizemos dentro de um período de tempo.

Em resumo, o extrato é "uma coisa que existe" que representa todos os saques, depósitos ou pagamentos que executamos em uma instituição bancária.

Temos também o saldo, que é um **problema a ser resolvido**.
Ou seja, queremos saber, dentre todas as movimentações de entrada e saída, quanto temos ainda disponível para movimentar (saldo).

## "Agregar" características e comportamentos

Cada linha de um extrato é uma **movimentação**, e cada movimentação tem uma `data`, um `valor` e um `tipo` (ex.: saque ou depósito).

Estes campos `data`, `valor` e `tipo` são **características** armazenadas da movimentação.

Quando queremos saber o `saldo` do **extrato**, precisamos pegar todas as **movimentações**, somar todos os depósitos e subtrair todos os saques.

Este é um possível **comportamento** do **extrato**: `calcular saldo`.

Estas características e comportamentos estão definidos **dentro de uma classe**. Vamos entender que agregar é justamente a ideia de "colocar um conjunto de coisas, que pertencem ao domínio de ação de um objeto do mundo real, dentro da classe que o representa". E para esse objeto "criar vida", a classe precisa de **instanciações**.

Vamos fazer um raciocínio:

- Quais seriam as **classes** necessárias para representar o **extrato** e a **movimentação**, e quais **atributos** e **métodos** estas classes precisariam ter?

Vamos pensar que este conjunto de classes será utilizado para representar o extrato de duas diferentes pessoas: "Carlos" e de "Marcos". Quando as definições estão em código, são **classes**. Quando estão "vivas", ou seja, alocadas em memória (instanciadas), são **objetos**.

O **objeto** de extrato para "Carlos" e o **objeto** de extrato para "Marcos" foram criados a partir da mesma **classe**. Ambos são instâncias dessa classe e compartilham os mesmos conjuntos de atributos, mas são diferentes quanto ao seu **estado interno**, ou seja, o conteúdo destes atributos.

Detalhando um pouco mais, ambos os objetos são de um mesmo **tipo** (ex.: `ExtratoBancario`), porém **uma instância** deste objeto representa "Carlos", e **a outra instância** representa "Marcos" — diferentes instâncias tem estados próprios.

Pense assim: A classe é a definição (como um **molde**) que, quando "nasce" (é **instanciada**), gera um novo objeto na memória — a este objeto se dá o nome de **instância da classe**.
