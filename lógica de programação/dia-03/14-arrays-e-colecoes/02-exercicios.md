# Exercícios de arrays e coleções

## 1. Jogo da velha

Vamos criar o famoso _Tic-Tac-Toe_ (ou mais conhecido por nós como jogo da velha) usando uma **matriz**.

Crie um projeto do tipo **Console**, com uma classe `TicTacToe` contendo o método `Main` (entre outros), implementando em C# uma rotina que:

- Cria uma matriz de `char`s para representar o tabuleiro;
- Solicita alternadamente que dois jogadores informem suas jogadas (`X` e `O`);
- Atualiza o array conforme as jogadas;
- Imprime o tabuleiro no console a cada jogada;
- Encerra o jogo se qualquer jogador digitar `9` durante sua jogada.

> Dica: Inicialize o tabuleiro com espaços `' '` para indicar posições vazias e use _loops_  para percorrer a matriz.

### Exemplo de execução esperada

```markdown
   |   |  
---+---+---
   |   |  
---+---+---
   |   |  

Jogador X — escolha a linha (0 a 2): 0
Jogador X — escolha a coluna (0 a 2): 0

 X |   |  
---+---+---
   |   |  
---+---+---
   |   |  

Jogador O — escolha a linha (0 a 2): 1
Jogador O — escolha a coluna (0 a 2): 1

 X |   |  
---+---+---
   | O |  
---+---+---
   |   |  

Jogador X — escolha a linha (0 a 2): 9
Jogador X — escolha a coluna (0 a 2): 2

Jogo encerrado pelo jogador X.
```

**Desafio Extra (não é obrigatório):** Ao final de cada jogada, verifica se algum jogador venceu ou se houve empate, se sim, imprime o resultado no console e encerra o jogo.
