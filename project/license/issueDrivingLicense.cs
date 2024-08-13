using businessLayer0;
using personTestsBusiness;
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
    public partial class issueDrivingLicense : Form
    {
        private int _applicationID;
        private string _license;
        public issueDrivingLicense(int applicationID, string license)
        {
            InitializeComponent();
            _applicationID = applicationID;
            _license = license;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void issue_Click(object sender, EventArgs e)
        {
            clsPersonTest.updateState(_applicationID, "completed");
            this.Close();
        }

        private void issueDrivingLicense_Load(object sender, EventArgs e)
        {
            applicationInfoUC1.showData(_applicationID, _license, 3);
        }
    }
}
