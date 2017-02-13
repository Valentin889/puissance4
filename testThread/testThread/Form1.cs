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

namespace testThread
{
    public partial class Form1 : Form
    {
        private attente a1;
        public Form1()
        {
            InitializeComponent();
            a1 = new attente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ThreadProcSafe));
            t.IsBackground = true;
            t.Start();
        }
        private void ThreadProcSafe()
        {
            MessageBox.Show("attente");
            a1.MethodWait();
            MessageBox.Show("fin attente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1.MethodeRelease();
        }
    }
}
