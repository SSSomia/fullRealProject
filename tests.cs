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
using static System.Net.Mime.MediaTypeNames;

namespace fullRealProject
{
    public partial class tests : Form
    {
        private int _applicationID;
        private string _title;
        private int _passedTests;
         private int _testTID;
        static private int _trial = 0;
        private bool isLastAppLocked = false;
        string license;

        public tests(string title, int applicationID, string licenseClass, int passedTests)
        {
            InitializeComponent();
            _title = title;
            _passedTests = passedTests;
            label1.Text = title;
           _applicationID = applicationID;
            _testTID = _testTypeID(passedTests);
            license = licenseClass;

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
            if (isLastAppLocked) { addAppointment.Enabled = false; }
        }
        private void addAppointment_Click(object sender, EventArgs e)
        {
            // total fees add the retake test fees at firsttime
            Form frm = new addEditTest(_applicationID, _title, _testTID, clsPersonTest.numOfRowAndTrials(_applicationID, _testTID));
            frm.ShowDialog();
            _loadtests();
            _isTestPassed();
        }


        private void _isTestPassed()
        {
            if (clsPersonTest.numOfRowAndTrials(_applicationID, _testTID) != 0)
            {
                if ((bool)testApp.Rows[testApp.Rows.Count - 1].Cells[3].Value)
                {
                    isLastAppLocked = true;
                    addAppointment.Enabled = false;
                    applicationInfoUC1.showData(_applicationID, license, _passedTests + 1);
                }
                else if ((bool)testApp.Rows[testApp.Rows.Count - 1].Cells[4].Value)
                {
                    isLastAppLocked = true;
                    addAppointment.Enabled = true;
                }
                else
                {
                    isLastAppLocked = false;
                    addAppointment.Enabled = false;
                }
            }
            else
            {
                isLastAppLocked = false;
                addAppointment.Enabled = true;
            }
        }

        private void tests_Load(object sender, EventArgs e)
        {
            applicationInfoUC1.showData(_applicationID, license, _passedTests);
            _loadtests();
            _isTestPassed();
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
            else
            {
                dealWithTest.Enabled =true;
            }
        }

        private void testApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new addEditTest(-1, _testTID, _applicationID, (int)testApp.CurrentRow.Cells[0].Value, (DateTime)testApp.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _loadtests();
        }

        private void takeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new takeTest((int)testApp.CurrentRow.Cells[0].Value, _applicationID);
            frm.ShowDialog();
            _loadtests();
            _isTestPassed();
        }
    }
}


// not pushed