# Exercícios de tipagem

## 1. Exploração de tipos

Crie um projeto do tipo **Console**, com uma classe `App` e um método `Main`, codificando nele uma rotina C# que:

- Declara uma variável do tipo `char` e tenta atribuir a ela o emoji '😊'. Leia o que acontece, deixe este trecho comentado com a descrição do erro, e após, repita a declaração em uma linha abaixo, agora atribuindo o emoji '☺';
- Declara uma outra variável do tipo `char`, atribuindo a ela uma letra qualquer (por exemplo, 'A'), e após, jogando o valor dessa variável para dentro de uma outra variável do tipo `int`. A que o número resultante se refere?;
- Declara uma `string` com valor "TRUE" ou "FALSE" (maiúsculos) e usa o `Convert.ToBoolean` para transformar no boolean equivalente, atribuindo a uma variável `bool`. O que acontece se a variável `bool` for impressa em um System.Console.WriteLine("...")?;
- Declara uma variável do tipo `double` representando **pontos ganhos em um jogo** (exemplo: 84.68) e após, _converte explicitamente_ esses pontos em balas de chocolate (unitárias), representadas por uma variável do tipo `int`. O que acontece ao se converter os pontos ganhos diretamente para o respectivo número de balas?
