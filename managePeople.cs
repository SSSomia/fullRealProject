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
            listPerson.DataSource = clsPerson.getAllPerson();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _loadListpeople();
        }

        private void managePerson_Load(object sender, EventArgs e)
        {

        }
    }
}
