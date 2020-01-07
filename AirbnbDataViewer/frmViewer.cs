using AirbnbDataViewer;
using System;
using System.IO;
using System.Windows.Forms;

namespace AirbnbData
{
    public partial class frmViewer : Form
    {
        public frmViewer()
        {
            InitializeComponent();
        }

        // only allows data to be loaded in if the load data button was clicked
        private bool btnLoadDataWasClicked = false;
        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            // hide text and data load button
            btnLoadData.Hide();
            lblClick.Hide();

            // show all buttons and listboxes
            imgTitle.Show();
            imgDistricts.Show();
            imgNeighbourhoods.Show();
            imgProperties.Show();
            lstDistricts.Show();
            lstNeighbourhoods.Show();
            lstProperties.Show();
            btnAddDist.Show();
            btnEditDist.Show();
            btnAddNbh.Show();
            btnEditNbh.Show();
            btnAddProp.Show();
            btnEditProp.Show();
            btnExit.Show();
            
            btnLoadDataWasClicked = true;

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
                        if (NumProp != 0)
                        {
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

                                int newPropSize = Arrays.PropArray.Length;
                                Array.Resize(ref Arrays.PropArray, newPropSize + 1);
                                Arrays.PropArray[newPropSize] = TempProp;
                            }

                            Neighbourhood TempNbh = new Neighbourhood(TempNbhName, Convert.ToInt32(TempNumProp), Arrays.PropArray);
                            Array.Resize(ref Arrays.PropArray, 0);
                            int newNbhSize = Arrays.NbhArray.Length;
                            Array.Resize(ref Arrays.NbhArray, newNbhSize + 1);
                            Arrays.NbhArray[newNbhSize] = TempNbh;
                        }
                    }

                    District TempDist = new District(TempDistName, Convert.ToInt32(TempNumNbh), Arrays.NbhArray);
                    Array.Resize(ref Arrays.NbhArray, 0);
                    int newDistSize = Arrays.DistArray.Length;
                    Array.Resize(ref Arrays.DistArray, newDistSize + 1);
                    Arrays.DistArray[newDistSize] = TempDist;
                }

                AirbnbData.Close();
            }

            // only show data and buttons if data was loaded in first
            if (btnLoadDataWasClicked)
            {
                // this will show the districts in the list box by looping through the array using the getters
                lstDistricts.Items.Clear();
                foreach (District dist in Arrays.DistArray)
                {
                    // get the district name
                    // put the name in the listbox
                    lstDistricts.Items.Add(dist.getDistName());
                }
                //add/edit dist buttons become available         
                btnAddDist.Show();
                btnEditDist.Show();
            }
        }

        private void LstDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if a district is selected display all nbh in that district
            // check a district is selected
            if (lstDistricts.SelectedIndex != -1 && btnLoadDataWasClicked)

            // if so display its nbh names
            {
                lstNeighbourhoods.Items.Clear();
                int distno = lstDistricts.SelectedIndex;

                District dist = Arrays.DistArray[distno];
                int nbhno = dist.getDistNumNbh();
                // put all the selected  district's nbhs into an array 
                Arrays.NbhArray = dist.getDistAllNbh();
                if (nbhno != 0)
                {
                    foreach (Neighbourhood nbh in Arrays.NbhArray)
                        lstNeighbourhoods.Items.Add(nbh.getNbhName());

                    //add/edit nbh buttons become available
                    btnAddNbh.Show();
                    btnEditNbh.Show();
                }
            }

            else
            {
                MessageBox.Show("You must select a district.");
            }
        }

        private void LstNeighbourhoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check a district and neighbourhood is selected
            // check data was loaded in
            if (lstDistricts.SelectedIndex != -1 && lstNeighbourhoods.SelectedIndex != -1 && btnLoadDataWasClicked)
            {
                lstProperties.Items.Clear();
                int distno = lstDistricts.SelectedIndex;

                District dist = Arrays.DistArray[distno];

                // put all the selected  district's nbhs into an array 
                Arrays.NbhArray = dist.getDistAllNbh();
                //get the nbh we need
                int whichnbh = lstNeighbourhoods.SelectedIndex;
                Neighbourhood nbh = Arrays.NbhArray[whichnbh];

                Arrays.PropArray = nbh.getNbhAllProp();
                if (nbh.getNbhNumProp() != 0)
                {
                    nbh.getNbhAllProp();
                    foreach (Property prop in Arrays.PropArray)

                        lstProperties.Items.Add(prop.getPropName());

                    // property maintenance buttons become available
                    btnAddProp.Show();
                    btnEditProp.Show();
                }
            }

            else
            {
                MessageBox.Show("You must select a district and neighbourhood.");
            }

        }

        private void BtnAddDist_Click(object sender, EventArgs e)
        {

            // this code is almost working but when I attempt to add it from the add form it does not work
            // so I have used an example to show it working

            if (lstDistricts.SelectedIndex == -1)
            {
                // display a text box for entering the new district's name
                // create a new district object using an alternative constructor 
                District TempDist = new District("Example");
                // add the new object to the all districts array
                int newDistSize = Arrays.DistArray.Length;
                Array.Resize(ref Arrays.DistArray, newDistSize + 1);
                Arrays.DistArray[newDistSize] = TempDist;

                // redisplay the district lst box 
                // redisplay the district data in the list box
                lstDistricts.Items.Clear();

                foreach (District newdist in Arrays.DistArray)
                {
                    //get the district name
                    // put the name in the listbox
                    lstDistricts.Items.Add(newdist.getDistName());
                }
            }
        }

        private void BtnEditDist_Click(object sender, EventArgs e)
        {
            // make sure a district has been selected
            if (lstDistricts.SelectedIndex != -1)
            {
                // show the edit form and capture the new data
                frmEditDist frmEditD = new frmEditDist();

                // display an input form showdialog mode to accept the new name 
                frmEditD.ShowDialog();

                // update the data in the array object
                int distno = lstDistricts.SelectedIndex;

                District dist = Arrays.DistArray[distno];
                dist.setDistName(frmEditDist.SetTextValueDist);

                // redisplay the district data in the list box
                lstDistricts.Items.Clear();

                foreach (District newdist in Arrays.DistArray)
                {
                    //get the district name
                    // put the name in the listbox
                    lstDistricts.Items.Add(newdist.getDistName());
                }
            }
            else
            {
                MessageBox.Show("You must select a district to edit.");
            }
        }

        private void BtnAddNbh_Click(object sender, EventArgs e)
        {
            //if (lstDistricts.SelectedIndex != -1)
            //{
            //    // call the district's add new nbh setter
            //    Arrays.DistArray[lstDistricts.SelectedIndex].setNewNbh(frmAddNbh.SetTextValueNbh);

            //    lstNeighbourhoods.Items.Clear();
            //    lstDistricts.Items.Add("Example");

            //    foreach (Neighbourhood newnbh in Arrays.NbhArray)
            //    {
            //        //get the neighbourhood name
            //        // put the name in the listbox
            //        lstNeighbourhoods.Items.Add(newnbh.getNbhName());
            //    }
            //}

            //else
            //{
            //    MessageBox.Show("You must select a district.");
            //}
        }

        private void BtnEditNbh_Click(object sender, EventArgs e)
        {
            // if neighbourhood is selected
            if (lstNeighbourhoods.SelectedIndex != -1)
            {
                // show the edit form and capture the new data
                frmEditNbh frmEditN = new frmEditNbh();

                // if so display an input form showdialog mode to accept the new name 
                frmEditN.ShowDialog();

                // update the data in the array object
                int nbhno = lstNeighbourhoods.SelectedIndex;

                Neighbourhood nbh = Arrays.NbhArray[nbhno];
                nbh.setNbhName(frmEditNbh.SetTextValueNbh);

                // redisplay the neighbourhood dta in the list box
                lstNeighbourhoods.Items.Clear();

                foreach (Neighbourhood newnbh in Arrays.NbhArray)
                {
                    //get the neighbourhood name
                    // put the name in the listbox
                    lstNeighbourhoods.Items.Add(newnbh.getNbhName());
                }
            }
            else
            {
                MessageBox.Show("You must select a neighbourhood to edit.");
            }
        }

        private void BtnAddProp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet available.");
            //// make sure a dist and nbh are selected and prop is not
            //if (lstDistricts.SelectedIndex != -1 && lstNeighbourhoods.SelectedIndex != -1 && lstProperties.SelectedIndex == -1)
            //{
            //    // open the property maintenance form
            //    frmAddProp frmProp = new frmAddProp();
            //    frmProp.Show();
            //}
        }

        public static string SetTextValuePropID;
        public static string SetTextValuePropName;
        public static string SetTextValueHostID;
        public static string SetTextValueHostName;
        public static int SetTextValueNumProp;
        public static string SetTextValueLati;
        public static string SetTextValueLongi;
        public static string SetTextValueRoomType;
        public static int SetTextValuePrice;
        public static int SetTextValueMinNights;
        public static int SetTextValueDays;

        private void BtnEditProp_Click(object sender, EventArgs e)
        {
            // make sure a dist, nbh and prop are selected
            if (lstDistricts.SelectedIndex != -1 && lstNeighbourhoods.SelectedIndex != -1 && lstProperties.SelectedIndex != -1)
            {
                // get district number
                int distno = lstDistricts.SelectedIndex;
                // get neighbourhood number 
                int whichnbh = lstNeighbourhoods.SelectedIndex;
                // get property number
                int propno = lstProperties.SelectedIndex;
                // open the property maintenance form
                // get this property object out of the arrays
                District dist = Arrays.DistArray[distno];
                Neighbourhood nbh = Arrays.NbhArray[whichnbh];
                Arrays.PropArray = nbh.getNbhAllProp();
                Property prop = Arrays.PropArray[propno];

                // get data ready to carry to new form    
                SetTextValuePropID = prop.getPropID();
                SetTextValuePropName = prop.getPropName();
                SetTextValueHostID = prop.getHostID();
                SetTextValueHostName = prop.getHostName();
                SetTextValueNumProp = prop.getNumPropH();
                SetTextValueLati = prop.getLati();
                SetTextValueLongi = prop.getLongi();
                SetTextValueRoomType = prop.getRoomType();
                SetTextValuePrice = prop.getPrice();
                SetTextValueMinNights = prop.getMinNights();
                SetTextValueDays = prop.getDays();

                frmEditProp frmProp = new frmEditProp();
                
                frmProp.Show();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // select file for output - used during testing to avoid corrupting the source file
            DialogResult result = openFileDialog1.ShowDialog();
            string strfilename = openFileDialog1.FileName;

            // read the data in from the text file
            using (StreamWriter AirbnbData = new StreamWriter(strfilename))
            //write the data from airbnb_array back to text file

                foreach (District dist in Arrays.DistArray)
                {
                    AirbnbData.WriteLine(dist.getDistName());
                    AirbnbData.WriteLine(dist.getDistNumNbh());
                    if (dist.getDistNumNbh() != 0)
                    {
                        foreach (Neighbourhood nbh in dist.getDistAllNbh())
                        {
                            AirbnbData.WriteLine(nbh.getNbhName());
                            AirbnbData.WriteLine(nbh.getNbhNumProp());
                            if (nbh.getNbhNumProp() != 0 )
                            {
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
                            }
                        }// next nbh
                    }
                }//next dist
            // close the form
            this.Close();
        }
    }
}
