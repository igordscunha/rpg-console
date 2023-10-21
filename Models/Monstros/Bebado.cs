using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models.Monstros;

public class Bebado : Monstros
{
    public Bebado() : base("Bêbado Violento", 50, 18, 4, 2) { }

    public override void InfoMonstro()
    {
        base.InfoMonstro();
    }
}