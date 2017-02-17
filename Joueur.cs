using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puissance4
{
    public abstract class Joueur
    {
        private int iDernierCoup;
        private bool IsHumain = false;
         public abstract void DemandeCoup();

        public int dernierCoup
        {
            get
            {
                return iDernierCoup;
            }
            set
            {
                iDernierCoup = value;
            }
        }
        public bool isHumain
        {
            get
            {
                return IsHumain;
            }
            set
            {
                IsHumain = value;
            }
        }
        public string Gagne()
        {
            return this.GetType().ToString();
        }
    }
}
