using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirbnbData
{
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();
        }

        private void BtnDist_Click(object sender, EventArgs e)
        {
            // this will show the districts in the list box
            // by looping trhrough the abb_array using the getters from the district object 
        }

        private void FrmData_Load(object sender, EventArgs e)
        {
            // use file dialog to locate textfile 
            // read all text data into the abb_array
        }

        private void BtnPropMaint_Click(object sender, EventArgs e)
        {
            // make sure a district and nbh are selected
            // open property maintenance form 
        }

        private void BtnEditDistrict_Click(object sender, EventArgs e)
        {
            // make sure a district has been selected
            // if so display an input form showdialogue mode to accespt the new name 
            // replace the data in the list with this new data 
            // use district object setter to update the name  
            // make district liest unselected 
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // write the data from abb_array back to a text file 
            // close form 
        }

        private void BtnAddDistrict_Click(object sender, EventArgs e)
        {
            // check no district selected 
            //if Ok then display form to get new  district name
            
            {
                // send the value to the district setter 
            }
            // create a new district object with a zero no. of nhbs
            // add the object to the abb_array
        }

        private void BtnEditNbh_Click(object sender, EventArgs e)
        {
            // make sure district and nbh are selected 
            // if so display an input form for entering new nbh name
            // change the name in the list
            // use the nbh setter to update that nbh object 
            // unselect the district and nbh lists
        }

        private void BtnAddNbh_Click(object sender, EventArgs e)
        {
            // make sure district is selected and nbh is not 
            // if Ok then use inputbox to get new nbh name
            // create a new nbh object with this name and zero properties
            // add new nbh to district object using its setter
            // unselect district 
        }

        private void BtnShowNbh_Click(object sender, EventArgs e)
        {
            // if a dsitrict is selected diplay all nbh in that district using district objects getter for the number of nbh and nbh getters for data
        }

        private void BtnShowProp_Click(object sender, EventArgs e)
        {
            // show nbh properties using nbh objects getter for number of properties
            // and property getters for property details 
        }
    }
}

// we want to click a button to show the districts, then click a district to show the neighbourhoods, then click a neighbourhood to show the properties
