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
        private TableLayoutPanel tableLayoutPanel;
        public Form1()
        {
            InitializeComponent();
            jeu = new Jeu(this);
            iProfondeur = 2;
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Location = new Point(13, 76);
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoScroll = true;
            Controls.Add(tableLayoutPanel);
            CreationConteneur();

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
                    switch (jeu.NombreParColonne[i])
                    {
                        case 0: Affichage(pct0);
                            break;
                        case 1: Affichage(pct10);
                            break;
                        case 2: Affichage(pct20);
                            break;
                        case 3: Affichage(pct30);
                            break;
                        case 4: Affichage(pct40);
                            break;
                        case 5: Affichage(pct50);
                            break;
                    }
                    break;
                case 1: 
                switch (jeu.NombreParColonne[i])
                    {
                        case 0: Affichage(pct1);
                            break;
                        case 1: Affichage(pct11);
                            break;
                        case 2: Affichage(pct21);
                            break;
                        case 3: Affichage(pct31);
                            break;
                        case 4: Affichage(pct41);
                            break;
                        case 5: Affichage(pct51);
                            break;
                    }
                    break;
                case 2: 
                switch (jeu.NombreParColonne[2])
                    {
                        case 0: Affichage(pct2);
                            break;
                        case 1: Affichage(pct12);
                            break;
                        case 2: Affichage(pct22);
                            break;
                        case 3: Affichage(pct32);
                            break;
                        case 4: Affichage(pct42);
                            break;
                        case 5: Affichage(pct52);
                            break;
                       
                    }
                    break;
                case 3: 
                switch (jeu.NombreParColonne[i])
                    {
                        case 0: Affichage(pct3);
                            break;
                        case 1: Affichage(pct13);
                            break;
                        case 2: Affichage(pct23);
                            break;
                        case 3: Affichage(pct33);
                            break;
                        case 4: Affichage(pct43);
                            break;
                        case 5: Affichage(pct53);
                            break;
                       
                    }
                    break;
                case 4: 
                switch (jeu.NombreParColonne[i])
                    {
                        case 0: Affichage(pct4);
                            break;
                        case 1: Affichage(pct14);
                            break;
                        case 2: Affichage(pct24);
                            break;
                        case 3: Affichage(pct34);
                            break;
                        case 4: Affichage(pct44);
                            break;
                        case 5: Affichage(pct54);
                            break;
                       
                    }
                    break;
                case 5: 
                switch (jeu.NombreParColonne[i])
                    {
                        case 0: Affichage(pct5);
                            break;
                        case 1: Affichage(pct15);
                            break;
                        case 2: Affichage(pct25);
                            break;
                        case 3: Affichage(pct35);
                            break;
                        case 4: Affichage(pct45);
                            break;
                        case 5: Affichage(pct55);
                            break;
                      
                    }
                    break;
                case 6: 
                    switch (jeu.NombreParColonne[i])
                    {
                        case 0: Affichage(pct6);
                            break;
                        case 1: Affichage(pct16);
                            break;
                        case 2: Affichage(pct26);
                            break;
                        case 3: Affichage(pct36);
                            break;
                        case 4: Affichage(pct46);
                            break;
                        case 5: Affichage(pct56);
                            break;
                      
                    }
                    break;
            }
            jeu.NombreParColonne[i]++;
        }
        private void Affichage(PictureBox p)
        {
            if (jeu.Joueur)
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
            foreach (Control p in tableLayoutPanel.Controls)
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
                    jeu.DefinitionJoueur(new IA(jeu,iProfondeur,1,2), new Humain(2));
                    break; 
                case "JVIA":
                    jeu.DefinitionJoueur(new Humain(1), new IA(jeu, iProfondeur,2,1));
                    break; 
                case "IAVIA":
                    jeu.DefinitionJoueur(new IA(jeu, iProfondeur+1,1,2), new IA(jeu, iProfondeur,2,1));
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
        private void CreationConteneur()
        {
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.ColumnCount = jeu.tableau[0].Length;
            tableLayoutPanel.RowCount = jeu.tableau.Length;

            for(int i=0; i<tableLayoutPanel.ColumnCount;i++)
            {
                for(int j=0; j<tableLayoutPanel.RowCount;j++)
                {
                    PictureBox image = new PictureBox();
                    image.Size = new Size(74, 34);
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    tableLayoutPanel.Controls.Add(image);
                }
            }

            

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
