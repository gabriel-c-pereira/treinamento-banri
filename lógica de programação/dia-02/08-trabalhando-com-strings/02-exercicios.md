# Exercícios de strings

## 1. Exploração de strings

Crie um projeto do tipo **Console**, com uma classe `App` e um método `Main`, codificando nele uma rotina C# que:

- Solicita ao usuário que digite seu nome e seu sobrenome, armazenando-os em duas strings diferentes;
- Exibe o nome do usuário usando **interpolação de strings**, incluindo o nome e o sobrenome capturados;
- Manipule as strings fornecidas pelo usuário, para imprimir outras duas variações:
    1. Exibe uma mensagem contendo apenas as iniciais, em formato maíusculo, do nome e sobrenome, e também a contagem total de caracteres contidos em ambos. Exemplo: Para nome e sobrenome **john doe** fornecidos, a impressão esperada é `Iniciais e contagem: J.D. (7)`;
    2. Exibe uma mensagem contendo o _nome secreto_ que é composto de:
        - Primeira metade do nome;
        - Segunda metade do sobrenome;
        - Regra geral: caso o número de caracteres das strings de nome e/ou sobrenome sejam ímpares, incluir o caractere extra;
        - Exemplo: Para nome e sobrenome **john doe** fornecidos, a impressão esperada é `Nome secreto: jooe`.

> Dica: Para obter uma string do console, use `System.Console.ReadLine()`.
