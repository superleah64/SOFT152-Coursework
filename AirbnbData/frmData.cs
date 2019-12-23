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
            // if Ok then display form to get new  district name
            // create a new district object with a zero no. of nhbs
            // add the object to the airbnb_array
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

        private void frmData_Load(object sender, EventArgs e)
        {

         
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // use file dialog to locate textfile 
            // read all text data into the abb_array
        }

        private void btnLoadDists_Click(object sender, EventArgs e)
        {
            // this will show the districts in the list box
            // by looping through the airbnb_array using the getters from the district object
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
            if (lstDistricts.SelectedIndex !=-1)

            // if so display its nbd names
            {
                int distno = lstDistricts.SelectedIndex;
                
                District dist = Arrays.DistData[distno];
                int nbdno = dist.getDistNumNbh();
                MessageBox.Show(Convert.ToString(nbdno));
                // put all the selected  districts nbhds inot an array 
                Arrays.NbhData = dist.getDistAllNbh();

                foreach (Neighbourhood nbh in Arrays.NbhData)
                    
                    lstNeighbourhoods.Items.Add(nbh.getNbhName());

            }
            //lstNeighbourhoods.Items.Clear();
        }

        private void btnLoadProps_Click(object sender, EventArgs e)
        {
            // show nbh properties using nbh objects getter for number of properties
            // and property getters for property details 
            // if a district is selected display all nbh in that district using district objects getter for the number of nbh and nbh getters for data
            //check a district is selected
            if (lstDistricts.SelectedIndex != -1)

            // if so check nbh selected
            if(lstNeighbourhoods.SelectedIndex!=-1)

            {
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
            //lstNeighbourhoods.Items.Clear();
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

        private void BtnLoadData_Click(object sender, EventArgs e)
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
    }   
}

// we want to click a button to show the districts, then click a district to show the neighbourhoods, then click a neighbourhood to show the properties
// when a district, neighbourhood or property is selected, its characteristics are displayed in the data box below
