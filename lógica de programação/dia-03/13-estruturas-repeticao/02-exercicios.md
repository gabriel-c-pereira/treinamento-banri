# Exercícios de estruturas de repetição

## 1. Adivinhe o número

Vamos criar um jogo simples em que o usuário deve adivinhar um número secreto.

Crie um projeto do tipo **Console**, com uma classe `App` e um método `Main`, implementando em C# uma rotina que:

- Gera um número aleatório entre 1 e 10 (para isso, use o seguinte trecho de código: `int numero = new Random().Next(1, 11);`;
- Solicita ao usuário que tente adivinhar o número;
- Enquanto o usuário não acertar, o programa deve:
  - Exibir uma dica dizendo se o número secreto é **maior** ou **menor** que o palpite atual;
  - Solicitar uma nova tentativa.
- Quando o usuário acertar, o programa deve exibir o número de tentativas feitas.

### Exemplo de execução esperada

```markdown
Estou pensando em um número entre 1 e 10...

Qual é o seu palpite? 4
O número secreto é maior!

Qual é o seu palpite? 7  
O número secreto é menor!

Qual é o seu palpite? 5
Acertou! Você precisou de 3 tentativas.
```

## 2. Menu interativo de assistente virtual

Importe o _boilerplate_ de projeto **Console** fornecido na pasta da aula, e na classe `AssistenteVirtual`, método `Main`, codifique no espaço demarcado uma rotina C# que executa em loop (infinitamente):

- Exibe o **menu interativo** com as seguintes opções:
  - `1` - Exibir data atual;
  - `2` - Exibir hora atual;
  - `3` - Exibir saudação;
  - `0` - Finalizar.
- Solicita uma opção válida ao usuário, executando o método correspondente à opção selecionada;
- Caso uma opção inválida seja selecionada, exibe "Opção inválida" ao usuário e segue a execução;
- Encerra o loop e o programa como um todo somente quando o usuário selecionar a opção `0` - Finalizar.

> Dica: Os métodos auxiliares do boilerplate `ExibirMenu()`, `ObterDataAtual()`, `ObterHoraAtual()` e `DizerOla()` deverão ser usados, e não necessitam modificação.

### Exemplo de execução esperada

```markdown
===== Menu Interativo =====
1 - Exibir data atual
2 - Exibir hora atual
3 - Exibir saudação
0 - Finalizar
===========================
Escolha uma opção válida: 1
Data atual: 15/06/2025

===== Menu Interativo =====
1 - Exibir data atual
2 - Exibir hora atual
3 - Exibir saudação
0 - Finalizar
===========================
Escolha uma opção válida: 3
Olá, usuário!

===== Menu Interativo =====
1 - Exibir data atual
2 - Exibir hora atual
3 - Exibir saudação
0 - Finalizar
===========================
Escolha uma opção válida: 0
Encerrando o assistente virtual. Até mais...
```

## 3. Pirâmide do Mario

Inspirado no famoso jogo do encanador, o objetivo é construir uma pirâmide de blocos com o caractere `#`, cuja altura é definida pelo usuário.

Crie um projeto do tipo **Console**, com uma classe `App` e um método `Main`, codificando nele uma rotina C# que:

- Solicita ao usuário a **altura da pirâmide** (um número inteiro entre 1 e 8);
- Utiliza **_loops_** para desenhar no console uma pirâmide alinhada à direita.

### Exemplo de execução esperada

```markdown
Digite a altura da pirâmide (1 a 8): 5

    #
   ##
  ###
 ####
#####
```

> Dica: o uso de loops aninhados (um loop dentro de outro) pode ser útil para controlar espaços e blocos.
