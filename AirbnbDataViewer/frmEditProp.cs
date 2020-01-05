using AirbnbData;
using AirbnbDataViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirbnbDataViewer
{
    public partial class frmEditProp : Form
    {
        public frmEditProp()
        {
            InitializeComponent();
            // show all property values 
            frmViewer frmView = new frmViewer();
            txtPropID.Text = frmViewer.SetTextValuePropID;
            txtPropName.Text = frmViewer.SetTextValuePropName;
            txtHostID.Text = frmViewer.SetTextValueHostID;
            txtHostName.Text = frmViewer.SetTextValueHostName;
            txtNumProp.Text = Convert.ToString(frmViewer.SetTextValueNumProp);
            txtLati.Text = frmViewer.SetTextValueLati;
            txtLongi.Text = frmViewer.SetTextValueLongi;
            txtRoomType.Text = frmViewer.SetTextValueRoomType;
            txtPrice.Text = Convert.ToString(frmViewer.SetTextValuePrice);
            txtMinNights.Text = Convert.ToString(frmViewer.SetTextValueMinNights);
            txtDays.Text = Convert.ToString(frmViewer.SetTextValueDays);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        public static string SetTextValueProp = "";
        // sets all property values

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtPropID.Text != "")
            {
                SetTextValueProp = txtPropID.Text;
            }
            else MessageBox.Show("Please complete all fields.");

            if (txtPropName.Text != "")
            {
                SetTextValueProp = txtPropName.Text;
            }
            else MessageBox.Show("Please complete all fields.");

            if (txtHostID.Text != "")
            {
                SetTextValueProp = txtHostID.Text;
            }
            else MessageBox.Show("Please complete all fields.");

            if (txtHostName.Text != "")
            {
                SetTextValueProp = txtHostName.Text;
            }
            else MessageBox.Show("Please complete all fields.");

            if (txtNumProp.Text != "")
            {
                SetTextValueProp = txtNumProp.Text;
            }
            else MessageBox.Show("Please complete all fields.");

            if (txtLati.Text != "")
            {
                SetTextValueProp = txtLati.Text;
            }
            else MessageBox.Show("Please complete all fields.");

            if (txtLongi.Text != "")
            {
                SetTextValueProp = txtLongi.Text;
            }
            else MessageBox.Show("Please complete all fields.");

            if (txtRoomType.Text != "")
            {
                SetTextValueProp = txtRoomType.Text;
            }
            else MessageBox.Show("Please complete all fields.");

            if (txtPrice.Text != "")
            {
                SetTextValueProp = txtPrice.Text;
            }
            else MessageBox.Show("Please complete all fields.");

            if (txtMinNights.Text != "")
            {
                SetTextValueProp = txtMinNights.Text;
            }
            else MessageBox.Show("Please complete all fields.");

            if (txtDays.Text != "")
            {
                SetTextValueProp = txtDays.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();
        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
