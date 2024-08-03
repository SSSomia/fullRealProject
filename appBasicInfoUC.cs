using appBusiness;
using businessLayer0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullRealProject
{
    public partial class appBasicInfoUC : UserControl
    {
        clsApp _app;
        private int _appID = 0;

        public appBasicInfoUC()
        {
            InitializeComponent();
        }
        public void showData(int id)
        {
            this._appID = id;
            _loadInfo();
        }

        private void _showPersonData()
        {
            Form frm = new personInfo(clsApp.getPersonID(_appID));
            frm.ShowDialog();
        }
        private void _loadInfo()
        {
            _app = clsApp.printApp(_appID);
            _showData(clsApp.getApplicationType(_app.applicationTypeID), clsApp.getApplicantName(_app.personID),clsApp.getUserName(_app.userID));
        }

        private void _showData(string type0, string applicant0, string createdBy0)
        {
            status.Text = _app.applicationState.ToString();
            fees.Text = _app.fees.ToString();
            date.Text = _app.createdDate.ToString("dd/MM/yyyy");
            createdBy.Text = createdBy0.ToString();
            applicant.Text = applicant0.ToString();
            type.Text = type0;
        }

        private void appBasicInfoUC_Load(object sender, EventArgs e)
        {

        }

        private void showPersonData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _showPersonData();
        }
    }
}
