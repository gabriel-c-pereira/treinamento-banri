# Introdução básica ao Visual Studio (VS)

## Tela inicial

Na primeira vez que você abre o VS, verá a tela inicial. Nela, você pode criar novos projetos, abrir projetos existentes, e explorar exemplos e tutoriais. Aqui estão as opções principais:

Tela inicial do VS 2022: 

![Tela inicial](./_assets/01-start.png)

- Create a new project: Inicia um novo projeto.
- Open a project or solution: Abre um projeto existente.
- Recent projects: Lista de projetos recentes.

![Opções](./_assets/02-opcoes.png)

## Criando um novo projeto

Ao criar um novo projeto, você verá a janela "Create a new project", onde poderá escolher o tipo de projeto (como um aplicativo console, aplicativo Windows Forms, ASP.NET, etc.).

![Tipo projeto](./_assets/03-tipo-projeto.png)

1. Escolha o tipo de projeto desejado (Console App, Windows Forms, etc.).
2. Dê um nome ao projeto e escolha o local de armazenamento.

![Projeto console](./_assets/04-console-app.png)

## Explorador de soluções (Solution explorer)

O explorador de soluções é onde você gerencia os arquivos e projetos do seu aplicativo, você pode ver por exemplo.

- Ver todos os arquivos do projeto.
- Adicionar, remover e renomear arquivos.
- Gerenciar referências e bibliotecas.

![Solution explorer](./_assets/05-explorador.png)

## Janela de código (Code editor)

A janela de código é onde você escreve o código. O VS possui muitos recursos úteis para facilitar a codificação, como:

- Numeração de linhas: Exibe o número de cada linha, ajudando a localizar partes específicas do código.
- Destaque de sintaxe: Coloriza palavras-chave, variáveis e tipos de dados para melhor leitura do código.
- _IntelliSense_: Sugere autocompletar para comandos, funções e variáveis enquanto você digita.

![Code editor](./_assets/06-code-editor.png)

## Barra de ferramentas

A barra de ferramentas contém botões para comandos básicos, como:

- Run/Debug (start): Inicia a execução do projeto. É representado por um ícone de "Play".
- Save all: Salva todas as alterações feitas nos arquivos.
- Build solution: Compila todo o projeto para verificar se há erros no código.
- Stop debugging: Para a execução do aplicativo em execução.

![Barra de ferramentas](./_assets/07-barra.png)

## Janela de saída (Output window)

A janela de saída mostra mensagens sobre a compilação, como erros, avisos, e mensagens de status do processo de build.

Como abrir: `Menu View > Output`

![Output window](./_assets/08-output.png)

## Janela de erros (Error list)

A janela de erros mostra todos os erros, avisos e mensagens durante a compilação do projeto, ajudando a localizar e corrigir problemas.

Como abrir: `Menu View > Error List`

> Dica: Clique duas vezes em um erro para ir diretamente para a linha de código correspondente.

![Error list](./_assets/09-erros.png)

## Janela de Propriedades (Properties window)

A janela de propriedades permite configurar as propriedades dos componentes do projeto, como formulários, botões, ou outros elementos da interface do usuário.

Como abrir: Clique em um componente no explorador de soluções ou na interface gráfica e pressione `F4`.

![Properties window](./_assets/10-prop.png)

## Debugging

O _Debugging_ ajuda a identificar problemas no código. Os comandos básicos incluem:

- Breakpoints: Clique no lado esquerdo do editor de código para adicionar um ponto de interrupção. O programa pausará aqui durante a execução para você inspecionar variáveis e lógica.
- Step over (F10): Avança para a próxima linha de código, permitindo analisar o fluxo do programa passo a passo.

![Debug](./_assets/11-debug.png)

## Terminal (Command prompt)

No VS, você pode acessar o terminal para executar comandos do sistema, como iniciar um servidor, compilar manualmente um projeto, etc.

Como abrir: `Menu View > Terminal`

![Command prompt](./_assets/12-console.png)
