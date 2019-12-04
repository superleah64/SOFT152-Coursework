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
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // this will allow admin to edit the selected piece of data
        }
    }
}

// we want to click a button to show the districts, then click a district to show the neighbourhoods, then click a neighbourhood to show the properties
