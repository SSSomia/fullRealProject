using appBusiness;
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
    public partial class drivingLicenseApp : Form
    {
        public drivingLicenseApp()
        {
            InitializeComponent();
        }
        private void _rowNums()
        {
            rowsNum.Text = clsApp.numOfRows().ToString();
        }
        private void _loaddrivingLicenseApp()
        {
            localDrivingLicenseApps.DataSource = clsApp.getAllApplications();
        }
        private void drivingLicenseApp_Load(object sender, EventArgs e)
        {
            _loaddrivingLicenseApp();
            _rowNums();
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dealWithLicense_Opening(object sender, CancelEventArgs e)
        {
            if ((string)localDrivingLicenseApps.CurrentRow.Cells[5].Value == "new")
            {
                showLicenseToolStripMenuItem.Enabled = false;
                if ((int)localDrivingLicenseApps.CurrentRow.Cells[6].Value != 3)
                {
                    issueDrivingLicenseToolStripMenuItem.Enabled = false;
                    showLicenseToolStripMenuItem.Enabled = false;
                    sechualTests.Enabled = true;
                }
                if ((int)localDrivingLicenseApps.CurrentRow.Cells[6].Value == 0)
                {
                    writtenTestToolStripMenuItem.Enabled = false;
                    practicalTestToolStripMenuItem.Enabled = false;
                    visionTestToolStripMenuItem.Enabled = true;
                }
                else if ((int)localDrivingLicenseApps.CurrentRow.Cells[6].Value == 1)
                {
                    visionTestToolStripMenuItem.Enabled = false;
                    writtenTestToolStripMenuItem.Enabled = true;
                    practicalTestToolStripMenuItem.Enabled = false;
                }
                else if ((int)localDrivingLicenseApps.CurrentRow.Cells[6].Value == 2)
                {
                    visionTestToolStripMenuItem.Enabled = false;
                    writtenTestToolStripMenuItem.Enabled = false;
                    practicalTestToolStripMenuItem .Enabled = true;
                }
                else
                {
                    sechualTests.Enabled = false;
                    issueDrivingLicenseToolStripMenuItem.Enabled = true;
                    showLicenseToolStripMenuItem.Enabled = true;
                }
            }
            else if ((string)localDrivingLicenseApps.CurrentRow.Cells[5].Value == "canceled")
            {
                dealWithLicense.Enabled = false;
            }
            else
            {
                cancelApplicationToolStripMenuItem.Enabled = false;
                sechualTests.Enabled = false;
                issueDrivingLicenseToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;
            }
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new tests("Vision Test Appointment", (int)localDrivingLicenseApps.CurrentRow.Cells[0].Value, (string)localDrivingLicenseApps.CurrentRow.Cells[3].Value, (int)localDrivingLicenseApps.CurrentRow.Cells[6].Value);
            form.ShowDialog();
            _loaddrivingLicenseApp();
        }

        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new tests("written Test Appointment", (int)localDrivingLicenseApps.CurrentRow.Cells[0].Value, (string)localDrivingLicenseApps.CurrentRow.Cells[3].Value, (int)localDrivingLicenseApps.CurrentRow.Cells[6].Value);
            form.ShowDialog();
            _loaddrivingLicenseApp();
        }
        private void sechualTests_Click(object sender, EventArgs e)
        {

        }

        private void practicalTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new tests("practical Test Appointment", (int)localDrivingLicenseApps.CurrentRow.Cells[0].Value, (string)localDrivingLicenseApps.CurrentRow.Cells[3].Value, (int)localDrivingLicenseApps.CurrentRow.Cells[6].Value);
            form.ShowDialog();
            _loaddrivingLicenseApp();
        }

        private void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new issueDrivingLicense((int)localDrivingLicenseApps.CurrentRow.Cells[0].Value, (string)localDrivingLicenseApps.CurrentRow.Cells[3].Value);
            form.ShowDialog();
            _loaddrivingLicenseApp();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPersonTest.updateState((int)localDrivingLicenseApps.CurrentRow.Cells[0].Value, "canceled");
            _loaddrivingLicenseApp();
        }
    }
}
