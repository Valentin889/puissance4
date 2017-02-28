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
        public int eval(int[][] jeu)
        {

            int vainqueur = 0;
            

            if ((vainqueur = jeux.gagnant()) != 0)
            {
                if (vainqueur == this.NumeroJoueur)
                {
                    return Int32.MaxValue;
                }
                else if (vainqueur == this.NumeroJoueurAdverse)
                {
                    return Int32.MinValue;
                }
                else
                {
                    return 0;
                }
            }

           
            //on compte le nombre de possibilité de gagné par joueur
            int iCompteur1 = 0;
            int iCompteur2 = 0;
            int iSeries_j1 = 0;
            int iSeries_j2 = 0;

            for (int i=0; i<jeu.Length;i++)
            {
                iCompteur1 = 0;
                iCompteur2 = 0;
                //test ligne
                for(int j=0; j<jeu[i].Length;j++)
                {
                    if(jeu[i][j]==this.NumeroJoueur)
                    {
                        iCompteur2 = 0;
                        iCompteur1++;
                    }
                    else if(jeu[i][j]==this.NumeroJoueurAdverse)
                    {
                        iCompteur1 = 0;
                        iCompteur2++;
                    }
                    else
                    {
                        iCompteur1++;
                        iCompteur2++;
                    }
                    if(iCompteur1>=4)
                    {
                        iSeries_j1++;
                    }
                    if(iCompteur2>=4)
                    {
                        iSeries_j2++;
                    }
                }
                iCompteur1 = 0;
                iCompteur2 = 0;
                //test colonne
                for(int j=0; j<jeu.Length;j++)
                {
                    if (jeu[j][i] == this.NumeroJoueur)
                    {
                        iCompteur2 = 0;
                        iCompteur1++;
                    }
                    else if (jeu[j][i] == this.NumeroJoueurAdverse)
                    {
                        iCompteur1 = 0;
                        iCompteur2++;
                    }
                    else
                    {
                        iCompteur1++;
                        iCompteur2++;
                    }
                    if (iCompteur1 >= 4)
                    {
                        iSeries_j1++;
                    }
                    if (iCompteur2 >= 4)
                    {
                        iSeries_j2++;
                    }
                }
            }

            //test des trois première diagonal montante
            for (int iColonne = 2 ;iColonne >= 0; iColonne--)
            {
                iCompteur1 = 0;
                iCompteur2 = 0;
                for (int i=iColonne, j=0; i<jeu.Length&&j<jeu[iColonne].Length-iColonne-1;i++,j++)
                {
                    if (jeu[i][j] == this.NumeroJoueur)
                    {
                        iCompteur2 = 0;
                        iCompteur1++;
                    }
                    else if (jeu[i][j] == this.NumeroJoueurAdverse)
                    {
                        iCompteur1 = 0;
                        iCompteur2++;
                    }
                    else
                    {
                        iCompteur1++;
                        iCompteur2++;
                    }
                    if (iCompteur1 >= 4)
                    {
                        iSeries_j1++;
                    }
                    if (iCompteur2 >= 4)
                    {
                        iSeries_j2++;
                    }
                }
            }
            //test des trois dernière diagonal montante
            for(int iLigne=1; iLigne<4;iLigne++)
            {
                iCompteur1 = 0;
                iCompteur2 = 0;
                for (int i=0, j=iLigne; i<jeu.Length-iLigne+1&&j<jeu[i].Length;i++,j++)
                {
                    if (jeu[i][j] == this.NumeroJoueur)
                    {
                        iCompteur2 = 0;
                        iCompteur1++;
                    }
                    else if (jeu[i][j] == this.NumeroJoueurAdverse)
                    {
                        iCompteur1 = 0;
                        iCompteur2++;
                    }
                    else
                    {
                        iCompteur1++;
                        iCompteur2++;
                    }
                    if (iCompteur1 >= 4)
                    {
                        iSeries_j1++;
                    }
                    if (iCompteur2 >= 4)
                    {
                        iSeries_j2++;
                    }
                }
            }


            //test des trois première diagonal descendante
            for (int iLigne=3;iLigne>0;iLigne--)
            {
                iCompteur1 = 0;
                iCompteur2 = 0;
                for (int i=jeu.Length-1, j=iLigne;i>=iLigne-1&&j<jeu[i].Length;i--,j++)
                {
                    if (jeu[i][j] == this.NumeroJoueur)
                    {
                        iCompteur2 = 0;
                        iCompteur1++;
                    }
                    else if (jeu[i][j] == this.NumeroJoueurAdverse)
                    {
                        iCompteur1 = 0;
                        iCompteur2++;
                    }
                    else
                    {
                        iCompteur1++;
                        iCompteur2++;
                    }
                    if (iCompteur1 >= 4)
                    {
                        iSeries_j1++;
                    }
                    if (iCompteur2 >= 4)
                    {
                        iSeries_j2++;
                    }
                }
            }
            //test des trois dernière diagonal descandante
            int iReduction = 0;
            for(int iColonne =jeu.Length-1; iColonne>2;iColonne--)
            {
                iCompteur1 = 0;
                iCompteur2 = 0;
                iReduction++;
                for(int i=iColonne, j=0; i>=0&&j<jeu[i].Length-iReduction;i--,j++)
                {
                    if (jeu[i][j] == this.NumeroJoueur)
                    {
                        iCompteur2 = 0;
                        iCompteur1++;
                    }
                    else if (jeu[i][j] == this.NumeroJoueurAdverse)
                    {
                        iCompteur1 = 0;
                        iCompteur2++;
                    }
                    else
                    {
                        iCompteur1++;
                        iCompteur2++;
                    }
                    if (iCompteur1 >= 4)
                    {
                        iSeries_j1++;
                    }
                    if (iCompteur2 >= 4)
                    {
                        iSeries_j2++;
                    }
                }
            }


            return iSeries_j1-iSeries_j2;

        }
    }
}
        



