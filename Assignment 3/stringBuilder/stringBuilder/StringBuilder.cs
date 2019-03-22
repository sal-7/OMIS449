//OMIS 449                     Spring 2019

//Programmer: Faisal Alharbi,  Z-ID 1748509
//Programmer: Bryce Frank,     Z-ID 1733433

//Programming Problem 3-47: The Sentence Builder form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stringBuilder
{
    public partial class StringBuilder : Form
    {
        public StringBuilder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AButton_Click(object sender, EventArgs e)
        {
           if(sender is Button)
            {
                Button clickedButton = (Button)sender;
                String text = clickedButton.Text;

                if(text.Equals("(Space)"))
                    result.Text = result.Text + " ";
                else
                    result.Text = result.Text + text;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
