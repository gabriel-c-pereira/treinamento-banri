# Exercícios de classes, características e comportamentos em C\#

## 1. Biblioteca

O objetivo é construir um sistema de biblioteca com uma série de funcionalidades como _cadastro de leitores e obras_, _empréstimos_, _devoluções_, entre outros.

Importe o _boilerplate_ de projeto **Console** fornecido na pasta da aula, e na classe `App`, **refatore** o método `Main`, pensando em como "quebrar" melhor o código, separando diferentes responsabilidades em diferentes **classes com características e comportamentos** para que a solução fique mais organizada e elegante.

A execução deve continuar funcional e com resultados exatamente iguais aos que estavam antes da refatoração.

> Dicas:
>
> - Novamente, mantenha o uso da palavra reservada `static` em todas as características e comportamentos das classes.
> - Para que você consiga acessar características e comportamentos de uma classe dentro de outra, marque essas características e comportamentos que forem necessárias com a instrução `public`. Esse recurso, apesar de não aprofundado agora, fará com que o sistema funcione corretamente.
>
> Exemplo:
>
> ```csharp
> class Biblioteca {
>       [...]
>       public static void EmprestarObra() {
>           [...]
>       }
>       [...]
> }
> ```
