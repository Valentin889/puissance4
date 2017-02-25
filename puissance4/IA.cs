using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puissance4
{
    public class IA : Joueur
    {
        private Jeu jeux;
        private int Maxi;
        private int Maxj;
        private int max;
        private int min;
        private int tmp;
        private int iProfondeur;

        public int maxi
        {
            get
            {
                return Maxi;
            }
        }
        public int maxj
        {
            get
            {
                return Maxj;
            }
        }
        public IA(Jeu j, int Profondeur, int numeroJoueur, int numeroJoueurAdverse)
        {
            jeux = j;
            Maxi = 0;
            Maxj = 0;
            max = 0;
            min = 0;
            tmp = 0;
            iProfondeur = Profondeur;
            NumeroJoueur = numeroJoueur;
            NumeroJoueurAdverse = numeroJoueurAdverse;
        }

        public override void DemandeCoup()
        {
            max = -10000;


            for (int i = 0; i < jeux.NombreParColonne.Length; i++)
            {
                Test(jeux.NombreParColonne[i], i, iProfondeur, true);
            }

            this.dernierCoup = maxi;
            jeux.ProchainJoueur();
        }
        private void Test(int i, int j, int profondeur, bool bMax)
        {
            jeux.NombreParColonne[j]++;
            if (bMax)
            {
                jeux.tableau[i][j] = NumeroJoueur;
                tmp = Min(jeux.tableau, profondeur - 1);

                if (tmp > max)
                {
                    max = tmp;
                    Maxi = i;
                    Maxj = j;
                }
            }
            else
            {
                jeux.tableau[i][j] = NumeroJoueurAdverse;
                tmp = Max(jeux.tableau, profondeur - 1);
                if (tmp < min)
                {
                    min = tmp;
                    Maxi = i;
                    Maxj = j;
                }
            }
            jeux.NombreParColonne[j]--;
            jeux.tableau[i][j] = 0;

        }
        private int Max(int[][] jeu, int profondeur)
        {
            if (profondeur == 0 || jeux.gagnant() != 0)
            {
                return eval(jeu);
            }

            max = -10000;
            for (int i = 0; i < jeux.NombreParColonne.Length; i++)
            {
                Test(jeux.NombreParColonne[i], i, profondeur, true);
            }

            return max;

        }
        private int Min(int[][] jeu, int profondeur)
        {
            if (profondeur == 0 || jeux.gagnant() != 0)
            {
                return eval(jeu);
            }

            min = 10000;
            for (int i = 0; i < jeux.NombreParColonne.Length; i++)
            {
                Test(jeux.NombreParColonne[i], i, profondeur, false);
            }
            return min;

        }
        private int eval(int[][] jeu)
        {
            int vainqueur, nb_de_pions = 0;

            //On compte le nombre de pions présents sur le plateau
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (jeu[i][j] != 0)
                    {
                        nb_de_pions++;
                    }
                }
            }

            if ((vainqueur = jeux.gagnant()) != 0)
            {
                if (vainqueur == this.NumeroJoueur)
                {
                    return 1000 - nb_de_pions;
                }
                else if (vainqueur == this.NumeroJoueurAdverse)
                {
                    return -1000 + nb_de_pions;
                }
                else
                {
                    return 0;
                }
            }

            //On compte le nombre de séries de 2 pions alignés de chacun des joueurs
            int series_j1 = 0, series_j2 = 0;


            for (int i=0; i<jeu.Length;i++)
            {
                //test ligne
                for(int j=0; j<jeu[i].Length;j++)
                {
                    
                }
                //test colonne
                for(int j=0; j<jeu.Length;j++)
                {

                }
            }

            return 0;

        }
    }
}
        
