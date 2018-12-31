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
        bool Debug = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Debugging option
            const string message = "Are you sure that you would like to enable debugging?";
            const string caption = "Debug Mode";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Debug = true;
            }
            //
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

            Crater_Diameter.Text = "";
            //End of progress bar stuff

           
            // Converts all the users inputs into variables
            DiameterP = Convert.ToDouble(Diameter.Text);
            DensityPr = Convert.ToDouble(DensityP.Text);
            DensityGr = Convert.ToDouble(DensityG.Text);
            VelocityP = Convert.ToDouble(Velocity.Text);
            AngleP = Convert.ToInt32(Angle.Text);

            //DEBUGGING
            if (Debug == true)
            {

                double a = (1.161 * (Math.Pow((DensityPr / DensityGr), (1 / 3.0))));
                MessageBox.Show(Convert.ToString(a),"Density");

                double b = (Math.Pow(DiameterP, 0.78));
                MessageBox.Show(Convert.ToString(b), "Diameter");

                double c = (Math.Pow(VelocityP, 0.44));
                MessageBox.Show(Convert.ToString(c), "Velocity");

                double d = (Math.Pow(Gravity, -0.22));
                MessageBox.Show(Convert.ToString(d), "Gravity");

                double f = (Math.Pow((Math.Sin(AngleP)), (1/3.0)));
                MessageBox.Show(Convert.ToString(f), "Angle");

            }


            // Uses the Dtc = Equation from the white paper, think its the diameter but no clue, also this equation gets a different result to a calculator, double check it
            Result = (1.161 * Math.Pow((DensityPr / DensityGr), (1/3.0))) * Math.Pow(DiameterP, 0.78) * Math.Pow(VelocityP, 0.44) * Math.Pow(Gravity, -0.22) * Math.Pow((Math.Sin(AngleP)),(1/3.0));
            Result = Math.Round(Result, 0);

            Crater_Diameter.Text = Convert.ToString(Result) + " km";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diameter.Text = "1000";
            DensityP.Text = "3000";
            DensityG.Text = "2500";
            Velocity.Text = "50000";
            Angle.Text = "90";
        }
    }
}
