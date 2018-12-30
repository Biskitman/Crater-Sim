using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crater_Sim
{
    public partial class Form1 : Form
    {
        string x;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 1; i < 101; i++)
            {
                System.Threading.Thread.Sleep(5);
                progressBar1.PerformStep();
            }

            
            Crater_Diameter.Text = Diameter.Text;

        }
    }
}
