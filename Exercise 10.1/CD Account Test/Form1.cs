﻿//OMIS 449                     Spring 2019

//Programmer: Faisal Alharbi,  Z-ID 1748509
//Programmer: Bryce Frank,     Z-ID 1733433

//Programming Problem Chapter 10 Exersice #10.1 : Creating and testing the SavingsAccount and CDAccount classes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CD_Account_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The GetCDData method accepts a CDAccount object
        //as an argument. It assigns the data entered by
        //the user to the object's properties

        private void GetCDData(CDAccount account)
        {
            //Temporary variables to hold interest rate and balance
            decimal interestRate;
            decimal balance;

            //Get the account number
            account.AccountNumber = accountNumberTextBox.Text;

            //Get the maturity date
            account.MaturityDate = maturityDateTextBox.Text;

            //Get the interest rate
            if (decimal.TryParse(interestRateTextBox.Text, out interestRate))
            {
                account.InterestRate = interestRate;

                //Get the Balance
                if (decimal.TryParse(balanceTextBox.Text, out balance))
                {
                    account.Balance = balance;
                }
                else
                {
                    //Display an error message
                    MessageBox.Show("Invalid Balance");
                }
            }
            else
            {
                //Display an error message
                MessageBox.Show("Invalid interest rate");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //Create a CDAccount object
            CDAccount myAccount = new CDAccount();
            //Get the CD account data
            GetCDData(myAccount);
            //Display the CD account data
            accountNumberLabel.Text = myAccount.AccountNumber;
            interestRateLabel.Text = myAccount.InterestRate.ToString("n2");
            balanceLabel.Text = myAccount.Balance.ToString("c"); ;
            maturityDateLabel.Text = myAccount.MaturityDate;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
