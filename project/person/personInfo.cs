using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullRealProject
{
    public partial class personInfo : Form
    {
        private int _presonID;
        public personInfo(int index)
        {
            InitializeComponent();
            personInfoUC1.showData(index);
            _presonID = index;
        }

        private void editPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new add_editPerson(_presonID);
            frm.ShowDialog();
            personInfoUC1.showData(_presonID);

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personInfoUC1_Load(object sender, EventArgs e)
        {

        }

        private void personInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
