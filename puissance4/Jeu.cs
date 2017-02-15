using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace puissance4
{
    public class Jeu
    {
        private List<Joueur> ListJoueur;
        private Form1 form;
        private int[][] Tableau;
        private int i1;
        private int i2;
        private int i3;
        private int i4;
        private int i5;
        private int i6;
        private int i7;
        private int iCoup;
        private int series_j1;
        private int series_j2;
        private bool bJoueur;

        public Jeu(Form1 f)
        {
            Tableau = new int[6][];
            for (int i = 0; i < Tableau.Length; i++)
            {
                Tableau[i] = new int[7];
            }
            ListJoueur = new List<Joueur>();
            Recommancer();
            form = f;
        }

        public void DefinitionJoueur(Joueur j1, Joueur j2)
        {
            listJoueur.Add(j1);
            listJoueur.Add(j2);
        }
        public void CommencementDuJEu()
        {
            try
            {
                Humain JoueurT = (Humain)listJoueur[0];
            }
            catch
            {
                listJoueur[0].DemandeCoup();
            }
        }
        public void CoupHumain(int i)
        {
            listJoueur[0].dernierCoup = i;
        }
        public void ProchainJoueur()
        {
            Jouer(listJoueur[0].dernierCoup);
            form.AppelleAffichage(listJoueur[0].dernierCoup);
            int i;
            if((i = gagnant())!=0)
            {
                if(i==1||i==2)
                {
                    form.AfficheGagnant(listJoueur[i-1]);
                }
                else
                {

                }
            }

            listJoueur.Add(listJoueur[0]);
            listJoueur.Remove(listJoueur[0]);
            if (!listJoueur[0].isHumain)
            {
                listJoueur[0].DemandeCoup();
            }
        }
        public int I1
        {
            get
            {
                return i1;
            }
            set
            {
                i1 = value;
            }
        }
        public int I2
        {
            get
            {
                return i2;
            }
            set
            {
                i2 = value;
            }
        }
        public int I3
        {
            get
            {
                return i3;
            }
            set
            {
                i3 = value;
            }
        }
        public int I4
        {
            get
            {
                return i4;
            }
            set
            {
                i4 = value;
            }
        }
        public int I5
        {
            get
            {
                return i5;
            }
            set
            {
                i5 = value;
            }
        }
        public int I6
        {
            get
            {
                return i6;
            }
            set
            {
                i6 = value;
            }
        }
        public int I7
        {
            get
            {
                return i7;
            }
            set
            {
                i7=value;
            }
        }
        public int Coup
        {
            get
            {
                return iCoup;
            }
        }
        public int[][] tableau
        {
            get
            {
                return Tableau;
            }
        }
        public void Recommancer()
        {
            for (int i = 0; i < Tableau.Length; i++)
            {
                for (int j = 0; j < Tableau[i].Length; j++)
                {
                    Tableau[i][j] = 0;
                }
            }
            i1 = 0;
            i2 = 0;
            i3 = 0;
            i4 = 0;
            i5 = 0;
            i6 = 0;
            i7 = 0;
            iCoup = 0;
            series_j1 = 0;
            series_j2 = 0;
            bJoueur = true;
        }
        public bool Jouer(int i)
        {
            int J=0;
            if(bJoueur)
            {
                J = 1;
                bJoueur = false;
            }
            else
            {
                J = 2;
                bJoueur = true;
            }
            try
            {
                switch (i)
                {
                    case 0: Tableau[i1][i] = J;
                        break;
                    case 1: Tableau[i2][i] = J;
                        break;
                    case 2: Tableau[i3][i] = J;
                        break;
                    case 3: Tableau[i4][i] = J;
                        break;
                    case 4: Tableau[i5][i] = J;
                        break;
                    case 5: Tableau[i6][i] = J;
                        break;
                    case 6: Tableau[i7][i] = J;
                        break;
                }
                iCoup++;
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                bJoueur = !bJoueur;
                return false;
            }
            
        }
        public int gagnant()
        {
            int i, j;
            series_j1 = 0;
            series_j2=0;

            nb_series(4);

            if(series_j1>=1)
            {
                return 1;
            }
            else if(series_j2>=1)
            {
                return 2;
            }
            else
            {
                //Si le jeu n'est pas fini et que personne n'a gagné, on renvoie 0
                for (i = 0; i < 6; i++)
                {
                    for (j = 0; j < 7; j++)
                    {
                        if (Tableau[i][j] == 0)
                        {
                            return 0;
                        }
                    }
                }
            }
            //Si le jeu est fini et que personne n'a gagné, on renvoie 3
            return 3;
        }
        public bool Joueur
        {
            get
            {
                return bJoueur;
            }
        }
        public void nb_series(int n)
        {
            int compteur1, compteur2, i, j;

            series_j1 = 0;
            series_j2 = 0;

            compteur1 = 0;
            compteur2 = 0;
            //diagonal montante
            //première
            testDiagomontante(n, 2,0,5,3);
            //deuzieme
            testDiagomontante(n, 1,0,5,4);
            //troisieme
            testDiagomontante(n, 0,0,5,5);
            //quatrième
            testDiagomontante(n, 0, 1, 5, 6);
            //cinquième
            testDiagomontante(n, 0, 2, 4, 6);
            //sixième
            testDiagomontante(n, 0, 3, 3, 6);

            //diagonal descendante
            //première
            testDiagoDescendante(n, 3, 0, 0, 3);

            //deuzème
            testDiagoDescendante(n, 4, 0, 0, 4);

            //troisième
            testDiagoDescendante(n, 5, 0, 0, 5);

            //quatrième
            testDiagoDescendante(n, 5, 1, 6, 0);

            //cinquième
            testDiagoDescendante(n, 5, 2, 6, 1);

            //sixième
            testDiagoDescendante(n, 5, 3, 6, 2);


            compteur1 = 0;
            compteur2 = 0;
           

            for (i = 0; i < Tableau.Length; i++)
            {
                compteur1 = 0;
                compteur2 = 0;
                //testLigne
                for (j=0; j< Tableau[0].Length; j++)
                {
                    if(Tableau[i][j]==1)
                    {
                        compteur2 = 0;
                        compteur1++;
                        if(compteur1==n)
                        {
                            series_j1++;
                        }
                    }
                    else if(Tableau[i][j]==2)
                    {
                        compteur1 = 0;
                        compteur2++;
                        if(compteur2==n)
                        {
                            series_j2++;
                        }
                    }

                }
                compteur1 = 0;
                compteur2 = 0;
                //testColonne
                for ( j = 0; j < Tableau.Length; j++)
                {
                     if(Tableau[j][i]==1)
                    {
                        compteur2 = 0;
                        compteur1++;
                        if(compteur1==n)
                        {
                            series_j1++;
                        }
                    }
                    else if(Tableau[j][i]==2)
                    {
                        compteur1 = 0;
                        compteur2++;
                        if(compteur2==n)
                        {
                            series_j2++;
                        }
                    }
                }

            }


        }
        private void testDiagomontante(int n, int a, int b, int c, int d)
        {
            int compteur1 = 0;
            int compteur2 = 0;
            while(a<=c&&b<=d)
            {
                
                if(Tableau[a][b]==1)
                {
                    compteur2 = 0;
                    compteur1++;
                    if(compteur1==n)
                    {
                        series_j1++;
                    }
                }
                else if(Tableau[a][b]==2)
                {
                    compteur1 = 0;
                    compteur2++;
                    if (compteur2 == n)
                    {
                        series_j2++;
                    }
                }
                a++;
                b++;
           }
        }
        private void testDiagoDescendante(int n,int a,int b,int c,int d)
        {
            int compteur1 = 0;
            int compteur2 = 0;

            while (a>=d&&b<=c)
            {
                if(Tableau[a][b]==1)
                {
                    compteur2 = 0;
                    compteur1++;
                    if(compteur1==n)
                    {
                        series_j1++;
                    }
                }
                else if (Tableau[a][b] == 2)
                {
                    compteur1 = 0;
                    compteur2++;
                    if (compteur2 == n)
                    {
                        series_j2++;
                    }
                }
                a--;
                b++;
            }
        }
        public List<Joueur> listJoueur
        {
            get
            {
                return ListJoueur;
            }
        }


        

      


    }
}
