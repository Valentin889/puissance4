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
        public IA(Jeu j, int Profondeur)
        {
            jeux = j;
            Maxi = 0;
            Maxj = 0;
            max = 0;
            min = 0;
            tmp = 0;
            iProfondeur = Profondeur;
        }

        public override int DemandeCoup()
        {
            max = -10000;

            Test(jeux.I1, 0, iProfondeur, true);
            Test(jeux.I2, 1, iProfondeur, true);
            Test(jeux.I3, 2, iProfondeur, true);
            Test(jeux.I4, 3, iProfondeur, true);
            Test(jeux.I5, 4, iProfondeur, true);
            Test(jeux.I6, 5, iProfondeur, true);
            Test(jeux.I7, 6, iProfondeur, true);

           
            return Maxi;
        }
        private void Test(int i,int j, int profondeur, bool bMax)
        {
            switch (j)
            {
                case 0:
                    jeux.I1++;
                    break;
                case 1:
                    jeux.I2++;
                    break;
                case 2:
                    jeux.I3++;
                    break;
                case 3:
                    jeux.I4++;
                    break;
                case 4:
                    jeux.I5++;
                    break;
                case 5:
                    jeux.I6++;
                    break;
                case 6:
                    jeux.I7++;
                    break;
            }
            if (bMax)
            {
                jeux.tableau[i][j] = 2;
               
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
                jeux.tableau[i][j] = 1;
                tmp = Max(jeux.tableau, profondeur - 1);
                if (tmp > min)
                {
                    max = tmp;
                    Maxi = i;
                    Maxj = j;
                }
            }
            switch(j)
            {
                case 0:
                    jeux.I1--;
                    break;
                case 1:
                    jeux.I2--;
                    break;
                case 2:
                    jeux.I3--;
                    break;
                case 3:
                    jeux.I4--;
                    break;
                case 4:
                    jeux.I5--;
                    break;
                case 5:
                    jeux.I6--;
                    break;
                case 6:
                    jeux.I7--;
                    break;
            }
            jeux.tableau[i][j] = 0;

        }
        private int Max(int[][] jeu, int profondeur)
        {
            if (profondeur == 0 || jeux.gagnant() != 0)
            {
                return eval(jeu);
            }

            max = -10000;

            Test(jeux.I1, 0, profondeur, true);
            Test(jeux.I2, 1, profondeur, true);
            Test(jeux.I3, 2, profondeur, true);
            Test(jeux.I4, 3, profondeur, true);
            Test(jeux.I5, 4, profondeur, true);
            Test(jeux.I6, 5, profondeur, true);
            Test(jeux.I7, 6, profondeur, true);

            return max;

        }
        private int Min(int[][] jeu, int profondeur)
        {
            if (profondeur == 0 || jeux.gagnant() != 0)
            {
                return eval(jeu);
            }

            min = 10000;

            Test(jeux.I1, 0, profondeur, false);
            Test(jeux.I2, 1, profondeur, false);
            Test(jeux.I3, 2, profondeur, false);
            Test(jeux.I4, 3, profondeur, false);
            Test(jeux.I5, 4, profondeur, false);
            Test(jeux.I6, 5, profondeur, false);
            Test(jeux.I7, 6, profondeur, false);

            return min;

        }
        private int eval(int[][] jeu)
        {
            int vainqueur, nb_de_pions = 0;
            int i, j;

            //On compte le nombre de pions présents sur le plateau
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (jeu[i][j] != 0)
                    {
                        nb_de_pions++;
                    }
                }
            }

            if ((vainqueur = jeux.gagnant()) != 0)
            {
                if (vainqueur == 1)
                {
                    return 1000 - nb_de_pions;
                }
                else if (vainqueur == 2)
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

            jeux.nb_series(2);

            return series_j1 - series_j2;

        }
 
    }
}
