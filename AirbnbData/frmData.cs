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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnAddDist_Click(object sender, EventArgs e)
        {
            // open a prompt to add a district
        }

        private void BtnAddNbh_Click(object sender, EventArgs e)
        {
            // open a prompt to add a neighbourhood
        }

        private void BtnAddProp_Click(object sender, EventArgs e)
        {
            // open a prompt to add a property
        }

        private void BtnEditDist_Click(object sender, EventArgs e)
        {
            // open a prompt to edit a district, make Delete button visible
        }

        private void BtnEditNbh_Click(object sender, EventArgs e)
        {
            // open a prompt to edit a neighbourhood
        }

        private void BtnEditProp_Click(object sender, EventArgs e)
        {
            // open a prompt to edit a property
        }

       
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void TxtPropID_TextChanged(object sender, EventArgs e)
        {
            // select a piece of data from the data listbox and edit it in here
        }

        private void btnLoadDists_Click(object sender, EventArgs e)
        {
            // when you hover over the image it changes to a paler version of the image
            // click to load the districts into the listbox
        }

        

        private void btnLoadNbhs_Click(object sender, EventArgs e)
        {
            // when you hover over the image it changes to a paler version of the image
            // click to load the neighbourhoods into the listbox
        }

        private void btnLoadProps_Click(object sender, EventArgs e)
        {
            // when you hover over the image it changes to a paler version of the image
            // click to load the properties into the listbox
        }

        private void lstDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this listbox reads in the district data from the text file
        }

        private void lstNeighbourhoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this listbox reads in the neighbourhood data from the text file
        }

        private void lstProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this listbox reads in the property data from the text file
        }

        private void lstDistData_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this listbox displays the details of the selected district
        }

        private void lstNbhData_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this listbox displays the details of the selected
        }

        private void lstPropData_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this listbox displays the details of the selected
        }
    }
}

// we want to click a button to show the districts, then click a district to show the neighbourhoods, then click a neighbourhood to show the properties
// when a district, neighbourhood or property is selected, its characteristics are displayed in the data box below
