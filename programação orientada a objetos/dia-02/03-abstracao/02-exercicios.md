# Exercícios de abstração

## 1. Pix entre diferentes tipos de pessoas

Importe o _boilerplate_ de projeto **Console** fornecido na pasta da aula. Nele você já possui uma implementação de abstração com classes `PixPessoaFisica` e `PixPessoaJuridica`, baseadas em uma classe abstrata `Pix`, conforme os exemplos vistos em aula.  
Agora, seu desafio é **permitir transferências entre pessoas físicas e jurídicas, e vice-versa**.

A ideia é garantir que o programa seja apto a efetuar PIX:
  
- De pessoa física para pessoa física (pronto);
- De pessoa física para pessoa jurídica;
- De pessoa jurídica para pessoa jurídica (pronto);
- De pessoa jurídica para pessoa física;

## 2. Formas geométricas

Crie um projeto **Console** com uma classe `App`, um método `Main` e todo o conjunto restante de elementos para implementar uma estrutura que permita **trabalhar com formas geométricas de maneira genérica**, mas que cada forma saiba **como calcular sua própria área e perímetro**.

Pense em um **modelo base** que descreva o comportamento comum de todas as formas — como o ato de calcular `Area` e `Perimetro` — sem saber **como exatamente** cada forma faz isso.

Depois, crie **representações específicas** (como um `Retangulo`, `Quadrado` e `Circulo`), cada uma com sua forma própria de realizar os cálculos.

Configure as representações para poderem exibir os resultados dos cálculos na tela.

As fórmulas de cálculo serão as seguintes:

| Forma geométrica | Cálculo de área | Cálculo de perímetro |
| :-: | :-: | :-: |
| `Retangulo` | <small>`base x altura`</small> | <small>`2 × (base + altura)`</small> |
| `Quadrado` | <small>`lado²`</small> | <small>`4 × lado`</small> |
| `Círculo` | <small>`π × raio²`</small> | <small>`2 × π × raio`</small> |

> Dica: O `π` pode ser obtido através da propriedade estática `PI` da classe `Math`.

**Desafio Extra (não é obrigatório):** E quanto ao(s) triângulo(s)?

## 3. Sistema de notificações

Crie um projeto **Console** com uma classe `App`, um método `Main` e toda a estrutura necessária para construir um **sistema de envio de notificações**, capaz de se adaptar a diferentes meios de comunicação.

A ideia é permitir que o programa possa **enviar mensagens de forma genérica**, mas cada tipo de notificação terá sua própria forma de mostrar a mensagem no console.

Pense em uma forma de definição de **contrato**, em que todos os tipos de notificação devem ter (por exemplo, um método `EnviarMensagem(string mensagem)`).
Depois, crie **implementações específicas** para representar diferentes meios de envio:

- Envio de mensagens por **E-mail**;
- Envio de mensagens por **SMS**;
- Envio de mensagens por **Push (celular)**;

### Exemplo de execução esperada

```markdown
Enviando E-mail: Pedido confirmado!

Enviando SMS: Pedido confirmado!

Enviando Push: Pedido confirmado!
```
