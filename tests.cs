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
using testTypesBusiness;

namespace fullRealProject
{
    public partial class tests : Form
    {
        private int _applicationID;
        private string _title;
        private int _passedTests;
        private int _testTID;
        private int _trial = 0;
        public tests(string title, int applicationID, string licenseClass, int passedTests)
        {
            InitializeComponent();
            _title = title;
            _passedTests = passedTests;
            label1.Text = title;
           _applicationID = applicationID;
            _testTID = _testTypeID(passedTests);
            applicationInfoUC1.showData(applicationID, licenseClass, passedTests);
        }
        private int _testTypeID(int passedTests)
        {
            if (passedTests == 0)
            {
                return 1;
            }
            else if (passedTests == 1)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        private void _loadtests()
        {
            testApp.DataSource = clsPersonTest.getAllTests(_applicationID, _testTID);
        }
        private void addAppointment_Click(object sender, EventArgs e)
        {
            // get all apointment to this appointment datagridview
            Form frm = new addEditTest(_applicationID, _title, _testTID, _trial + 1);
            frm.ShowDialog();
        }

        private void tests_Load(object sender, EventArgs e)
        {
            _loadtests();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dealWithTest_Opening(object sender, CancelEventArgs e)
        {
            if ((bool)testApp.CurrentRow.Cells[4].Value || (bool)testApp.CurrentRow.Cells[3].Value)
            {
                dealWithTest.Enabled = false;
            }
        }

        private void testApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new addEditTest(-1, _testTID);
            frm.ShowDialog();
            _loadtests();
        }
    }
}
