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
    public partial class dashBoard : Form
    {
        //public event Action onPersonClicked;
        //// Create a protected method to raise the event with a parameter
        //protected virtual void personClicked()
        //{
        //    Action handler = onPersonClicked;
        //    if (handler != null)
        //    {
        //        handler(); // Raise the event with the parameter
        //    }
        //}
        public dashBoard()
        {
            InitializeComponent();
        }

        private void PersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (onPersonClicked != null)
            //{
            //    personClicked();
            //}
            Form frm = new managePerson();
            frm.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new manageUsers();
            frm.ShowDialog();
        }
    }
}
