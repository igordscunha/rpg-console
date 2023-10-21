using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models.Menu;

internal class Menu
{
    public static void TituloMenu(string titulo)
    {
        int tamanhoDoTitulo = titulo.Length;
        string asteriscos = string.Empty.PadLeft(tamanhoDoTitulo, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n\n");
    }
}
