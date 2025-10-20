# Exercícios de expressões aritméticas

## 1. Exploração de operações matemáticas

Crie um projeto do tipo **Console**, com uma classe `App` e um método `Main`, codificando nele uma rotina C# que:

- Solicita ao usuário que digite **dois números**, armazenando-os em variáveis numéricas;
- Realiza todas as operações aritméticas básicas entre esses dois valores:
  1. **Soma `+`**
  2. **Subtração `-`**
  3. **Multiplicação `*`**
  4. **Divisão `/`** — O que acontece aqui se o segundo número informado for zero?
  5. **Resto `%`**
- Exibe os resultados de todas as operações no console, com mensagens descritivas.

> Dica: Para obter uma entrada numérica do console, use `System.Console.ReadLine()` e converta o retorno disso com `Convert.ToDouble()` ou `double.Parse()`.

### Exemplo de execução esperada

```
Digite o primeiro número: 8
Digite o segundo número: 3

Soma: 11
Subtração: 5
Multiplicação: 24
Divisão: 2,6666667
Resto: 2
```

## 2. Exploração do operador módulo `%` - Desafiador/Opcional

Crie um projeto do tipo **Console**, com uma classe `App` e um método `Main`, codificando nele uma rotina C# que:

- Solicita ao usuário que digite um **número inteiro de três dígitos**;
- Extrai cada dígito sequencialmente da unidade à centena, exibindo-os um a um no console;
- Acumule todos os valores somando-os em uma nova variável;
- Exibe ao final a soma dos dígitos;

### Exemplo de execução esperada

```
Digite um número inteiro de três dígitos: 472

Unidade: 2
Dezena: 7
Centena: 4
Soma dos dígitos: 13
```

> Dicas: 
> - Assim como uma variável double com `Convert.ToDouble()` ou `double.Parse()`, um inteiro pode ser convertido na leitura com `Convert.ToInt32()` ou `int.Parse()`;
> - Para obter ou remover o último dígito de um numeral (ou seja, os decimais), os operadores divisão `\` e módulo `%` podem ser úteis.
