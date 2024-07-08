using businessLayer0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace fullRealProject
{
    public partial class managePerson : Form
    {
        public managePerson()
        {
            InitializeComponent();
        }


        private void _loadListpeople()
        {
            listPeople.DataSource = clsPerson.getAllPerson();
        }

        private void managePerson_Load(object sender, EventArgs e)
        {
            _loadListpeople();
        }

        private void addNewPerson_Click(object sender, EventArgs e)
        {
            // make user control person info
            // link it with this button
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new showPersonDetails((int)listPeople.CurrentRow.Cells[0].Value);
            frm.Show();
        }
    }
}
