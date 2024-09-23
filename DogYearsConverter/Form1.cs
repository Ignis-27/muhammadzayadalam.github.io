/// <summary>
/// Muhammad Zayad Alam 
/// 100938343
/// Lab 1 [ Dog year converter ]
/// 
/// </summary>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DogYearsConverter
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //initializing variables
            int humanYears = (int)numericUpDown1.Value;
            int dogYears;
            
            //updating the gui 
            infoLabel.Visible = true;



            //if user didn't select valid age 
            if (humanYears == 0)
            {
                errorTooltip.Show("you must choose the value of year ", numericUpDown1);
                infoLabel.Visible = false;
                dogYearTextBox.Text = " ";
                pictureBox1.Image = null;
            }
            
            //if the dog is a puppy 
            else if ( humanYears == 1)
            {
                dogYears = 10 * humanYears;
                dogYearTextBox.Text = dogYears.ToString();
                pictureBox1.Image = Properties.Resources.puppy;
                infoLabel.Text = "Your dog is a puppy!!";


            }
            //if the dog ifs fully grown 
            else if (humanYears <= 7)
            {
                dogYears = 4 * humanYears + 12;
                dogYearTextBox.Text = dogYears.ToString();
                pictureBox1.Image = Properties.Resources.grown;
                infoLabel.Text = "Your dog is fully grown!!";

            }

            //if dog is a senior
            else
            {
                dogYears = 4 * humanYears + 12;
                dogYearTextBox.Text = dogYears.ToString();
                pictureBox1.Image = Properties.Resources.senior;
                infoLabel.Text = "Your dog is a senior!!";
            }

            

            
        }

        /// <summary>
        /// Resets the value to 0 
        /// resets the image box
        /// resets the infolabel as well 
        /// </summary>
      
        private void resetButton_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            dogYearTextBox.Text = " ";
            pictureBox1.Image = null;  
            infoLabel.Visible = false;  
        }
    }
}
