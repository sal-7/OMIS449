using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumSeating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //shutting down the application
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //clearing all the textboxes
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            totalTextBox.Clear();
            revenueATextbox.Clear();
            revenueBTextbox.Clear();
            revenueCTextbox.Clear();
        }

        private void revenue_Click(object sender, EventArgs e)
        {
            //get the input value from textboxes
            int ticketsA = Int32.Parse(textBoxA.Text);
            int ticketsB = Int32.Parse(textBoxB.Text);
            int ticketsC = Int32.Parse(textBoxC.Text);

            //CALCULATE REVENUE
            int revenueA = 15 * ticketsA;
            int revenueB = 12 * ticketsB;
            int revenueC = 9 * ticketsC;
            int total = revenueA + revenueB + revenueC;

            //DISPLAY CURRENCY SYMBOL 
            revenueATextbox.Text = revenueA.ToString("C0");
            revenueBTextbox.Text =  revenueB.ToString("C0");
            revenueCTextbox.Text = revenueC.ToString("C0");
            totalTextBox.Text = total.ToString("C0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
