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
        private Form1 form;
        private BackgroundWorker backgroundWorker1;
        public Humain(Form1 f)
        {
            form = f;
        }
        public override int DemandeCoup()
        {
            backgroundWorker1 = new BackgroundWorker();
            this.backgroundWorker1.RunWorkerAsync();
            form.HumainOK = false;
            while(!form.HumainOK)
            {

            }
            return 0;
            
        }
    
    }
}
