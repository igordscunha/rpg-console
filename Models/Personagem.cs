using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models;

public class Personagem
{
    public Personagem
        (
        string vocacao,
        int vidaCheia,
        int vidaAtual,
        int mana,
        int level,
        string nick,
        int magiclevel,
        int weaponskill,
        int distanceskill,
        int speed,
        int shielding,
        Equips equips
        )
    {
        Vocacao = vocacao;
        Nick = nick;
        VidaMaxima = vidaCheia;
        VidaAtual = vidaCheia;
        Mana = mana;
        Level = level;
        Magiclevel = magiclevel;
        Weaponskill = weaponskill;
        Distanceskill = distanceskill;
        Speed = speed;
        Shielding = shielding;
        Equips = equips;
    }

    public static string? Nick { get; set; }
    public static string? Vocacao { get; private set; }
    public static int VidaMaxima { get; set; }
    public static int VidaAtual { get; set; }
    public static int Mana { get; private set; }
    public static int Level { get; private set; }
    public static int Magiclevel { get; private set; }
    public static int Weaponskill { get; private set; }
    public static int Distanceskill { get; private set; }
    public static int Speed { get; private set; }
    public static int Shielding { get; private set; }
    public static Equips? Equips { get; set; }


    public static void InformacoesDoPersonagem()
    {
        Console.WriteLine($"Nick: {Nick}\nVocação: {Vocacao}\nLevel: {Level}\nVida: {VidaAtual}\nMana: {Mana}\nMagiclevel: {Magiclevel}\nWeaponskill: {Weaponskill}\nDistanceskill: {Distanceskill}\nShielding: {Shielding}\nSpeed: {Speed}\n\nEquips: {Equips.InfoEquips()}\n");

    }

    public static bool Atacar(Monstros.Monstros monstro)
    {
        Random random = new Random();
        int chanceDeDesvio = Speed / Monstros.Monstros.Speed * random.Next(1, 31);

        if (random.Next(0, 201) > chanceDeDesvio)
        {
            int Atk = EncontrarAtaqueVocacao();
            int dano = Atk / Monstros.Monstros.Def * random.Next(1, 21);

            if (dano > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Você acertou em cheio! Esse demônio recebeu incríveis {dano} de dano!");
                monstro.LevarDano(dano);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Não é que esse desgraçado é forte? Seu ataque pareceu surgir efeito nenhum!");
                Console.ResetColor();
            }
            return true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Esse desgraçado é rápido! Conseguiu desviar do seu ataque!");
            Console.ResetColor();
            return false;
        }
    }

    public void LevarDano(int dano)
    {
        VidaAtual -= dano;
        if (dano < 0)
        {
            VidaAtual = 0;
        }
        Console.WriteLine($"Meu deus do céu esse bicho é tinhoso! Te acertou um tomahawk e te deixou com {VidaAtual} de vida!\n");
    }

    public static int EncontrarAtaqueVocacao()
    {
        int maior = Personagem.Weaponskill;
        if (Distanceskill > maior)
        {
            maior = Distanceskill;
        }
        if (Magiclevel > maior)
        {
            maior = Magiclevel;
        }
        return maior;
    }

    public static void UparLevelPrimario()
    {
        string vocacao = Personagem.Vocacao;

        if (vocacao == "Guerreiro")
        {
            Level += 5;
            VidaMaxima += 80;
            Mana += 15;
            Weaponskill += 18;
            Magiclevel += 3;
            Distanceskill += 5;
            Shielding += 20;
            Speed += 5;

            Equips equipamentoDoPersoagem = new("Mochila de Couro", "Espada Longa", "Capacete de Ferro Inoxidavel", "Armadura de Bronze Batido", "Calça Resistente de Latão", "Botas Reluzentes", "Escudo Imperial de Guerra");
        }
        if (vocacao == "Mago")
        {
            Level += 5;
            VidaMaxima += 50;
            Mana += 80;
            Weaponskill += 3;
            Magiclevel += 30;
            Distanceskill += 3;
            Shielding += 10;
            Speed += 10;

            Equips equipamentoDoPersoagem = new("Mochila de Couro", "Varinha da Colina Mágica", "Chapeu do Mago Enlouquecido", "Capa Poderosa", "Calça Preta do Necromancer", "Botas do Mal", "Livro Mágico de Magia Negra");
        }
        if (vocacao == "Arqueiro")
        {
            Level += 5;
            VidaMaxima += 65;
            Mana += 50;
            Weaponskill += 8;
            Magiclevel += 10;
            Distanceskill += 24;
            Shielding += 15;
            Speed += 30;

            Equips equipamentoDoPersoagem = new("Mochila de Couro", "Arco Curvado e Flechas Venenosas", "Capacete da Invisibilidade", "Armadura Dourada dos Elfos", "Calça de Couro Flexível", "Botas da Velocidade", "Escudo Dourado dos Elfos");
        }
        if (vocacao == "Curandeiro")
        {
            Level += 5;
            VidaMaxima += 50;
            Mana += 80;
            Weaponskill += 3;
            Magiclevel += 30;
            Distanceskill += 3;
            Shielding += 10;
            Speed += 10;

            Equips equipamentoDoPersoagem = new("Mochila de Couro", "Cajado da Cura Milagrosa", "Chapeu de Pena de Anjos", "Capa Poderosa", "Calça Branca da Cura Sagrada", "Botas do Bem", "Livro Mágico de Cura e Sabedoria");
        }
    }

    public static void UparLevelAvancado()
    {
        string vocacao = Personagem.Vocacao;

        if (vocacao == "Guerreiro")
        {
            Level += 44;
            VidaMaxima += 520;
            VidaAtual = VidaMaxima;
            Mana += 185;
            Weaponskill += 42;
            Magiclevel += 3;
            Distanceskill += 5;
            Shielding += 25;
            Speed += 20;
            vocacao = "Guerreiro de Elite";

            Equips equipamentoDoPersoagem = new("Mochila Compacta Camuflada", "Espada Obsidiana em Chamas", "Capacete de Ouro", "Armadura Vulcânica", "Calça dos Poderes Demoníacos", "Botas da Velocidade", "Escudo do Falecido Rei Jacÿntö");
        }
        if (vocacao == "Mago")
        {
            Level += 44;
            VidaMaxima += 150;
            VidaAtual = VidaMaxima;
            Mana += 1120;
            Weaponskill += 7;
            Magiclevel += 40;
            Distanceskill += 3;
            Shielding += 30;
            Speed += 30;
            vocacao = "Mago Mestre";

            Equips equipamentoDoPersoagem = new("Mochila Compacta Camuflada", "Varinha do Mago Enlouquecido", "Chapeu da Magia Obsidiana", "Capa dos Sete Poderes Mágicos", "Calça Prateada da Energia Lunar", "Botas da Velocidade", "Livro Supremo da Magia Negra");
        }
        if (vocacao == "Arqueiro")
        {
            Level += 44;
            VidaMaxima += 350;
            VidaAtual = VidaMaxima;
            Mana += 590;
            Weaponskill += 12;
            Magiclevel += 10;
            Distanceskill += 51;
            Shielding += 20;
            Speed += 40;
            vocacao = "Arqueiro da Realeza";

            Equips equipamentoDoPersoagem = new("Mochila Compacta Camuflada", "Arco Dourado e Flechas Flamejantes", "Capacete Sagrado da Mira Suprema", "Armadura de Escamas Élficas", "Calça da Invisibilidade", "Botas da Velocidade Suprema", "Escudo Invisível");
        }
        if (vocacao == "Curandeiro")
        {
            Level += 44;
            VidaMaxima += 150;
            VidaAtual = VidaMaxima;
            Mana += 1120;
            Weaponskill += 7;
            Magiclevel += 40;
            Distanceskill += 3;
            Shielding += 30;
            Speed += 30;
            vocacao = "Curandeiro Celestial";

            Equips equipamentoDoPersoagem = new("Mochila Compacta Camuflada", "Cajado do Curandeiro Supremo da Floresta", "Chapeu da Magia Obsidiana", "Capa dos Sete Poderes Mágicos", "Calça Prateada da Energia Solar", "Botas da Velocidade", "Livro Supremo da Magia Sagrada");
        }
    }

    public static void HealarVida()
    {
        VidaAtual = VidaMaxima;
    }
}