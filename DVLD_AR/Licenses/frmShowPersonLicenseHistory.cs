using DVLD_AR.Licenses.Controls;
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

namespace DVLD_AR.Licenses
{
    public partial class frmShowPersonLicenseHistory : Form
    {
        private int _PersonID = -1;
        public frmShowPersonLicenseHistory()
        {
            InitializeComponent();
        }
        public frmShowPersonLicenseHistory( int personID )
        {
            InitializeComponent();
            this._PersonID = personID;
        }
        private void frmShowPersonLicenseHistory_Load( object sender, EventArgs e )
        {
            if ( _PersonID != -1 )
            {
                ctrPersonCardWithFilter1.LoadPersonInfo( _PersonID );
                ctrPersonCardWithFilter1.FilterEnabled = false;
                ctrDriverLicenses1.LoadInfoByPersonID( _PersonID );
            }
            else
            {
                ctrPersonCardWithFilter1.Enabled = true;
                ctrPersonCardWithFilter1.FilterFocus();
            }
        }

        private void ctrPersonCardWithFilter1_OnPersonSelected( int obj )
        {
            _PersonID = obj;
            if ( _PersonID == -1 )
            {
                ctrDriverLicenses1.Clear();
            }
            else
                ctrDriverLicenses1.LoadInfoByPersonID( _PersonID );
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
