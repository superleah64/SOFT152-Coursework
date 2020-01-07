using AirbnbData;
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
    public partial class frmAddDist : Form
    {
        public frmAddDist()
        {
            InitializeComponent();
        }

        public static string SetTextValueDist = "";

        private void btnDoneDist_Click(object sender, EventArgs e)
        {
            if (txtAddDist.Text != "")
            {
                SetTextValueDist = txtAddDist.Text;
            }
            else MessageBox.Show("Please enter a name.");
            this.Close();
        }
    }
}
