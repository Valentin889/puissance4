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
        private Attente attente;
        private int iRetour;
        public Humain()
        {
            attente = new Attente();
        }
        public override int DemandeCoup()
        {
            Thread t = new Thread(new ThreadStart(ThreadProcSafe));
            t.IsBackground = true;
            t.Start();
            return iRetour;
        }
        private void ThreadProcSafe()
        {
            attente.MethodWait();
        }

        public void Retour(int i)
        {
            iRetour = i;
        }
    }
}
