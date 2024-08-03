using appBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fullRealProject
{
    public partial class drivingLicenseApplicationInfoUC : UserControl
    {
        public drivingLicenseApplicationInfoUC()
        {
            InitializeComponent();
        }
        public void showData(string licenseClass, int passedTests)
        {
            license.Text = licenseClass;
            passTest.Text = passedTests.ToString() + "/3";
        }
    }
}
