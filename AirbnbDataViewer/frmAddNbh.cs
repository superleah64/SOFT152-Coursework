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
    public partial class frmAddNbh : Form
    {
        public frmAddNbh()
        {
            InitializeComponent();
        }
        public static string SetTextValueNbh;
        private void btnDoneDist_Click(object sender, EventArgs e)
        {
            if (txtAddNbh.Text != "")
            {
                SetTextValueNbh = txtAddNbh.Text;
            }
            else MessageBox.Show("Please enter a name.");
            this.Close();
        }
    }
}
