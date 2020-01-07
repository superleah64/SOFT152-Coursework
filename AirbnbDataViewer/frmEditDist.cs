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
    public partial class frmEditDist : Form
    {
        public frmEditDist()
        {
            InitializeComponent();
        }
        public static string SetTextValueDist = "";

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtEditDist.Text != "")
            {
                SetTextValueDist = txtEditDist.Text;
            }
            else MessageBox.Show("Please enter a new name.");
            this.Close();
        }
    }
}