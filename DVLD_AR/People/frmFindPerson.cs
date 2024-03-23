using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_AR.People
{
    public partial class frmFindPerson : Form
    {
        // Declare A Delegate
        public delegate void DataBackEventHandler( object sender, int PersonID);
        // Declare An Event Of The Delegate Type
        public event DataBackEventHandler DataBack;
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            DataBack?.Invoke(this, ctrPersonCardWithFilter1.PersonId);
        }
    }
}
