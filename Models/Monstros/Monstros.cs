using RPG.Models.Dialogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Models;

namespace RPG.Models.Monstros;

public class Monstros
{
    public Monstros(string nome, int vida, int atk, int def, int speed)
    {
        Nome = nome;
        Vida = vida;
        Atk = atk;
        Def = def;
        Speed = speed;
    }

    public static string? Nome { get; private set; }
    public static int Vida { get; private set; }
    public static int Atk { get; private set; }
    public static int Def { get; private set; }
    public static int Speed { get; private set;}

    public virtual void InfoMonstro()
    {
        Console.WriteLine($"\n{Nome}\n\nVida: {Vida}\nAtk: {Atk}\nDef: {Def}\nSpeed: {Speed}");
    }

    public static bool Atacar(Personagem personagem)
    {
        Random random = new Random();
        int chanceDeDesvio = Speed / Personagem.Speed * random.Next(1, 31);

        if (random.Next(0, 201) > chanceDeDesvio)
        {
            int dano = Atk * random.Next(0, 21) / Personagem.Shielding;
            if (dano > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\nReceba essas flores! Você levou uma feia! Esse demônio te deu {dano} de dano!");
                personagem.LevarDano(dano);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"\nSegura o faixa preta... Você bloqueou o ataque! {Nome} não fez nem cosquinha em você...\n");
                Console.ResetColor();
            }
            return true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nVocê é rápido como o vento e desviou! Assim fica impossível de te acertarem!\n");
            Console.ResetColor();
            return false;
        }
    }

    public void LevarDano(int dano)
    {
        Vida -= dano;
        if (dano < 0)
        {
            Vida = 0;
        }
        if (Vida <= 0)
        {
            Console.WriteLine($"{Nome} parece inabalável e ainda tem 0 de vida restante!");
        }
        else
        {
        Console.WriteLine($"{Nome} parece inabalável e ainda tem {Vida} de vida restante!" );
        }
    }
}
