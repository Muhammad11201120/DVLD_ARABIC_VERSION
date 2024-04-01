using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_AR.Applications.LocalDrivingLicenseApplications
{
    public partial class frmLocalDrivingLicenseInfo : Form
    {
        private int _ApplicationID = -1;
        public frmLocalDrivingLicenseInfo( int ApplicationID )
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
        }

        private void frmLocalDrivingLicenseInfo_Load( object sender, EventArgs e )
        {
            ctrDrivingLicenseApplicationInfo1.LoadInfoByLocalDrivingAppID( _ApplicationID );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
