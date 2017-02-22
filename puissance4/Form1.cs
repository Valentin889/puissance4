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
           foreach(PictureBox p in tableLayoutPanel.Controls)
            {
                if(p.Tag.ToString()==Convert.ToString(i) + Convert.ToString(jeu.NombreParColonne[i]+1))
                {
                    Affichage(p);
                }
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
            foreach (PictureBox p in tableLayoutPanel.Controls)
            {
                 p.BackColor = Color.White;
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

            for(int i=tableLayoutPanel.RowCount; i>0;i--)
            {
                for(int j=0; j<tableLayoutPanel.ColumnCount;j++)
                {
                    PictureBox image = new PictureBox();
                    image.Size = new Size(74, 34);
                    image.Tag = Convert.ToString(j +""+ i);
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
