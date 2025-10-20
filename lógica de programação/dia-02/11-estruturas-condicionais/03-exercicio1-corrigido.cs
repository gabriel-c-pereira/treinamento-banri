// 1. Descubra seu avatar

using System;

class App
{
    /* Constantes de animais */
    const string ANIMAL_COMPANHEIRO = "Companheira(o)";
    const string ANIMAL_ASTUTO = "Astuta(o)";
    const string ANIMAL_GUARDIAO = "Guardiã(o)";
    const string ANIMAL_FEROZ = "Feroz";
    const string ANIMAL_DESCONHECIDO = "Desconhecida(o)";
    
    /* Constantes de cores */
    const string COR_FLAMEJANTE = "Flamejante";
    const string COR_SABEDORIA = "Sábia(o)";
    const string COR_SILVESTRE = "Silvestre";
    const string COR_RADIANTE = "Radiante";
    const string COR_MISTERIOSA = "Misteriosa(o)";

    /* Constantes de aventuras */
    const string AVENTURA_EXPLORAR = "Pront(a)o para aventuras!";
    const string AVENTURA_DESCANSAR = "Tranquila(o) e serena(o)!";
    const string AVENTURA_CRIAR = "Criativa(o) e engenhosa(o)!";
    const string AVENTURA_COMPETIR = "Audaciosa(o) e competitiva(o)!";
    const string AVENTURA_DESTEMIDA = "Destemida(o) em qualquer jornada!";

    static void Main()
    {
        Console.WriteLine(".:: Descubra seu Avatar ::. \n");

        /* Capturar animal, cor e aventura informados pelo usuário */

        Console.Write("Digite seu animal preferido (cão, gato, coruja, dragão): ");
        string animalUsuario = Console.ReadLine()?.ToLower();

        Console.Write("Digite sua cor favorita (vermelho, azul, verde, amarelo): ");
        string corUsuario = Console.ReadLine()?.ToLower();

        Console.Write("Digite sua aventura preferida (explorar, descansar, criar, competir): ");
        string aventuraUsuario = Console.ReadLine()?.ToLower();

        /* Implementar lógicas de mapeamento para as constantes fornecidas
         * Exemplo: se o usuário informar "vermelho", uma variável deve receber o valor da constante COR_FLAMEJANTE
        */

        string animalEscolhido;
        if (animalUsuario == "cão")
        {
            animalEscolhido = ANIMAL_COMPANHEIRO;
        }
        else if (animalUsuario == "gato")
        {
            animalEscolhido = ANIMAL_ASTUTO;
        }
        else if (animalUsuario == "coruja")
        {
            animalEscolhido = ANIMAL_GUARDIAO;
        }
        else if (animalUsuario == "dragão")
        {
            animalEscolhido = ANIMAL_FEROZ;
        }
        else
        {
            animalEscolhido = ANIMAL_DESCONHECIDO;
        }
            

        string corEscolhida;
        if (corUsuario == "vermelho")
        {
            corEscolhida = COR_FLAMEJANTE;
        }
        else if (corUsuario == "azul")
        {
            corEscolhida = COR_SABEDORIA;
        }
        else if (corUsuario == "verde")
        {
            corEscolhida = COR_SILVESTRE;
        }
        else if (corUsuario == "amarelo")
        {
            corEscolhida = COR_RADIANTE;
        }
        else
        {
            corEscolhida = COR_MISTERIOSA;
        }

        string aventuraEscolhida;
        switch (aventuraUsuario)
        {
            case "explorar":
                aventuraEscolhida = AVENTURA_EXPLORAR;
                break;
            case "descansar":
                aventuraEscolhida = AVENTURA_DESCANSAR;
                break;
            case "criar":
                aventuraEscolhida = AVENTURA_CRIAR;
                break;
            case "competir":
                aventuraEscolhida = AVENTURA_COMPETIR;
                break;
            default:
                aventuraEscolhida = AVENTURA_DESTEMIDA;
                break;
        }

        /* Imprimir a descrição do avatar no formato: "Seu avatar é: {animal} {cor} - {aventura}" */
        Console.WriteLine($"\nSeu avatar é: {animalEscolhido} {corEscolhida} - {aventuraEscolhida}");
    }
}
