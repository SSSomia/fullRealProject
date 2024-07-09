using businessLayer0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace fullRealProject
{
    public partial class add_editPerson : Form
    {
        private enum _enmode { addNew, edit };
        private _enmode _mode;
        private int _personID;
        public add_editPerson(int personID)
        {
            InitializeComponent();
            if (personID == -1) 
            { 
                _mode = _enmode.addNew;
                formTitle.Text = "ADD NEW CONTACT";

            }
            else
            {
                _personID = personID;
                _mode = _enmode.edit;
                formTitle.Text = "MODIFIY CONTACT";
                addEditPerson1.editPerson(_personID);
                addEditPerson1.endWithForm += endWithThisForm;
            }
        }
        private void endWithThisForm()
        {
            this.Close();
        }

    }
}
