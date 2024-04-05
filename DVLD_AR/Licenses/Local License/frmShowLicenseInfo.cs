using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_AR.Licenses.Local_License
{
    public partial class frmShowLicenseInfo : Form
    {
        private int _LicenseID = -1;

        public frmShowLicenseInfo( int licenseID )
        {
            InitializeComponent();
            this._LicenseID = licenseID;
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmShowLicenseInfo_Load( object sender, EventArgs e )
        {
            ctrDriverLicenseInfo1.LoadInfo( this._LicenseID );
        }
    }
}
