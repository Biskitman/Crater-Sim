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
        double Gravity = 9.81;
        double DiameterP;
        double DensityPr;
        double DensityGr;
        double VelocityP;
        int AngleP;
        double Result;

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
            // Progress Bar stuff which isnt important, i just like it
            progressBar1.Value = 0;
            for (int i = 1; i < 101; i++)
            {
                System.Threading.Thread.Sleep(5);
                progressBar1.PerformStep();
            }
            //End of progress bar stuff

           
            // Converts all the users inputs into variables
            DiameterP = Convert.ToDouble(Diameter.Text);
            DensityPr = Convert.ToDouble(DensityP.Text);
            DensityGr = Convert.ToDouble(DensityG.Text);
            VelocityP = Convert.ToDouble(Velocity.Text);
            AngleP = Convert.ToInt32(Angle.Text);

            // Uses the Dtc = Equation from the white paper, think its the diameter but no clue, also this equation gets a different result to a calculator, double check it
            Result = (1.161 * Math.Pow((DensityPr / DensityGr), (1 / 3))) * Math.Pow(DiameterP, 0.78) * Math.Pow(VelocityP,0.44) * Math.Pow(Gravity,-0.22)* Math.Pow((Math.Sin(AngleP)),(1 / 3));

           
            Crater_Diameter.Text = Convert.ToString(Result);
        }
    }
}
