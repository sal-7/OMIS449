//OMIS 449                     Spring 2019

//Programmer: Faisal Alharbi,  Z-ID 1748509
//Programmer: Bryce Frank,     Z-ID 1733433

//Programming Problem Chapter 5 Exersice #10: Distance File
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator_to_File_Project
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

            //IF statement attempts to convert textbox inputs to ints (else statement is default error message)
            if (int.TryParse(mphInput.Text, out speed) && int.TryParse(hoursInput.Text, out hours))
            {
                //try statement exist in this context due to the nature of working with files in c#
                //will attempt to capture and display an error message if creation of file is not possible
                try
                {
                    //creates a streamwriter command and then sets it equal to a command to create textfile
                    StreamWriter outputFile;
                    outputFile = File.CreateText("Distance.txt");
                    //For loop increments index by 1 and outputs the speed(mph) multiplies by the position value of the index
                    for (int i = 1; i <= hours; i++)
                    {
                        //same calculation as previous project, takes index (hours) and multiplies it by speed from input box
                        distance = i * speed;
                        //writes the line in the created file the same way we did in the listbx from the previous assignment
                        outputFile.WriteLine("After hour " + i + " the distance is " + distance + " miles.");
                    }

                    //closes the file
                    outputFile.Close();
                    //confirms the file was created
                    MessageBox.Show("File successfully created!");
                }

                //catch statement intercepts error, displays defauly message, and then the error message itself
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem creating the file: " + ex.Message);
                }

            }

            else
                MessageBox.Show("Invalid Data Was Entered");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
