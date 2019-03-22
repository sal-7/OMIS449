//OMIS 449                     Spring 2019

//Programmer: Faisal Alharbi,  Z-ID 1748509
//Programmer: Bryce Frank,     Z-ID 1733433

//Programming Problem Chapter 5 Exersice #10: Addition Tutor
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_Tutor_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This closes the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //compares the input answer to the sum of the two randomly generated integers
        private void checkButton_Click(object sender, EventArgs e)
        {
            //will stop and prompt the user to press the generate button before checking their answer
            //other wise will display dafault "???" values
            try
            {
                //temp values to store random number generated to labels by generate button
                int num1 = int.Parse(lblNum1.Text);
                int num2 = int.Parse(lblNum2.Text);
                //validates and checks if sum of temp values is equal to the answer given by user, also creates ans varible for testing
                if (int.TryParse(ansInput.Text, out int ans))
                {
                    //test the answer that is given
                    if (ans == num1 + num2)
                    {
                        MessageBox.Show("The answer is correct!");
                    }
                    //this message appears if the answer isn't correct
                    else
                        MessageBox.Show("The answer is not correct!");
                }
                //default error message
                else
                    MessageBox.Show("only valid integer.");
            }

            catch
            {
                MessageBox.Show("Please click on the 'generate' before checking your answer.");
            }
        }

        //generates values and stores then into the two labels for user, also clears the answer textbox
        private void genButton_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;
            //creates a random number generator
            Random rnd = new Random();
            //stores random numbers 100-500 into two temp varibles
            number1 = rnd.Next(100, 500);
            number2 = rnd.Next(100, 500);
            //converts and displays temp values to user
            lblNum1.Text = number1.ToString();
            lblNum2.Text = number2.ToString();
            //empties answer textbox
            ansInput.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
