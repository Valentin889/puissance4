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
        private Jeu jeu;
        private int iProfondeur;
        public Form1()
        {
            InitializeComponent();
            jeu = new Jeu(this);
            iProfondeur = 2;
        }
        private void btnJouer_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = b.Tag.ToString();
            int i = Convert.ToInt32(s);
            jeu.listJoueur[0].dernierCoup = i-1;
            jeu.ProchainJoueur();
        }
        private bool testVictoire()
        {
            if(jeu.Coup>3)
            {
                switch(jeu.gagnant())
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
                    switch (jeu.I1)
                    {
                        case 0: Affichage(pct0, jeu.Joueur);
                            break;
                        case 1: Affichage(pct10, jeu.Joueur);
                            break;
                        case 2: Affichage(pct20, jeu.Joueur);
                            break;
                        case 3: Affichage(pct30, jeu.Joueur);
                            break;
                        case 4: Affichage(pct40, jeu.Joueur);
                            break;
                        case 5: Affichage(pct50, jeu.Joueur);
                            break;
                    }
                    jeu.I1++;
                    break;
                case 1: 
                switch (jeu.I2)
                    {
                        case 0: Affichage(pct1, jeu.Joueur);
                            break;
                        case 1: Affichage(pct11, jeu.Joueur);
                            break;
                        case 2: Affichage(pct21, jeu.Joueur);
                            break;
                        case 3: Affichage(pct31, jeu.Joueur);
                            break;
                        case 4: Affichage(pct41, jeu.Joueur);
                            break;
                        case 5: Affichage(pct51, jeu.Joueur);
                            break;
                    }
                    jeu.I2++;
                    break;
                case 2: 
                switch (jeu.I3)
                    {
                        case 0: Affichage(pct2, jeu.Joueur);
                            break;
                        case 1: Affichage(pct12, jeu.Joueur);
                            break;
                        case 2: Affichage(pct22, jeu.Joueur);
                            break;
                        case 3: Affichage(pct32, jeu.Joueur);
                            break;
                        case 4: Affichage(pct42, jeu.Joueur);
                            break;
                        case 5: Affichage(pct52, jeu.Joueur);
                            break;
                       
                    }
                    jeu.I3++;
                    break;
                case 3: 
                switch (jeu.I4)
                    {
                        case 0: Affichage(pct3, jeu.Joueur);
                            break;
                        case 1: Affichage(pct13, jeu.Joueur);
                            break;
                        case 2: Affichage(pct23, jeu.Joueur);
                            break;
                        case 3: Affichage(pct33, jeu.Joueur);
                            break;
                        case 4: Affichage(pct43, jeu.Joueur);
                            break;
                        case 5: Affichage(pct53, jeu.Joueur);
                            break;
                       
                    }
                    jeu.I4++;
                    break;
                case 4: 
                switch (jeu.I5)
                    {
                        case 0: Affichage(pct4, jeu.Joueur);
                            break;
                        case 1: Affichage(pct14, jeu.Joueur);
                            break;
                        case 2: Affichage(pct24, jeu.Joueur);
                            break;
                        case 3: Affichage(pct34, jeu.Joueur);
                            break;
                        case 4: Affichage(pct44, jeu.Joueur);
                            break;
                        case 5: Affichage(pct54, jeu.Joueur);
                            break;
                       
                    }
                    jeu.I5++;
                    break;
                case 5: 
                switch (jeu.I6)
                    {
                        case 0: Affichage(pct5, jeu.Joueur);
                            break;
                        case 1: Affichage(pct15, jeu.Joueur);
                            break;
                        case 2: Affichage(pct25, jeu.Joueur);
                            break;
                        case 3: Affichage(pct35, jeu.Joueur);
                            break;
                        case 4: Affichage(pct45, jeu.Joueur);
                            break;
                        case 5: Affichage(pct55, jeu.Joueur);
                            break;
                      
                    }
                    jeu.I6++;
                    break;
                case 6: 
                    switch (jeu.I7)
                    {
                        case 0: Affichage(pct6, jeu.Joueur);
                            break;
                        case 1: Affichage(pct16, jeu.Joueur);
                            break;
                        case 2: Affichage(pct26, jeu.Joueur);
                            break;
                        case 3: Affichage(pct36, jeu.Joueur);
                            break;
                        case 4: Affichage(pct46, jeu.Joueur);
                            break;
                        case 5: Affichage(pct56, jeu.Joueur);
                            break;
                      
                    }
                    jeu.I7++;
                    break;
            }
        }
        private void Affichage(PictureBox p, bool b)
        {
            if (b)
            {
                p.BackColor = Color.Blue;
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
            jeu.Recommancer();
        }
        private void btnDefinirJoueur(object sender, EventArgs e)
        {
            ReinitialiserAffichageEtRecommancer();
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            Button b = (Button)sender;
            switch(b.Tag.ToString())
            {
                case "JVJ":
                    jeu.DefinitionJoueur(new Humain(1), new Humain(2));
                    break;  
                case "IAVJ":
                    jeu.DefinitionJoueur(new IA(jeu,iProfondeur,1), new Humain(2));
                    break; 
                case "JVIA":
                    jeu.DefinitionJoueur(new Humain(1), new IA(jeu, iProfondeur,2));
                    break; 
                case "IAVIA":
                    jeu.DefinitionJoueur(new IA(jeu, iProfondeur+1,1), new IA(jeu, iProfondeur,2));
                    break;
            }
            jeu.CommencementDuJEu();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            btnJVJ.Visible = true;
            btnIAVJ.Visible = true;
            btnJVIA.Visible = true;
            btnIAVIA.Visible = true;
        }

        public void AfficheGagnant(Joueur joueurGagnant)
        {
            MessageBox.Show("le joueur "+joueurGagnant.NumeroJoueur.ToString()+" a gagné");
        }
        public void MatchNul()
        {
            MessageBox.Show("Match  nul");
        }
    }
}
