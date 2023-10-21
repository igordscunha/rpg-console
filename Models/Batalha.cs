using RPG.Models.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models;

internal class Batalha
{
    public static void Luta(Monstros.Monstros monstro)
    {
        Console.Clear();
        Menu.Menu.TituloMenu("Batalha Frenética");
        Personagem.InformacoesDoPersonagem();
        monstro.InfoMonstro();
        Console.WriteLine("");
        Thread.Sleep(1200);

        while (Monstros.Monstros.Vida > 0)
        {
            Console.WriteLine("Aperte qualquer tecla para continuar...\n");
            Console.ReadKey();
            Thread.Sleep(700);
            Personagem.Atacar(monstro);
            Monstros.Monstros.Atacar(MenuCriacao.PersonagemCriado);

            //bool ataqueBemSucedido = Personagem.Atacar(monstro);
            if ( Monstros.Monstros.Vida <= 0)
            {
                Console.WriteLine($"\nParabéns! Você derrotou esta aberração!");
                Thread.Sleep(1500);
                Console.WriteLine("\nAperte qualquer tecla para continuar...\n");
                Console.ReadKey();
                Thread.Sleep(2000);
                Personagem.UparLevelPrimario();
                Thread.Sleep(500);
                Console.Clear();
                break;
            }

            if (Personagem.VidaAtual <= 0)
            {
                Thread.Sleep(3000);
                Console.WriteLine($"\n\nÉ... essa jornada chegou ao fim... Parece que {Monstros.Monstros.Nome} foi demais pra você e te fez virar camisa da saudade!");
                Console.WriteLine("G A M E O V E R");
                Console.WriteLine("\nAperte qualquer tecla para prosseguir...\n");
                Console.ReadKey();
                Thread.Sleep(2500);
                Console.Clear();
                Menu.Menu.TituloMenu($"FUNERAL DO {Personagem.Nick}");
                Console.WriteLine("\n\n\n\nViveu como poucos...");
                Console.WriteLine($"\nRiP {Personagem.Nick}\n");
                Console.WriteLine("Lembraremos de você... ou não!");
                break;
            }
        }

    }
}
