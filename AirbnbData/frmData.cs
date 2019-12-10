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

namespace AirbnbData
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnAddDist_Click(object sender, EventArgs e)
        {
            // check no district selected 
            //if Ok then display form to get new  district name
            // create a new district object with a zero no. of nhbs
            // add the object to the abb_array
        }

        private void BtnAddNbh_Click(object sender, EventArgs e)
        {
            // make sure district is selected and nbh is not 
            // if Ok then use inputbox to get new nbh name
            // create a new nbh object with this name and zero properties
            // add new nbh to district object using its setter
            // unselect district 
        }

        private void BtnEditDist_Click(object sender, EventArgs e)
        {
            // make sure a district has been selected
            // if so display an input form showdialog mode to accept the new name 
            // replace the data in the list with this new data 
            // use district object setter to update the name
            // make district list unselected
        }

        private void BtnEditNbh_Click(object sender, EventArgs e)
        {
            // make sure district and nbh are selected 
            // if so display an input form for entering new nbh name
            // change the name in the list
            // use the nbh setter to update that nbh object 
            // unselect the district and nbh lists
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();

            //write the data from airbnb_array back to text file
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // use file dialog to locate textfile 
            // read all text data into the abb_array
        }

        private void btnLoadDists_Click(object sender, EventArgs e)
        {
            // this will show the districts in the list box
            // by looping trhrough the airbnb_array using the getters from the district object 
        }

        private void btnLoadNbhs_Click(object sender, EventArgs e)
        {
            // if a district is selected display all nbh in that district using district objects getter for the number of nbh and nbh getters for data
        }

        private void btnLoadProps_Click(object sender, EventArgs e)
        {
            // show nbh properties using nbh objects getter for number of properties
            // and property getters for property details 
        }

        private void lstDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstNeighbourhoods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstProperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnPropMaint_Click(object sender, EventArgs e)
        {
            // make sure a dist and nbh are selected

            // open the property maintenance form
            frmPropMaint frm = new frmPropMaint();

            frm.Show();
        }
    }
}

// we want to click a button to show the districts, then click a district to show the neighbourhoods, then click a neighbourhood to show the properties
// when a district, neighbourhood or property is selected, its characteristics are displayed in the data box below
