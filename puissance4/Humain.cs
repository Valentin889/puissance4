using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace puissance4
{
    public class Humain : Joueur
    {
        public Humain()
        {
        }
        public override int DemandeCoup()
        {
            return 0;
        }
    }
}
