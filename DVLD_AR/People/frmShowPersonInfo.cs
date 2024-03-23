using DVLD_AR.People.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_AR.People.Controllers;
namespace DVLD_AR.People
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int personID)
        {
            InitializeComponent();
            ctrPersonCard1.LoadPerson(personID);
        }
        public frmShowPersonInfo( string nationalNo )
        {
            InitializeComponent();
            ctrPersonCard1.LoadPerson( nationalNo );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
