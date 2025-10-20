# Exercícios de estruturas condicionais

## 1. Descubra seu avatar

O objetivo é construir um analisador de avatares, combinando animais, cores e aventuras, com base nas escolhas do usuário.

Importe o _boilerplate_ de projeto **Console** fornecido na pasta da aula, e na classe `App`, método `Main`, codifique no espaço demarcado uma rotina C# que:

- Solicite ao usuário:
    - Um **animal preferido**: receber como `string` — exemplos de animais a serem aceitos: `cão`, `gato`, `coruja` ou `dragão`;
    - Uma **cor favorita**: receber como `string` — exemplos de cores a serem aceitas: `vermelho`, `azul`, `verde` e `amarelo`;
    - Uma **aventura preferida**: receber como `string` — exemplos de aventuras a serem aceitas: `explorar`, `descansar`, `criar` ou `competir`.
- Para cada entrada, você deve **implementar condições (`if`, `else if`, `else`, `switch`)** que:
    - Associem o animal digitado à constante correspondente (constantes já estão no boilerplate, iniciam com o prefixo `ANIMAL`);
    - Associem a cor digitada à constante correspondente (constantes já estão no boilerplate, iniciam com o prefixo `COR`);
    - Associem a aventura digitada à constante correspondente (constantes já estão no boilerplate, iniciam com o prefixo `AVENTURA`);
    - Não esqueça de associar animais, cores e aventuras correspondentes também para o caso de as informações fornecidas pelo usuário não estejam dentro dos animais, cores e aventuras padrão/esperados (também há constantes para essa finalidade).
- A regras de associação são as seguintes:

    -------------------------------------------------------
    | Entrada do usuário     | Constante                  |
    |:----------------------:|:--------------------------:|
    | **ANIMAL**             |                            |
    | cão                    | ANIMAL_COMPANHEIRO         |
    | gato                   | ANIMAL_ASTUTO              |
    | coruja                 | ANIMAL_GUARDIAO            |
    | dragão                 | ANIMAL_FEROZ               |
    | outro animal           | ANIMAL_DESCONHECIDO        |
    | **COR**                |                            |
    | vermelho               | COR_FLAMEJANTE             |
    | azul                   | COR_SABEDORIA              |
    | verde                  | COR_SILVESTRE              |
    | amarelo                | COR_RADIANTE               |
    | outra cor              | COR_MISTERIOSA             |
    | **AVENTURA**           |                            |
    | explorar               | AVENTURA_EXPLORAR          |
    | descansar              | AVENTURA_DESCANSAR         |
    | criar                  | AVENTURA_CRIAR             |
    | competir               | AVENTURA_COMPETIR          |
    | outra aventura         | AVENTURA_DESTEMIDA         |
    -------------------------------------------------------

- A impressão final deve estar no formato: `"Seu avatar é: {animal} {cor} - {aventura}"`.

### Exemplo de execução esperada

```
Digite seu animal preferido (cão, gato, coruja, dragão): dragão
Digite sua cor favorita (vermelho, azul, verde, amarelo): vermelho
Digite sua aventura preferida (explorar, descansar, criar, competir): competir

Seu avatar é: Feroz Flamejante – Audaciosa(o) e competitiva(o)!
```

> Dica: Lembre-se de como converter uma string para `lowercase`, isso pode ser útil como tratamento das informações fornecidas pelo usuário no momento de implementar as condicionais de decisão.
