# Exercícios de outros operadores

## 1. Controle de permissões

Imagine que cada **bit** de um número representa uma **permissão** diferente de um sistema:

- bit 0 → pode **ler dados**
- bit 1 → pode **escrever dados**
- bit 2 → pode **excluir dados**

Ou seja, o número `0b000` (inteiro 0) significa **sem permissões**, enquanto `0b111` (inteiro 7) significa **todas as permissões ativas**.

Crie um projeto do tipo **Console**, com uma classe `App` contendo o método `Main` (entre outros), implementando em C# uma rotina que:

- Começa com o valor `0` (nenhuma permissão ativa);  
- Pergunta ao usuário qual permissão deseja manipular: `Ler`, `Escrever` ou `Excluir`;
- Pergunta ao usuário qual operação deseja fazer com a permissão selecionada: `Ativar`, `Desativar` ou `Verificar`;
- Executa a operação, usando operadores bit a bit;
- Mostra o número final e sua forma binária (`Convert.ToString(valor, 2)`);

> Dica: Operadores que podem executar as operações:
>
> - Para **ativar** uma permissão os operadores _OU bit a bit_ e _Deslocamento à esquerda_ podem ser úteis;
> - Para **desativar** uma permissão os operadores _E bit a bit_ e _NÃO bit a bit_ podem ser úteis;
> - Para **verificar** uma permissão o operador _E bit a bit_ pode ser útil.

> Dica: Para manter na impressão N zeros à esquerda, use `"".PadLeft(N, '0')`.
