//OMIS 449                     Spring 2019

//Programmer: Faisal Alharbi,  Z-ID 1748509
//Programmer: Bryce Frank,     Z-ID 1733433

//Programming Problem Chapter 6 Exersice #5 Joe's Automotive
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joes_Automotive_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Clear Button Methods
        private void ClearOilLube()
        {
            oilChangeCB.Checked = false;
            lubeJobCB.Checked = false;
        }
        //clear flush
        private void ClearFlushes()
        {
            radRushCB.Checked = false;
            transRushCB.Checked = false;
        }

        //clear misc charges
        private void ClearMisc()
        {
            inspCB.Checked = false;
            repMufCB.Checked = false;
            tireRotCB.Checked = false;
        }

        //clear input fields
        private void ClearOther()
        {
            partsInput.Text = String.Empty;
            laborInput.Text = String.Empty;
        }

        //clear fees
        private void ClearFees()
        {
            slOutput.Text = String.Empty;
            partsOutput.Text = String.Empty;
            taxOutput.Text = String.Empty;
            totalOutput.Text = String.Empty;
        }

        //Mathematical Processing Methods
        private decimal OilLubeCharges(decimal c)
        {
            if (oilChangeCB.Checked == true)
            {
                c += 26;
            }

            if (lubeJobCB.Checked == true)
            {
                c += 18;
            }

            return c;
        }

        //calculate flush charges
        private decimal FlushCharges(decimal c)
        {
            if (radRushCB.Checked == true)
            {
                c += 30;
            }

            if (transRushCB.Checked == true)
            {
                c += 80;
            }

            return c;
        }


        //calculate misc charges
        private decimal MiscCharges(decimal c)
        {
            if (inspCB.Checked == true)
            {
                c += 15;
            }

            if (repMufCB.Checked == true)
            {
                c += 100;
            }

            if (tireRotCB.Checked == true)
            {
                c += 20;
            }

            return c;
        }

        //calculat other charges
        private decimal OtherCharges(decimal c)
        {
            if (decimal.TryParse(partsInput.Text, out decimal parts) || partsInput.Text == String.Empty)
            {
                c += parts;
            }

            else
            {
                MessageBox.Show("Please enter a valid number for Parts.");
            }

            if (decimal.TryParse(laborInput.Text, out decimal labor) || laborInput.Text == String.Empty)
            {
                c += labor;
            }

            else
            {
                MessageBox.Show("Please enter a valud number for Labor.");

            }

            return c;
        }

        //calculate tax charges
        private decimal TaxCharges(decimal c)
        {
            if (decimal.TryParse(partsInput.Text, out decimal tax))
            {
                c = tax * 0.06m;
            }

            return c;
        }

        //calculate total charges
        private decimal TotalCharges(decimal s, decimal p, decimal t)
        {
            decimal c;

            c = s + p + t;

            return c;
        }


        private void calcButton_Click(object sender, EventArgs e)
        {
            decimal oilLubeTotal = 0m;
            decimal flushTotal = 0m;
            decimal miscTotal = 0m;
            decimal laborTotal = 0m;
            decimal partsTotal = 0m;
            decimal taxTotal = 0m;
            decimal servAndLabor = 0m;

            //if nothing selected display error message and close
            if (!oilChangeCB.Checked && !lubeJobCB.Checked && !radRushCB.Checked && !transRushCB.Checked && !inspCB.Checked && !repMufCB.Checked && !tireRotCB.Checked && partsInput.Text == String.Empty && laborInput.Text == String.Empty)
            {
                MessageBox.Show("Please Select something to proceed", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //parse input fields and calculate bill
            if (decimal.TryParse(partsInput.Text, out decimal parts) || partsInput.Text == String.Empty)
            {
                partsTotal = parts;
            }

            else
                MessageBox.Show("Please enter a valid number for Parts.");

            //parse labor fees
            if (decimal.TryParse(laborInput.Text, out decimal labor) || laborInput.Text == String.Empty)
            {
                laborTotal = labor;
            }

            else
                MessageBox.Show("Please enter a valid number for Labor.");

            servAndLabor = (OilLubeCharges(oilLubeTotal) + FlushCharges(flushTotal) + MiscCharges(miscTotal) + laborTotal);
            slOutput.Text = servAndLabor.ToString("c");


            partsOutput.Text = parts.ToString("c");

            //calculate total and display it
            taxTotal = TaxCharges(parts);
            taxOutput.Text = taxTotal.ToString("c");

                //call total charges method which calculate total bill
            totalOutput.Text = (TotalCharges(servAndLabor, parts, taxTotal)).ToString("c");

        }

        //clear all input fields
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
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
