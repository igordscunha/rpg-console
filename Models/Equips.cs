using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models;

public class Equips
{

    public Equips(string backpack, string sword, string helmet, string armor, string legs, string boots, string shield)
    {
        Backpack = backpack;
        Sword = sword;
        Helmet = helmet;
        Armor = armor;
        Legs = legs;
        Boots = boots;
        Shield = shield;
    }
    public static string? Backpack { get; set; }
    public static string? Sword { get; set; }
    public static string? Helmet { get; set; }
    public static string? Armor { get; set; }
    public static string? Legs { get; set; }
    public static string? Boots { get; set; }
    public static string? Shield { get; set; }

    public static string InfoEquips()
    {
        return $"\nMochila: {Backpack}\nHelmet: {Helmet}\nArmor: {Armor}\nWeapon: {Sword}\nShield: {Shield}\nLegs: {Legs}\nBoots: {Boots}\n";
    }
}
