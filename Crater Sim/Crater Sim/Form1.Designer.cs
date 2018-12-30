namespace Crater_Sim
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.Diameter = new System.Windows.Forms.TextBox();
            this.DensityP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DensityG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Velocity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Crater_Diameter = new System.Windows.Forms.Label();
            this.Crater_Depth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 288);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(399, 32);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Diameter of Projectile";
            // 
            // Button
            // 
            this.Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Button.Location = new System.Drawing.Point(206, 167);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(174, 80);
            this.Button.TabIndex = 2;
            this.Button.Text = "CALCULATE";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Diameter
            // 
            this.Diameter.Location = new System.Drawing.Point(16, 38);
            this.Diameter.Name = "Diameter";
            this.Diameter.Size = new System.Drawing.Size(100, 20);
            this.Diameter.TabIndex = 3;
            // 
            // DensityP
            // 
            this.DensityP.Location = new System.Drawing.Point(16, 91);
            this.DensityP.Name = "DensityP";
            this.DensityP.Size = new System.Drawing.Size(100, 20);
            this.DensityP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Density of Projectile";
            // 
            // DensityG
            // 
            this.DensityG.Location = new System.Drawing.Point(16, 143);
            this.DensityG.Name = "DensityG";
            this.DensityG.Size = new System.Drawing.Size(100, 20);
            this.DensityG.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input Density of Ground";
            // 
            // Velocity
            // 
            this.Velocity.Location = new System.Drawing.Point(16, 195);
            this.Velocity.Name = "Velocity";
            this.Velocity.Size = new System.Drawing.Size(100, 20);
            this.Velocity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Input Velocity of Projectile";
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(15, 250);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(100, 20);
            this.Angle.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Input Angle of Projectile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Crater Diameter";
            // 
            // Crater_Diameter
            // 
            this.Crater_Diameter.AutoSize = true;
            this.Crater_Diameter.Location = new System.Drawing.Point(279, 61);
            this.Crater_Diameter.Name = "Crater_Diameter";
            this.Crater_Diameter.Size = new System.Drawing.Size(22, 13);
            this.Crater_Diameter.TabIndex = 13;
            this.Crater_Diameter.Text = "-----";
            // 
            // Crater_Depth
            // 
            this.Crater_Depth.AutoSize = true;
            this.Crater_Depth.Location = new System.Drawing.Point(279, 130);
            this.Crater_Depth.Name = "Crater_Depth";
            this.Crater_Depth.Size = new System.Drawing.Size(22, 13);
            this.Crater_Depth.TabIndex = 15;
            this.Crater_Depth.Text = "-----";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Crater Depth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 330);
            this.Controls.Add(this.Crater_Depth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Crater_Diameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Velocity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DensityG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DensityP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Diameter);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Crater Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox Diameter;
        private System.Windows.Forms.TextBox DensityP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DensityG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Velocity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Crater_Diameter;
        private System.Windows.Forms.Label Crater_Depth;
        private System.Windows.Forms.Label label8;
    }
}

