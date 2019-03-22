//OMIS 449         Program 8     Spring 2019

//Programmer: Faisal Alharbi,  Z-ID 1748509
//Programmer: Bryce Frank,     Z-ID 1733433

//Programming Problem #6: Orion Constellation

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class OrionConstellation : Form
        //Name of the exercise
    {
        public OrionConstellation()
        {
            InitializeComponent();
        }

        private void OrionConstellation_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblBetelgeuse.Visible = true;
            lblMeissa.Visible = true;
            lblAlnitak.Visible = true;
            lblAlnilam.Visible = true;
            lblMintaka.Visible = true;
            lblSaiph.Visible = true;
            lblRigel.Visible = true;
            // Show the stars names code
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            lblBetelgeuse.Visible = false;
            lblMeissa.Visible = false;
            lblAlnitak.Visible = false;
            lblAlnilam.Visible = false;
            lblMintaka.Visible = false;
            lblSaiph.Visible = false;
            lblRigel.Visible = false;
            // hide the stars names code
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Exit code
        }
    }
}
