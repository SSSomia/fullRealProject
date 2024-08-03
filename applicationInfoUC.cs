using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullRealProject
{
    public partial class applicationInfoUC : UserControl
    {
        public applicationInfoUC()
        {
            InitializeComponent();
        }

        private void applicationInfoUC_Load(object sender, EventArgs e)
        {

        }

        public void showData(int userID, string licenseClass, int passedTests)
        {
            drivingLicenseApplicationInfoUC1.showData(licenseClass, passedTests);
            appBasicInfoUC1.showData(userID);
        }
    }
}
