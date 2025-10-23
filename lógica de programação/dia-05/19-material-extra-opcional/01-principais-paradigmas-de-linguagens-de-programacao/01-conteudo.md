# Principais paradigmas de linguagens de programação

## Níveis de programação

No início da história da computação, programar significava comunicar-se quase diretamente com a máquina. As primeiras linguagens eram de _baixo nível_, o que significa que exigiam do programador um controle muito detalhado sobre o hardware.

Um exemplo clássico é o **Assembly**, em que cada instrução está intimamente ligada a operações de processadores, registradores e endereços de memória.
Essas linguagens são poderosas e extremamente eficientes, porém muito mais difíceis de escrever, compreender e manter.

Com o avanço da tecnologia e o aumento da demanda por software, surgiu a necessidade de se "abstrair" esses detalhes complexos de hardware.
Assim nasceram as **linguagens de alto nível**, que aproximam o código da forma como o ser humano pensa e se comunica. Elas permitem expressar a lógica de forma mais intuitiva e próxima da nossa linguagem — e o próprio computador, por meio de compiladores, interpretadores ou máquinas virtuais, se encarrega de traduzir isso para o nível da máquina.

Em resumo:

- Quanto mais próxima da _linguagem da máquina_, mais **baixo nível** é a linguagem de programação;
- Quanto mais próxima da _linguagem humana_, mais **alto nível** é a linguagem de programação.

À medida que _subimos o nível_ de uma linguagem, aumentamos seu grau de abstração — passamos de instruções específicas do hardware para expressões mais conceituais e descritivas.

## O que é um paradigma

Em termos gerais, a palavra "paradigma" significa "modelo” ou “padrão”. Ou seja, é a expressão da classificação de uma forma "comum" de se fazer algo.
No contexto da programação, um paradigma define como pensamos e estruturamos a solução de um problema em código.

Um paradigma é, portanto, um "modo de pensar" a programação — um conjunto de conceitos, regras e práticas que orientam a forma como desenvolvemos software. Ele influencia desde a organização do código até a maneira como lidamos com dados, funções, objetos e eventos.

## Paradigmas de programação

Todas as linguagens de programação seguem propostas a partir de determinados paradigmas mais utilizados, porém com uma série de nuances e variações.

Entre os principais paradigmas de programação, destacam-se:

- Imperativo;
- Declarativo;
- Funcional;
- Orientado a Eventos;
- Orientado a Objetos.

Quanto às nuances e variações dentro das linguagens em específico, algumas regras são normalmente observadas:

- Raras linguagens **implementam e seguem fielmente um único paradigma** — quando isso acontece, as chamamos de linguagens **puras**. Um exemplo de linguagem _funcional pura_ é o **Haskell**, que mantém o paradigma funcional de forma consistente, sem misturar características imperativas ou orientadas a objetos, por exemplo.
- Em termos gerais, a maioria das linguagens suportam **múltiplos paradigmas de forma _acidental_ ou _pragmática_**, ou seja, contém recursos que possibilitam que vários paradigmas possam ser aplicados de acordo com a preferência do programador: em **Python** ou **C#**, por exemplo, você pode programar orientado a objetos, mas ainda assim usar funções declarativas ou código imperativo com controles de fluxos e estado, mesmo que a linguagem não tenha sido projetada especificamente para isso;
- Entretanto, algumas linguagens são **projetadas explicitamente e propositalmente como _multi-paradigma_**, facilitando um conjunto bem definido de paradigmas, como por exemplo **Scala**, que objetiva proporcionar programação **imperativa, orientada a objetos e funcional**.

### Paradigma imperativo

O **_paradigma mais basilar_** de programação, onde o desenvolvedor foca em **como** o programa deve executar tarefas. Nele se detalham as instruções que dizem ao computador exatamente **o que fazer e em qual ordem**, passo a passo.

Remetendo aos primórdios do estudo de algoritmos, pense em uma receita de bolo:

- Você não apenas pede o bolo pronto, mas sim descreve cada ingrediente, cada etapa e a ordem de execução a se seguir.

#### Objetivo

Fornecer **controle total** sobre o fluxo de execução e estados, definido em detalhes o **como** resolver. Isso permite otimizar desempenho, lidar com operações complexas e gerenciar explicitamente dados e mutações.

#### Características principais

- Controle de fluxo explícito: Uso de loops, condicionais e mutações na execução;
- Mutação de estados: Valores de variáveis e objetos podem ser alterados durante a execução;
- Organização estruturada: Código organizado em blocos com determinados objetivos.

#### Exemplos

Em **C#**:

```csharp
// Controla como somar os números pares dentro de um dado grupo de números.
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
int soma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        soma += numeros[i];
    }
}
```

### Paradigma declarativo

Quase que como em uma espécie de "evolução" do **_paradigma basilar imperativo_**, no **paradigma declarativo** o desenvolvedor foca em descrever **o que** quer, seja como intenção de ação ou como resultado a ser alcançado, ao invés de ~~**como fazer**~~, e o sistema, abstraído, se encarrega de percorrer os caminhos para alcançar o objetivo.

Em outras palavras, você não controla o fluxo de execução passo a passo, mas sim **declara** a intenção ou objetivo que deseja atingir.
O “como” ainda existe — mas ele está **abstraído (escondido)** dentro de algum tipo de mecanismo, como uma _engine_, um _framework_ ou um _interpretador_, geralmente construídos para a _linguagem de domínio específico_, ou seja, responsável por "entender" o que foi pedido e realizar o trabalho detalhado.

Pense em um restaurante:

- No **paradigma imperativo**, você vai até a cozinha e pede o prato, mas detalha exatamente como quer que ele seja feito, com instruções de ingredientes, preparação e cozimento;
- já no **paradigma declarativo**, você vai até o balcão da cozinha, pede o prato, e aguarda que o prato, pronto, seja entregue a você, sem se preocupar nos detalhes de como ele foi feito.

#### Objetivo

Reduzir a complexidade do código ao abstrair detalhes de controle e estado. O foco está em **expressar intenções** ou **resultados esperados**, deixando para o mecanismo em questão decidir **como** resolver.

#### Características principais

- Abstração do controle de fluxo: Loops, condicionais e mutações são abstraídos;
- Imutabilidade frequente: Em muitas linguagens declarativas, os dados não podem ser modificados após definidos;
- Domínios específicos: É comum em linguagens voltadas a tarefas específicas, como **SQL** (bancos de dados) e **HTML** (estruturação de páginas web);
- Fundamenta frameworks: Em muitos casos, o paradigma declarativo é usado como base para que outros desenvolvedores expressem apenas intenções, enquanto a lógica imperativa fica escondida no motor de execução.

#### Exemplos

Em **C#**:

```csharp
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

// Intenção: Somar os números pares dentro de um dado grupo de números.
SomarPares(numeros);
```

Em **SQL**:

```sql
/* Intenção: Selecionar nomes dos clientes com idade maior que 18. */
SELECT Nome FROM Clientes WHERE Idade > 18;
```

Em **HTML**:

```html
<!-- Intenção: demarcar a existência de um bloco de artigo. -->
<article>
    <!-- Intenção: demarcar dentro do bloco de artigo a existência de um bloco de cabeçalho/introdução do artigo. -->
    <header>
        <!-- Intenção: demarcar dentro do bloco de cabeçalho/introdução um título principal formatado. -->
        <h1>"Olá mundo" na programação</h1>
        <!-- Intenção: demarcar dentro do bloco de cabeçalho/introdução um parágrafo textual. -->
        <p>Esse artigo visa explicar porquê afinal programadores gostam tanto de usar "olá mundo"</p>
    </header>
</article>
```

> Curiosidade semântica: `SomarPares` ou `ParesSomados`?
>
> Quando falamos de **intenção ou resultado**, podemos pensar que o método a ser chamado poderia ser expressado de ambas as formas, seja através da intenção de _somar números pares_, ou do resultado esperado de _pares somados_. Isso pouco importa declarativamente, pois o essencial é que seja atingida a característica de abstração.
> Por boa prática, se convencionou no mundo da programação o uso da forma de verbo de ação que expressa a intenção: _Somar pares_ — `SomarPares`.

> Dica de ouro: No fim, toda execução depende de algum nível imperativo, mas **quanto mais abstrações são criadas, mais declarativo o código se torna** para quem o utiliza.

### Paradigma orientado a eventos

Nele, o foco não está em descrever ~~**como fazer**~~, e nem em ~~**o que**~~ deve ser feito, mas sim no **quando** algo deve ser feito, ou seja, em resposta a algum acontecimento — ou evento.

O programa, em vez de seguir uma sequência linear de comandos, aguarda que determinados eventos ocorram — como um clique de botão, uma tecla pressionada, uma mensagem recebida ou um sinal de rede — e então reage a eles, executando rotinas específicas.
Dessa forma, o fluxo do programa é **dirigido pelos eventos**, e não pelo código imperativo diretamente escrito.

Em termos conceituais, o paradigma orientado a eventos pode ser visto como uma **abstração reativa** do imperativo — ele responde a estímulos externos ou internos, e sua execução é disparada por acontecimentos, e não por uma ordem fixa predefinida.

Pense em uma verificação se alguém está à sua porta:

- No **paradigma imperativo**, você abriria a porta e iria até fora da casa, de tempos em tempos, para verificar se alguém chegou — ou seja, o fluxo é controlado por você, passo a passo;
- No **paradigma declarativo**, com a intenção de verificar se alguém chegou, você verificaria o olho mágico;
- Já no **paradigma orientado a eventos**, você instalaria uma campainha: e reagiria indo até a porta só quando o botão fosse pressionado.

#### Objetivo

Permitir que o programa **reaja dinamicamente** a estímulos (eventos) internos ou externos, tornando a execução flexível, responsiva e interativa.  
O controle de fluxo é determinado pelos **acontecimentos**, e não por uma sequência rígida de instruções.

#### Características principais

- Fluxo de controle reativo: O código é executado em resposta a eventos que ocorrem de forma assíncrona ou imprevisível;
- Eventos e _handlers_: Define-se um conjunto de **ouvintes** (_listeners_) que aguardam por eventos específicos e **manipuladores** (_handlers_) que tratam esses eventos quando ocorrem;
- Desacoplamento de lógica: A lógica de resposta fica separada do fluxo principal do programa, favorecendo extensibilidade e manutenção;
- Alta aplicabilidade em _Graphical User Interfaces (GUIs)_ e sistemas distribuídos: Comum em interfaces gráficas, frontend, sistemas reativos e arquiteturas baseadas em mensagens (filas, _brokers_ de eventos).

#### Exemplos

Em programação _desktop_ **C#** (Windows Forms):

```csharp
Button botao = new Button();

// Quando o botão é clicado, o evento "Click" é disparado e o método BotaoClick é executado.
void BotaoClick(object sender, EventArgs e)
{
    Console.WriteLine("O botão foi clicado!");  
}

// Atribui o método BotaoClick ao evento "Click" da variável botao.
botao.Click += BotaoClick;
```

Em **JavaScript**:

```js
let botao = document.getElementById("botao-checkout");

// Quando o botão é clicado, o evento "Click" é disparado e a função botaoClick é executada.
function botaoClick(event) {
    console.log("O botão foi clicado!");
}

// Adiciona um "listener" para o evento "click" da variável botao, apontando para a função botaoClick.
botao.addEventListener("click", botaoClick);
```

### Paradigma orientado a objetos

Um dos mais populares e difundidos da história da programação moderna. Ele propõe uma forma de estruturação baseada em representações de "coisas" do mundo real, chamadas **entidades** ou **objetos** — que possuem **características (atributos)** e **comportamentos (métodos)**.

O principal objetivo é modelar o problema do mundo real de forma mais natural, aproximando o pensamento humano da estrutura do programa. Ou seja, ao invés de pensar em **o que**, **como** ou **quando**, agora o foco passa a ser em **quem** (qual objeto) é responsável por executar tarefas.

Pense em um delivery de comida:

- No **paradigma imperativo**, após a recepção do pedido, você escreveria passo a passo, de forma linear e detalhada, cada ação, por exemplo: ler o pedido, calcular o valor, preparar a comida, embalar e entregar;
- No **paradigma declarativo**, você apenas definiria o que deveria acontecer ou o resultado desejado de cada etapa, sem especificar como cada uma delas seria executada — pois isso já estaria implementado em uma camada anterior;
- No **paradigma orientado a eventos**, as ações ocorreriam em resposta a gatilhos: quando o pedido fosse recebido, o preparo da comida seria iniciado automaticamente; quando o preparo terminasse, o cálculo do valor seria disparado; e, ao final, a entrega seria acionada;
- No **paradigma orientado a objetos**, cada parte envolvida (como por exemplo `Cliente`, `Pedido`, `Prato` e `Entregador`) é representada como uma **entidade autônoma** com características e comportamentos próprios. Assim, o `Pedido` "saberia" se calcular, o `Prato` "saberia" se preparar e embalar, e o `Entregador` "saberia" se deslocar.

#### Objetivo

Representar o sistema como uma coleção de objetos que interagem entre si, cada um com responsabilidades bem definidas. O foco está em organizar código e dados em torno de entidades que possuem identidade própria, ou seja, **_seus próprios estados e suas próprias ações_**.

#### Características principais

- Abstração e modelagem do mundo real: Objetos representam entidades com estado e ações;
- Encapsulamento: Cada objeto mantém seus dados internos protegidos e expõe apenas o necessário;
- Mensagens entre objetos: O comportamento do sistema emerge da interação entre os objetos, e não de uma sequência fixa de comandos;
- Modularidade e reutilização: Código pode ser reutilizado e estendido facilmente através de classes e instâncias.

#### Exemplos

Em **C#**:

```csharp
// Representação de uma "entidade" do mundo real, que possui um nome, uma idade, e saber falar.
public class Pessoa  
{  
    public string Nome { get; private set; }
    public int Idade { get; private set; }

    public Pessoa(string nome, int idade) {
        Nome = nome;
        Idade = idade;
    }

    public void Falar()  
    {  
        System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");  
    }
}  

// ----------------------------------------

// Uso da representação de "entidade", para as N pessoas que forem necessárias.
Pessoa john = new Pessoa("John Doe", 29);
john.Falar();

Pessoa mary = new Pessoa("Mary Monroe", 31);
mary.Falar();
```

Em **Java**:

```java
// Representação de uma "entidade" do mundo real, que possui um nome, uma idade, e saber falar.
public class Pessoa {  
    private String nome;
    private int idade;

    public Pessoa(String nome, int idade) {  
        this.nome = nome;
        this.idade = idade;
    }  

    public void falar() {  
        System.out.printf("Olá, meu nome é %s e tenho %d anos.%n", this.nome, this.idade);
    }
}

// ----------------------------------------

// Uso da representação de "entidade", para as N pessoas que forem necessárias.
Pessoa john = new Pessoa("John Doe", 29);
john.falar();

Pessoa mary = new Pessoa("Mary Monroe", 31);
mary.falar();
```

Em **Python**:

```py
# Representação de uma "entidade" do mundo real, que possui um nome, uma idade, e saber falar.
class Pessoa:
    def __init__(self, nome, idade):
        self.nome = nome
        self.idade = idade

    def falar(self):
        print(f"Olá, meu nome é {self.nome} e tenho {self.idade} anos.")

# ------------------------------

# Uso da representação de "entidade", para as N pessoas que forem necessárias.
john = Pessoa("John Doe", 29)
john.falar()

mary = Pessoa("Mary Monroe", 31)
mary.falar()
```

### Paradigma funcional

Tem suas raízes na matemática e propõe uma forma de programar baseada na **avaliação de funções** — ou seja, descrever o programa como uma composição de funções que transformam dados de entrada em dados de saída, **sem alterar estados** e **sem gerar efeitos colaterais**.

Em outras palavras, no **paradigma funcional**, o foco está em um conjunto de **como** e **o que**, mas com um viés muito diferente dos **paradigmas imperativo e declarativo**. Esse **como** e **o que** são "matemáticos": seguem princípios rigorosos de **imutabilidade** e **pureza**, garantindo que cada função se comporte como uma **equação previsível**, sempre produzindo o mesmo resultado para as mesmas entradas.

Pense em um sistema de produção de café:

- No **paradigma imperativo**, você descreveria para o barista exatamente como preparar o café: selecionar o café, fazer a moagem, esquentar a água, filtrar etc.;
- No **paradigma declarativo**, você diria apenas que quer "um café", deixando para o barista decidir como fazer;
- No **paradigma orientado a eventos**, você apertaria o botão da máquina e o café seria preparado quando o evento fosse acionado;
- No **paradigma orientado a objetos**, você teria entidades como por exemplo `Cafeteira`, `Copo` e `Cafe`, e cada um saberia executar seu papel;
- Já no **paradigma funcional**, você diria que quer "um café", mas esse café seguiria um processo rigoroso de **aplicação de funções puras encadeadas** para transformação dos dados, como por exemplo:

|     |   |     |     |     |     |     |     |     |     |     |
| :-: | - | :-: | :-: | :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| _Função_ | | | `MoerGraos(graos)` | | `FerverAgua(poCafe, aguaFria)` | | `Filtrar(poCafe, aguaQuente)` | | `Servir(cafeFiltrado)` | |
| _Dados_ | | <small>**_Grãos de café_**</small> | ➔ | <small>**_Pó de café + Água fria_**</small> | ➔ | <small>**_Pó de café + Água quente_**</small> | ➔ | <small>**_Café filtrado_**</small> | ➔ | <small>**_Café servido no copo_**</small> |

#### Objetivo

Transformar o processamento em uma composição de funções previsíveis e independentes, priorizando **imutabilidade**, **pureza** e **composição funcional**.  
O foco está em **como combinar funções** e **o que transformar** para chegar ao resultado final, sem alterar estados intermediários.

#### Características principais

- Pureza: Produzem sempre o mesmo resultado para os mesmos parâmetros e não causam efeitos colaterais (como modificar variáveis externas);
- Imutabilidade: Valores e estruturas de dados não são alterados; se algo precisa mudar, cria-se uma nova versão;
- Funções de alta ordem: Funções podem ser atribuídas a variáveis, passadas como parâmetros e retornadas por outras funções;
- Composição de funções: Funções pequenas e simples podem ser combinadas para formar operações complexas;
- Recursão: Substituição do uso de laços (como `for` ou `while`) por _recursividade (chamadas sucessivas de funções a si mesmas)_.

#### Exemplos 

Em **F#**:

```fsharp
let numeros = [1; 2; 4; 7; 12; 15]

// Definição de uma função pura para verificar se um número é par — onde "num" antes do sinal de igual (=) é o parâmetro de entrada, e o retorno (bool) é implícito
let isPar num = num % 2 = 0

// Definição de uma função pura para somar dois números — onde "num1" e "num2" antes do sinal de igual (=) são os parâmetros de entrada, e o retorno (int) é implícito
let somar num1 num2 = num1 + num2

// Filtra os números pares e os soma
let somaPares = numeros |> List.filter isPar |> List.reduce somar

printfn "Soma dos números pares: %d" somaPares // Soma dos números pares: 18
```

> Nota: Observe que não há nenhuma mutação: cada função recebe uma entrada e devolve uma nova saída, sem modificar o que veio antes.

Em **JavaScript** aplicando estilo funcional:

```js
// Soma os números pares de uma lista, usando funções puras e imutáveis
const numeros = [1, 2, 4, 7, 12, 15];

// Definição de uma função pura para verificar se um número é par — onde "num" antes do sinal "arrow" (=>) é o parâmetro de entrada, e o retorno (bool) é implícito
const isPar = num => num % 2 === 0;

// Definição de uma função pura para somar dois números — onde "num1" e "num2" antes do sinal "arrow" (=>) são os parâmetros de entrada, e o retorno (int) é implícito
const somar = (num1, num2) => num1 + num2;

// Filtra os números pares e os soma
const somaPares = numeros.filter(isPar).reduce(somar);

console.log(`Soma dos números pares: ${somaPares}`); // Soma dos números pares: 18
```

## [Exercícios](02-exercicios.md)
