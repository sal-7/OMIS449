//OMIS 449                     Spring 2019

//Programmer: Faisal Alharbi,  Z-ID 1748509
//Programmer: Bryce Frank,     Z-ID 1733433

//Programming Problem Chapter 10 Exersice #10.3: Completing the Computer Science student application
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void getHoursButton_Click(object sender, EventArgs e)
        {
            //Variables to hold input
            string name, id, track;

            //Get the student's name and ID
            name = nameTextBox.Text;
            id = idTextBox.Text;

            //Get the student's academic track
            if (infoSystemsRadioButton.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Software Engineering";
            }

            //Create a CompSciStudent object
            CompSciStudent csStudent = new CompSciStudent(name, id, track);

            //DIsplay the student's required hours
            requiredHoursLabel.Text = csStudent.RequiredHours.ToString("n1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
