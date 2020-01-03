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
        }
        public static string SetTextValueProp = "";
        // sets all property values

        private void frmEditProp_Load(object sender, EventArgs e)
        {     }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtPropID.Text != "")
            {
                SetTextValueProp = txtPropID.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();

            if (txtPropName.Text != "")
            {
                SetTextValueProp = txtPropName.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();

            if (txtHostID.Text != "")
            {
                SetTextValueProp = txtHostID.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();

            if (txtHostName.Text != "")
            {
                SetTextValueProp = txtHostName.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();

            if (txtNumProp.Text != "")
            {
                SetTextValueProp = txtNumProp.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();

            if (txtLati.Text != "")
            {
                SetTextValueProp = txtLati.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();

            if (txtLongi.Text != "")
            {
                SetTextValueProp = txtLongi.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();

            if (txtRoomType.Text != "")
            {
                SetTextValueProp = txtRoomType.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();

            if (txtPrice.Text != "")
            {
                SetTextValueProp = txtPrice.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();

            if (txtMinNights.Text != "")
            {
                SetTextValueProp = txtMinNights.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();

            if (txtDays.Text != "")
            {
                SetTextValueProp = txtDays.Text;
            }
            else MessageBox.Show("Please complete all fields.");
            this.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // show all property values 
            frmViewer frmView = new frmViewer();
            txtPropID.Text = frmViewer.SetTextValuePropID;
            txtPropName.Text = frmViewer.SetTextValuePropName;
        }
    }
}
