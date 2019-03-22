//OMIS 449                     Spring 2019

//Programmer: Faisal Alharbi,  Z-ID 1748509
//Programmer: Bryce Frank,     Z-ID 1733433

//Programming Problem Chapter 6 Exersice #4: #4 Calories from Fat and Carbohydrates
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cals_from_Fat_and_Carbs_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Exits the program
        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //passes the string from the carbInput box, converts it, and does the necessary math, returns string
        private string carbCalc(string c)
        {
            //calculate carb
            if (c is string && int.TryParse(c.ToString(), out int carbs))
            {
                c = (carbs *= 4).ToString();
            }

            return c;
        }

        //passes the string from the fatInput box, converts it, and does the necessary math, returns string
        private string fatCalc(string f)
        {
            //calculate fat
            if (f is string && int.TryParse(f.ToString(), out int fat))
            {
                f = (fat *= 9).ToString();
            }

            return f;
        }

        //Calls on the two methods above with the values from the input boxes being passed,
        //then it outputs those values to the output boxes
        private void calcButton_Click(object sender, EventArgs e)
        {
            string fats;
            string carbohydrates;

            //take input 
            fats = fatInput.Text;
            carbohydrates = carbInput.Text;

            //if input fields are empty
            if(fats ==""  || carbohydrates =="")
            {
                MessageBox.Show("Input fields cannot be empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

           // call methods to calculate
            fats = fatCalc(fats);
            carbohydrates = carbCalc(carbohydrates);

            //set the output
            fatOutput.Text = fats;
            carbOutput.Text = carbohydrates;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear the fields input and output
            fatOutput.Text = "";
            carbOutput.Text = "";
            fatInput.Text = "";
            carbInput.Text = "";

        }
    }
}
