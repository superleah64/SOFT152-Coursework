﻿using AirbnbDataViewer;
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
    public partial class frmViewer : Form
    {
        public frmViewer()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            // select file 
            DialogResult result = openFileDialog1.ShowDialog();


            string strfilename = openFileDialog1.FileName;

            // read the data in from the text file
            using (StreamReader AirbnbData = new StreamReader(strfilename))
            {
                // create a while loop
                while (!AirbnbData.EndOfStream)

                {
                    // deal with a district
                    string TempDistName = AirbnbData.ReadLine();
                    string TempNumNbh = AirbnbData.ReadLine();
                    int NumNbh = Convert.ToInt32(TempNumNbh);
                    Neighbourhood[] nbh_array = new Neighbourhood[NumNbh];
                    // deal with each of this district's neighbourhoods
                    for (int a = 0; a < NumNbh; a++)
                    {

                        string TempNbhName = AirbnbData.ReadLine();
                        string TempNumProp = AirbnbData.ReadLine();
                        int NumProp = Convert.ToInt32(TempNumProp);
                        Property[] Prop_Array = new Property[NumProp];
                        // deal with this neighbourhoods properties 

                        for (int b = 0; b < NumProp; b++)
                        {
                            string TempPropID = AirbnbData.ReadLine();
                            string TempPropName = AirbnbData.ReadLine();
                            string TempHostID = AirbnbData.ReadLine();
                            string TempHostName = AirbnbData.ReadLine();
                            string TempNumPropH = AirbnbData.ReadLine();
                            string TempLati = AirbnbData.ReadLine();
                            string TempLongi = AirbnbData.ReadLine();
                            string TempRoomType = AirbnbData.ReadLine();
                            string TempPrice = AirbnbData.ReadLine();
                            string TempMinNights = AirbnbData.ReadLine();
                            string TempDays = AirbnbData.ReadLine();

                            Property TempProp = new Property(TempPropID, TempPropName, TempHostID, TempHostName, Convert.ToInt32(TempNumPropH), TempLati, TempLongi,
                                                                    TempRoomType, Convert.ToInt32(TempPrice), Convert.ToInt32(TempMinNights), Convert.ToInt32(TempDays));

                            int newPropSize = Arrays.PropData.Length;
                            Array.Resize(ref Arrays.PropData, newPropSize + 1);
                            Arrays.PropData[newPropSize] = TempProp;
                        }

                        Neighbourhood TempNbh = new Neighbourhood(TempNbhName, Convert.ToInt32(TempNumProp), Arrays.PropData);
                        Array.Resize(ref Arrays.PropData, 0);
                        int newNbhSize = Arrays.NbhData.Length;
                        Array.Resize(ref Arrays.NbhData, newNbhSize + 1);
                        Arrays.NbhData[newNbhSize] = TempNbh;
                    }

                    District TempDist = new District(TempDistName, Convert.ToInt32(TempNumNbh), Arrays.NbhData);
                    Array.Resize(ref Arrays.NbhData, 0);
                    int newDistSize = Arrays.DistData.Length;
                    Array.Resize(ref Arrays.DistData, newDistSize + 1);
                    Arrays.DistData[newDistSize] = TempDist;

                }

                AirbnbData.Close();
            }
        }

        private void btnLoadDists_Click(object sender, EventArgs e)
        {
            // this will show the districts in the list box
            // by looping through the AirbnbData array using the getters from the district object
            lstDistricts.Items.Clear();
            foreach (District dist in Arrays.DistData)
            {
                //get the district name
                // put the name in the listbox
                lstDistricts.Items.Add(dist.getDistName());

            }
        }

        private void btnLoadNbhs_Click(object sender, EventArgs e)
        {
            // if a district is selected display all nbh in that district using district objects getter for the number of nbh and nbh getters for data
            //check a district is selected
            if (lstDistricts.SelectedIndex != -1)

            // if so display its nbh names
            {
                lstNeighbourhoods.Items.Clear();
                int distno = lstDistricts.SelectedIndex;

                District dist = Arrays.DistData[distno];
                int nbhno = dist.getDistNumNbh();
                // put all the selected  district's nbhs into an array 
                Arrays.NbhData = dist.getDistAllNbh();

                foreach (Neighbourhood nbh in Arrays.NbhData)

                    lstNeighbourhoods.Items.Add(nbh.getNbhName());

            }
        }

        private void btnLoadProps_Click(object sender, EventArgs e)
        {
            // show nbh properties using nbh objects getter for number of properties
            // and property getters for property details 
            // if a district is selected display all nbh in that district using district objects getter for the number of nbh and nbh getters for data
            //check a district is selected
            if (lstDistricts.SelectedIndex != -1 && lstNeighbourhoods.SelectedIndex != -1)

            {
                lstProperties.Items.Clear();
                int distno = lstDistricts.SelectedIndex;

                District dist = Arrays.DistData[distno];

                // put all the selected  districts nbhds inot an array 
                Arrays.NbhData = dist.getDistAllNbh();
                //get the nbh we need
                int whichnbh = lstNeighbourhoods.SelectedIndex;
                Neighbourhood nbh = Arrays.NbhData[whichnbh];

                Arrays.PropData = nbh.getNbhAllProp();

                foreach (Property prop in Arrays.PropData)

                    lstProperties.Items.Add(prop.getPropName());

            }
        }

        private void btnAddDist_Click(object sender, EventArgs e)
        {
            if (lstDistricts.SelectedIndex == -1)
            {

            }

            // if Ok then open dialog box to get new  district name
            // create a new district object with a zero no. of nhbs

            // add the object to the airbnb_array
            // lstDistricts.Items.Add();
        }

        private void btnEditDist_Click(object sender, EventArgs e)
        {
            // make sure a district has been selected
            if (lstDistricts.SelectedIndex != -1)
            {
                // show the edit form and capture the new data
                frmEditDist frmEditD = new frmEditDist();

                // display an input form showdialog mode to accept the new name 
                frmEditD.ShowDialog();
                txtTemp.Text = frmEditDist.SetTextValueDist;

                // update the data in the array object
                int distno = lstDistricts.SelectedIndex;


                District dist = Arrays.DistData[distno];
                dist.setDistName(txtTemp.Text);

                // redisplay the district data in the list box
                lstDistricts.Items.Clear();

                foreach (District newdist in Arrays.DistData)
                {
                    //get the district name

                    // put the name in the listbox
                    lstDistricts.Items.Add(newdist.getDistName());

                }
            }
        }

        private void btnAddNbh_Click(object sender, EventArgs e)
        {
            // make sure district is selected and nbh is not
            if (lstDistricts.SelectedIndex != -1 && lstNeighbourhoods.SelectedIndex == -1)
            {

            }

            // if Ok then open dialog box to get new nbh name
            // create a new nbh object with this name and zero properties
            // add new nbh to district object using its setter
            // unselect district 
        }

        private void btnEditNbh_Click(object sender, EventArgs e)
        {
            // if neighbourhood is selected
            if (lstNeighbourhoods.SelectedIndex != -1)
            {
                // show the edit form and capture the new data
                frmEditNbh frmEditN = new frmEditNbh();

                // if so display an input form showdialog mode to accept the new name 
                frmEditN.ShowDialog();
                txtTemp.Text = frmEditNbh.SetTextValueNbh;

                // update the data in the array object
                int nbhno = lstNeighbourhoods.SelectedIndex;


                Neighbourhood nbh = Arrays.NbhData[nbhno];
                nbh.setNbhName(txtTemp.Text);

                // redisplay the neighbourhood dta in the list box
                lstNeighbourhoods.Items.Clear();

                foreach (Neighbourhood newnbh in Arrays.NbhData)
                {
                    //get the neighbourhood name

                    // put the name in the listbox
                    lstNeighbourhoods.Items.Add(newnbh.getNbhName());

                }
            }
        }

        private void btnPropMaint_Click(object sender, EventArgs e)
        {
            // make sure a dist and nbh are selected
            if (lstDistricts.SelectedIndex != -1 && lstNeighbourhoods.SelectedIndex != -1)
            {
                // open the property maintenance form
                frmPropMaintenance frmProp = new frmPropMaintenance();
                frmProp.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // select file for output - used during testing to avoid corrupting the source file
            // can be removed for final version
            DialogResult result = openFileDialog1.ShowDialog();


            string strfilename = openFileDialog1.FileName;

            // read the data in from the text file
            using (StreamWriter AirbnbData = new StreamWriter(strfilename))
            //write the data from airbnb_array back to text file

                foreach (District dist in Arrays.DistData)
                {
                    AirbnbData.WriteLine(dist.getDistName());
                    AirbnbData.WriteLine(dist.getDistNumNbh());

                    foreach (Neighbourhood nbh in dist.getDistAllNbh())
                    {
                        AirbnbData.WriteLine(nbh.getNbhName());
                        AirbnbData.WriteLine(nbh.getNbhNumProp());

                        foreach (Property prop in nbh.getNbhAllProp())
                        {
                            AirbnbData.WriteLine(prop.getPropID());
                            AirbnbData.WriteLine(prop.getPropName());
                            AirbnbData.WriteLine(prop.getHostID());
                            AirbnbData.WriteLine(prop.getHostName());
                            AirbnbData.WriteLine(prop.getNumPropH());
                            AirbnbData.WriteLine(prop.getLati());
                            AirbnbData.WriteLine(prop.getLongi());
                            AirbnbData.WriteLine(prop.getRoomType());
                            AirbnbData.WriteLine(prop.getPrice());
                            AirbnbData.WriteLine(prop.getMinNights());
                            AirbnbData.WriteLine(prop.getDays());
                        } // next property
                    }// next nbh
                }//next dist
            // close the form
            this.Close();
        }
    }
}