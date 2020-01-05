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
    public partial class frmEditNbh : Form
    {
        public frmEditNbh()
        {
            InitializeComponent();

        }
        public static string SetTextValueNbh = "";

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtEditNbh.Text != "")
            {
                SetTextValueNbh = txtEditNbh.Text;
            }
            else MessageBox.Show("Please enter a name.");
            this.Close();
        }

        private void txtEditNbh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}