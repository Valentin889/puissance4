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
        public Humain(int iNumero)
        {
            NumeroJoueur = iNumero;
            isHumain = true;
        }
        public override  void DemandeCoup()
        {
            
        }
    }
}
