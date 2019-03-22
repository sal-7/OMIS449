//OMIS 449                     Spring 2019

//Programmer: Faisal Alharbi,  Z-ID 1748509
//Programmer: Bryce Frank,     Z-ID 1733433

//Programming Problem Chapter 5 Exersice #1: Distance Calculator Project
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //Placeholder variables to calculate distance via textbox inputs
            int speed = 0;
            int hours = 0;
            int distance = 0;

            hoursLB.Items.Clear();

            //IF statement attempts to convert textbox inputs to ints (else statement is default error message)
            if (int.TryParse(mphInput.Text, out speed) && int.TryParse(hoursInput.Text, out hours))
                {
                //For loop increments index by 1 and outputs the speed(mph) multiplies by the position value of the index
                for (int i = 1; i <= hours; i++)
                {
                    //first loop i equals 1 times speed (example: 60mph), output would be distance = 60
                    //second loop using same input values would be 120, i would equal 2, (2 * 60) = 120
                    distance = i * speed;
                    hoursLB.Items.Add("After hour " + i + " the distance is " + distance + " miles.");
                }
            }

            else
                MessageBox.Show("Invalid Data Was Entered");
        }

        //standard close
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
