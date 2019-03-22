//OMIS 449                     Spring 2019

//Programmer: Faisal Alharbi,  Z-ID 1748509
//Programmer: Bryce Frank,     Z-ID 1733433

//Programming Problem Chapter 4 Exersice #10 : Fat Percentage Calculator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fatCalories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // this is the calculation button
        private void button1_Click(object sender, EventArgs e)
        {
            int totalCaloriesValue = Convert.ToInt32(totalCalories.Text);
            int numFatGramsValue = Convert.ToInt32(numberFatGrams.Text);
           
            float caloriesFromFat = numFatGramsValue * 9;

            if (totalCaloriesValue < 0 || numFatGramsValue< 0 || caloriesFromFat > totalCaloriesValue){
         // these are the error/alert messages
                string message = "Either calories or Number of fat grams entered incorrectly";
                string caption = "Error Detected in Input";
                MessageBox.Show(message, caption);
            }
            else
            {
                float percentageOfCalories = (caloriesFromFat / totalCaloriesValue) * 100;
                String lowFat="";
                if(lowFatCheckbox.Checked){
                    if (percentageOfCalories < 30)
                        // this is the low fat food option
                        lowFat = " (a low-fat food)";

                }
               
                resultLbl.Text = "Percentage of calories from fat: " + percentageOfCalories.ToString() + "%" + lowFat;
            }
        }
        // this is the clear button
        private void button2_Click(object sender, EventArgs e)
        {
            resultLbl.Text = "";
            numberFatGrams.Text = "";
            totalCalories.Text = "";
            lowFatCheckbox.Checked = false;
        }
    }
}
