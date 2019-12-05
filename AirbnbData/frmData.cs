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

        private void BtnShowDist_Click(object sender, EventArgs e)
        {
            // show characteristics of the selected district
        }

        private void BtnShowNbh_Click(object sender, EventArgs e)
        {
            // show characteristics of the selected neighbourhood
        }

        private void BtnShowProp_Click(object sender, EventArgs e)
        {
            // show characteristics of the selected property
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void TxtPropID_TextChanged(object sender, EventArgs e)
        {
            // select a piece of data from the data listbox and edit it in here
        }
    }
}

// we want to click a button to show the districts, then click a district to show the neighbourhoods, then click a neighbourhood to show the properties
// when a district, neighbourhood or property is selected, its characteristics are displayed in the data box below
