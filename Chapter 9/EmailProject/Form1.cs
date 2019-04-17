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

namespace EmailProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //list for storing class objects
        List<PersonEntry> Entries = new List<PersonEntry>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //stream reader for loading emails list file
            StreamReader File = new StreamReader("EmailList.txt");

            //variables for processing
            string s;

            string name = "";
            string email = "";
            string phone = "";
            int i;

            //while loop that interates until all lines are read in from file
            while ((s = File.ReadLine()) != null)
            {
                i = 0;
                //splits each line at the comma
                char delim = ',';

                string[] Lines = s.Split(delim);

                //stores vales into string variables
                foreach (var substring in Lines)
                {
                    if (i == 0)
                    {
                        name = substring;
                    }

                    else if (i ==1)
                    {
                        email = substring;
                    }

                    else
                    {
                        phone = substring;
                    }

                    i = i + 1;
                }

                //creates new class object and stores into list
                PersonEntry Person = new PersonEntry(name, email, phone);
                Entries.Add(Person);

                People.Items.Add(name);
            }
        }

        //controls the click function for listbox and displays details stored in class objects to labels in form 2
        private void People_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = People.SelectedIndex;

            MoreDetails AdditionalInfo = new MoreDetails();

            AdditionalInfo.displayNameLabel.Text = Entries[index].Name.ToString();
            AdditionalInfo.displayEmailLabel.Text = Entries[index].Email.ToString();
            AdditionalInfo.displayPhoneLabel.Text = Entries[index].Phone.ToString();

            AdditionalInfo.Show();
        }
    }
}
