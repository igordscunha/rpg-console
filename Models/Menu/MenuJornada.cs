using RPG.Models.Dialogos;
using RPG.Models.Monstros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models.Menu;

internal class MenuJornada : Menu
{
    public static void JornadaUm()
    {        
        Thread.Sleep(3800);
        Console.Clear();
        TituloMenu("Informações do Personagem"); //Classe Menu. Herança por enquanto para futuramente usar algum override
        Personagem.InformacoesDoPersonagem();
        Thread.Sleep(1200);
        Console.WriteLine($"Ótimo, {MenuCriacao.nick}, vamos continuar sua jornada!\n");
        Thread.Sleep(1200);
        Console.WriteLine("Você acabou de acordar. Está um pouco desorientado ainda. Percebe que está no centro de uma cidade bastante movimentada. Carroças e pessoas indo e vindo.");
        Thread.Sleep(1200);
        Console.WriteLine("\nAqui estão as opções que você pode seguir:\n");
        Thread.Sleep(1200);
        Console.WriteLine("1. Falar com um comerciante próximo.");
        Console.WriteLine("2. Pedir esmolas.");
        Console.WriteLine("3. Sair da cidade para explorar por si só.\n");
        string opcaoNumerica = Console.ReadLine()!;
        int opcaoEscolhida = int.Parse(opcaoNumerica);

        switch (opcaoEscolhida)
        {
            case 1:
                DialogoUm.DialogoComerciante();
                break;
            case 2:
                DialogoUm.DialogoEsmola();
                break;
            case 3: 
                DialogoUm.DialogoSairCidade();
                break;
        }

    }

    public static void JornadaDois()
    {
        Thread.Sleep(3800);
        Console.Clear();
        Menu.TituloMenu("Informações do Personagem");
        Personagem.InformacoesDoPersonagem();
        Console.WriteLine("Você se sente mais forte e com novos equipamentos que foram dropados da batalha.");
        Console.WriteLine("\n\nAperte alguma tecla para continuar...");
        Console.ReadKey();
        Thread.Sleep(1600);
        Console.Clear();
        Menu.TituloMenu("Cidade Medieval Yguäbä Ghrande");
        Console.WriteLine("\n\nDepois dessa luta, você se sente mais experiente e pronto para explorar novos ares!");
        Thread.Sleep(1200);
        Console.WriteLine("Você pensa em algumas opções a seguir:\n\n");
        Console.WriteLine("1. Dormir para se curar.");
        Console.WriteLine("2. Treinar suas habilidades.");
        Console.WriteLine("3. Tentar ir falar com o Rei.\n");
        string resposta = Console.ReadLine();
        int respostaEscolhida = int.Parse(resposta);

        switch (respostaEscolhida)
        {
            case 1: DialogoDois.Dormir();
                break;
            case 2: DialogoDois.Treinamento();
                break;
            case 3: DialogoDois.FalarComReiFraco();
                break;
        }
    }
}
