using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puissance4
{
    public partial class Form1 : Form
    {
        private Jeu j1;
        public volatile bool HumainOK = false;
        private int iProfondeur;
        public Form1()
        {
            InitializeComponent();
            j1 = new Jeu(this);
            iProfondeur = 2;
        }
        private void btnJouer_click(object sender, EventArgs e)
        {
            HumainOK = true;
            Button b = (Button)sender;

            string s = b.Tag.ToString();
            int i = Convert.ToInt32(s);
            if (j1.Jouer(i))
            {
                AppelleAffichage(i-1);
            }
        }
        private bool testVictoire()
        {
            if(j1.Coup>3)
            {
                switch(j1.gagnant())
                {
                    case 1: MessageBox.Show("joueur 1 à gagné");
                        ReinitialiserAffichageEtRecommancer();
                        return true;
                    case 2: MessageBox.Show("joueur 2 à gagné");
                        ReinitialiserAffichageEtRecommancer();
                        return true;
                    default: 
                        break;
                }
            }
            return false;
        }

        public void AppelleAffichage(int i)
        {
            switch(i)
            {
                case 0: 
                    switch (j1.I1)
                    {
                        case 0: Affichage(pct0, j1.Joueur);
                            break;
                        case 1: Affichage(pct10, j1.Joueur);
                            break;
                        case 2: Affichage(pct20, j1.Joueur);
                            break;
                        case 3: Affichage(pct30, j1.Joueur);
                            break;
                        case 4: Affichage(pct40, j1.Joueur);
                            break;
                        case 5: Affichage(pct50, j1.Joueur);
                            break;
                    }
                    j1.I1++;
                    break;
                case 1: 
                switch (j1.I2)
                    {
                        case 0: Affichage(pct1, j1.Joueur);
                            break;
                        case 1: Affichage(pct11, j1.Joueur);
                            break;
                        case 2: Affichage(pct21, j1.Joueur);
                            break;
                        case 3: Affichage(pct31, j1.Joueur);
                            break;
                        case 4: Affichage(pct41, j1.Joueur);
                            break;
                        case 5: Affichage(pct51, j1.Joueur);
                            break;
                    }
                    j1.I2++;
                    break;
                case 2: 
                switch (j1.I3)
                    {
                        case 0: Affichage(pct2, j1.Joueur);
                            break;
                        case 1: Affichage(pct12, j1.Joueur);
                            break;
                        case 2: Affichage(pct22, j1.Joueur);
                            break;
                        case 3: Affichage(pct32, j1.Joueur);
                            break;
                        case 4: Affichage(pct42, j1.Joueur);
                            break;
                        case 5: Affichage(pct52, j1.Joueur);
                            break;
                       
                    }
                    j1.I3++;
                    break;
                case 3: 
                switch (j1.I4)
                    {
                        case 0: Affichage(pct3, j1.Joueur);
                            break;
                        case 1: Affichage(pct13, j1.Joueur);
                            break;
                        case 2: Affichage(pct23, j1.Joueur);
                            break;
                        case 3: Affichage(pct33, j1.Joueur);
                            break;
                        case 4: Affichage(pct43, j1.Joueur);
                            break;
                        case 5: Affichage(pct53, j1.Joueur);
                            break;
                       
                    }
                    j1.I4++;
                    break;
                case 4: 
                switch (j1.I5)
                    {
                        case 0: Affichage(pct4, j1.Joueur);
                            break;
                        case 1: Affichage(pct14, j1.Joueur);
                            break;
                        case 2: Affichage(pct24, j1.Joueur);
                            break;
                        case 3: Affichage(pct34, j1.Joueur);
                            break;
                        case 4: Affichage(pct44, j1.Joueur);
                            break;
                        case 5: Affichage(pct45, j1.Joueur);
                            break;
                       
                    }
                    j1.I5++;
                    break;
                case 5: 
                switch (j1.I6)
                    {
                        case 0: Affichage(pct5, j1.Joueur);
                            break;
                        case 1: Affichage(pct15, j1.Joueur);
                            break;
                        case 2: Affichage(pct25, j1.Joueur);
                            break;
                        case 3: Affichage(pct35, j1.Joueur);
                            break;
                        case 4: Affichage(pct45, j1.Joueur);
                            break;
                        case 5: Affichage(pct55, j1.Joueur);
                            break;
                      
                    }
                    j1.I6++;
                    break;
                case 6: 
                    switch (j1.I7)
                    {
                        case 0: Affichage(pct6, j1.Joueur);
                            break;
                        case 1: Affichage(pct16, j1.Joueur);
                            break;
                        case 2: Affichage(pct26, j1.Joueur);
                            break;
                        case 3: Affichage(pct36, j1.Joueur);
                            break;
                        case 4: Affichage(pct46, j1.Joueur);
                            break;
                        case 5: Affichage(pct56, j1.Joueur);
                            break;
                      
                    }
                    j1.I7++;
                    break;
            }
        }
        private void Affichage(PictureBox p, bool b)
        {
            if (b)
            {
                p.BackColor = Color.Yellow;
            }
            else
            {
                p.BackColor = Color.Red;
            }
        }
        private void ReinitialiserAffichageEtRecommancer()
        {
            foreach (Control p in Controls)
            {
                try
                {
                    PictureBox d = (PictureBox)p;
                    d.BackColor = Color.White;
                }
                catch
                {

                }
               
            }
            j1.Recommancer();
        }
        

        private void btnDefinirJoueur(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch(b.Tag.ToString())
            {
                case "JVJ":
                    j1.DefinitionJoueur(new Humain(this), new Humain(this));
                    break;  
                case "IAVJ":
                    j1.DefinitionJoueur(new IA(j1,iProfondeur), new Humain(this));
                    break; 
                case "JVIA":
                    j1.DefinitionJoueur(new Humain(this), new IA(j1, iProfondeur));
                    break; 
                case "IAVIA":
                    j1.DefinitionJoueur(new IA(j1, iProfondeur+1), new IA(j1, iProfondeur));
                    break;
            }
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            j1.CommencementDuJEu();
        }
    }
}
