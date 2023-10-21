using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models.Monstros;

internal class Dragao : Monstros
{
    public Dragao() : base("Dragão Ancestral das Neves", 2500, 75, 50, 55) { }

    public override void InfoMonstro()
    {
        base.InfoMonstro();
    }
}
