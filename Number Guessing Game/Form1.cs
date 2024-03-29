﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Guessing_Game
{
    public partial class numguessgame : Form
    { 
        //Estimated that it will take about 2 hours to complete 
        //Actual completion time =  4 hours


        public numguessgame()
        {
            InitializeComponent();
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numbox.ReadOnly = true;

            //Made so integer cannot be put in due to user input.
        }

        private void startbut_Click(object sender, EventArgs e)
        {
            
            Random generator = new Random();
            int randomvalue = generator.Next(1,11);
            int x = randomvalue;
            numbox.Text = (x.ToString());

            //Generates a random number between 1 and 10 inside textbox.
            
           
        }

        private void lowbut_Click(object sender, EventArgs e)
        {
            int min = 1;
            int max = 10;
            string guess = numbox.Text;
            int y = 1;
            int x = Int32.Parse(numbox.Text);

            Random generator = new Random();
            int randomvalue = generator.Next(min,max);




            if (x != y && x < max)
            {
                numbox.Text = Convert.ToString(randomvalue);

            }

            else 
            {
                MessageBox.Show("Error, number cannot be lower than 1");
            }

            //Guesses random number lower than inital number. If number last number is 1 and lower is selected, show error message.


        }

        private void highbut_Click(object sender, EventArgs e)
        {
            int min = 1;
            int max = 10;
            string guess = numbox.Text;
            int y = 10;

            Random generator = new Random();
            int randomvalue = generator.Next(min,max);
            int x = Int32.Parse(numbox.Text);


            if (x != y && x < max)
            {
                numbox.Text = Convert.ToString(randomvalue);

            }

            else
            {
                MessageBox.Show("Error, number cannot be higher than 10");
            }

            //Guesses random number higher than inital number. If last number was 10 and higher is selected, show error message


        }

        private void yesbut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for playing!");
            numbox.Clear();

            // Shows"thank you" message and clears textbox of integer, game can be played agian by pressing "Start".

        }
    }
}
