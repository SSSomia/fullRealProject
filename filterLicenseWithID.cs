using businessLayer0;
using licenseBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userBusiness;

namespace fullRealProject
{
    public partial class filterLicenseWithID : UserControl
    {
        public filterLicenseWithID()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (id.Text.Length == 0)
            {
                return;
            }
            int lid = int.Parse(id.Text);
            if (!clsLicense.isLicenseExist(lid))
            {
                MessageBox.Show("this license not exist!");
            }
            else if (!clsLicense.isLicenseActive(lid))
            {
                MessageBox.Show("this license is not active!");
            }
            else
            {
                licenseInfo1.printLicense(lid);
            }
        }

        public int getLicenseID()
        {
            if(id.Text == "")
            {
                return 0;
            }
            return int.Parse(id.Text);
        }
    }
}
