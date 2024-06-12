using RPG.Models.Monstros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models.Menu;

internal class MenuCriacao : Menu
{
    public static Personagem? PersonagemCriado {  get; private set; }

    public static string? nick;
    public static string? VocacaoEscolhida { get; private set; }
    public static Equips? EquipamentosDoPersonagem {  get; private set; }

    public static void CriacaoMenu()
    {

        TituloMenu("Bem vindo(a) ao Covil da Bruxa Banguela");
        Console.Write("Para começar, digite seu nick: ");
        nick = Console.ReadLine()!;
        Console.WriteLine($"\nMuito bem {nick}, agora escolha qual vocação você quer escolher:");
        Console.WriteLine("\n1. Guerreiro");
        Console.WriteLine("2. Mago");
        Console.WriteLine("3. Arqueiro");
        Console.WriteLine("4. Curandeiro\n");
        string opcaoEscolhida = Console.ReadLine()!;
        int vocacao = int.Parse(opcaoEscolhida);

        switch (vocacao)
        {
            case 1:
                Console.WriteLine($"\nÓtima escolha, {nick}! A vocação Guerreiro é muito forte!");
                VocacaoEscolhida = "Guerreiro";
                EquipamentosDoPersonagem = new("Mochila Furada", "Adaga Enferrujada", "Elmo Rachado", "Armadura de Ferro Velho", "Calça de Couro Apertada", "Botas Chulezentas", "Escudo Tronco de Árvore Caída");
                PersonagemCriado = new("Guerreiro", 215, 215, 50, 1, nick, 1, 10, 1, 10, 10, EquipamentosDoPersonagem);
                break;
            case 2:
                Console.WriteLine($"\nÓtima escolha, {nick}! A vocação Mago tem um poder sobrenatural!");
                VocacaoEscolhida = "Mago";
                EquipamentosDoPersonagem = new("Mochila Furada", "Varinha Torta", "Chapéu de Festa", "Um Pano Bege", "Saia de Tecido Molinho", "Sandálias", "Um Livro");
                PersonagemCriado = new("Mago", 195, 195, 100, 1, nick, 10, 3, 1, 10, 10, EquipamentosDoPersonagem);
                break;
            case 3:
                Console.WriteLine($"\nÓtima escolha, {nick}! A vocação Arqueiro é muito habilidosa e precisa!");
                VocacaoEscolhida = "Arqueiro";
                EquipamentosDoPersonagem = new("Mochila Furada", "Arco com Cupim e Flechas Cegas", "Capacete de Pena", "Colã de Folhas", "Tonga de Pêlo de Guaxinim", "Botas de Couro de Rato", "Tampa de Panela");
                PersonagemCriado = new("Arqueiro", 205, 205, 70, 1, nick, 3, 3, 10, 10, 10, EquipamentosDoPersonagem);
                break;
            case 4:
                Console.WriteLine($"\nÓtima escolha, {nick}! A vocação Curandeiro é essencial para uma jornada segura!");
                VocacaoEscolhida = "Curandeiro";
                EquipamentosDoPersonagem = new("Mochila Furada", "Bastão Torto", "Chapéu de Festa", "Um Pano Bege", "Saia de Tecido Molinho", "Sandálias", "Um Livro");
                PersonagemCriado = new("Curandeiro", 195, 195, 100, 10, nick, 10, 3, 1, 10, 10, EquipamentosDoPersonagem);
                break;
            default: if (vocacao <= 0 || vocacao > 4)
                {
                    Console.WriteLine("Opção inexistente! Por favor, escolha entre 1. Guerreiro, 2. Mago, 3. Arqueiro ou 4. Curandeiro.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    CriacaoMenu();
                }
                break;
        }

                MenuJornada.JornadaUm();

    }
}
