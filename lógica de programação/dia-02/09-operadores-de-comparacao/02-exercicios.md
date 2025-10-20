# Exercícios de operadores de comparação

## 1. Exploração de resultados booleanos

Crie um projeto do tipo **Console**, com uma classe `App` e um método `Main`, codificando nele uma rotina C# que:

- Solicita ao usuário que digite **dois números**, armazenando-os em variáveis numéricas;
- Realiza todas as comparações básicas entre esses dois valores:
  1. num1 **`>`** num2
  2. num1 **`<`** num2
  3. num1 **`==`** num2
  4. num1 **`!=`** num2
  5. num1 **`>=`** num2
  6. num1 **`<=`** num2
- Exibe os resultados de todas as operações no console, com mensagens descritivas.

### Exemplo de execução esperada

```
Digite o primeiro número: 10
Digite o segundo número: 7

10 > 7 → True
10 < 7 → False
10 == 7 → False
10 != 7 → True
10 >= 7 → True
10 <= 7 → False
```


## 2. Teste de senha

Crie um projeto do tipo **Console**, com uma classe `App` e um método `Main`, codificando nele uma rotina C# que:

- Solicita ao usuário que digite uma **senha**;
- Compara o valor digitado com uma senha armazenada em uma constante (use o texto que quiser. Ex.: `"TRE1N4MENT0_MM"`);
- Exibe o resultado de senha digitada válida ou inválida através de `True` ou `False` no console.

### Exemplos de execução esperada

```
Digite a senha: tre1n4ment0_mm
Senha válida? False
```

```
Digite a senha: TRE1N4MENT0_MM
Senha válida? True
```

> Dica: O operador `==` diferencia letras maiúsculas e minúsculas.  

## 3. Relação booleano-numérica

**Desafio:** Reaproveite o exercício 1 e modifique **ao menos duas das comparações** de forma que o resultado seja exibido **como os números 0 ou 1** ao invés de `False` ou `True`.

### Exemplo de execução esperada

```
Digite o primeiro número: 10
Digite o segundo número: 7

10 > 7 → 1
10 < 7 → False
10 == 7 → False
10 != 7 → True
10 >= 7 → True
10 <= 7 → 0
```

> Dica: Não é necessário alterar todas as comparações — apenas duas já são suficientes.