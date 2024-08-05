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
using testTypesBusiness;
using static System.Net.Mime.MediaTypeNames;

namespace fullRealProject
{
    public partial class addEditTest : Form
    {
        bool edit = false;
        clsPersonTest _personTest;
        private int testID = 0;
        private int tFees = 0;
        private int applicationID = 0;
        private int trial = 0;
        private string _title;

        public addEditTest(int applicationID, string title, int testTypeID, int trial )
        {
            InitializeComponent();
            _title = title;
             testID = testTypeID; 
            this.applicationID = applicationID;
            this.trial = trial;
            _intialFields();
        }
        public addEditTest(int num, int testTypeID)
        {
            InitializeComponent();
            if (num == -1)
            {
                edit = true;
                _loadData(testTypeID);
                _dataInEditMode();
            }
        }
        private int _totalFees(int trial, int id)
        {
            int fees = clsTestType.testFess(id);

            if (trial != 1)
            {
                fees += clsTestType.testRetakeFees(id);
            }
            return fees;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private clsPersonTest _fillData()
        {
            _personTest = new clsPersonTest(applicationID, testID, false, dateTimePicker1.Value.Date , trial, tFees, false);
            return _personTest;
        }
        private clsPersonTest _loadData(int testTypeID)
        {
            _personTest = clsPersonTest.printPersonTest(testTypeID);
            return _personTest;
        }

        private void _dataInEditMode()
        {
            dateTimePicker1.Value = _personTest.createdDate;
            totalFees.Text = _personTest.totalFees.ToString();
            formTitle.Text = _title;
            Trial.Text = _personTest.trial.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                clsPersonTest.updatePersonTest(dateTimePicker1.Value.Date, _personTest.personTestID);
            }
            else
                clsPersonTest.addNewTest(_fillData());
            this.Close();
        }

        private void _intialFields()
        {
            dateTimePicker1.MinDate = DateTime.Now;
            tFees = _totalFees(trial, testID);
            totalFees.Text = tFees.ToString();
            formTitle.Text = _title;
            Trial.Text = trial.ToString();
        }

        private void addEditTest_Load(object sender, EventArgs e)
        {
           
        }
    }
}
