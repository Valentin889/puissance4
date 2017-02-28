using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using puissance4;

namespace UnitTestProject1
{
    [TestClass]
    public class TestIa
    {
        [TestMethod]
        public void EvaluationColonne1()
        {
            IA ia = new IA(new Jeu(new Form1()), 2, 1, 2);
            int[][] tab = new int[6][];
            tab[0] = new int[7];
            tab[1] = new int[7];
            tab[2] = new int[7];
            tab[3] = new int[7];
            tab[4] = new int[7];
            tab[5] = new int[7];

            tab[0][2] = 1;
            tab[1][2] = 1;
            tab[2][2] = 1;

            tab[0][4] = 2;
            tab[1][4] = 2;
            tab[2][4] = 2;

            int i = ia.eval(tab);

            Assert.AreEqual(0, i);
        }

        [TestMethod]
        public void EvaluationLigne1()
        {
            IA ia = new IA(new Jeu(new Form1()), 2, 1, 2);
            int[][] tab = new int[6][];
            tab[0] = new int[7];
            tab[1] = new int[7];
            tab[2] = new int[7];
            tab[3] = new int[7];
            tab[4] = new int[7];
            tab[5] = new int[7];

            tab[0][2] = 1;
            tab[0][3] = 1;
            tab[0][4] = 1;

            tab[1][2] = 2;
            tab[1][3] = 2;
            tab[1][4] = 2;

            int i = ia.eval(tab);
            Assert.AreEqual(-9, i);
        }

        [TestMethod]
        public void EvaluationDiagonalMontante1()
        {
            IA ia = new IA(new Jeu(new Form1()), 2, 1, 2);
            int[][] tab = new int[6][];
            tab[0] = new int[7];
            tab[1] = new int[7];
            tab[2] = new int[7];
            tab[3] = new int[7];
            tab[4] = new int[7];
            tab[5] = new int[7];

            tab[0][0] = 1;
            tab[1][1] = 1;
            tab[2][2] = 1;

            tab[0][3] = 2;
            tab[1][4] = 2;
            tab[2][5] = 2;

            int i = ia.eval(tab);

            Assert.AreEqual(-4, i);

        }
        [TestMethod]
        public void EvaluationDiagonalDescendante1()
        {
            IA ia = new IA(new Jeu(new Form1()), 2, 1, 2);
            int[][] tab = new int[6][];
            tab[0] = new int[7];
            tab[1] = new int[7];
            tab[2] = new int[7];
            tab[3] = new int[7];
            tab[4] = new int[7];
            tab[5] = new int[7];

            tab[3][0] = 1;
            tab[2][1] = 1;
            tab[1][2] = 1;

            tab[5][3] = 2;
            tab[4][4] = 2;
            tab[3][5] = 2;

            int i = ia.eval(tab);
            Assert.AreEqual(-2, i);
        }

    }
}
