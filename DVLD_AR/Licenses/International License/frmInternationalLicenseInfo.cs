using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_AR.Licenses.International_License
{
    public partial class frmInternationalLicenseInfo : Form
    {
        private int _InterNationalLicenseID = -1;
        public frmInternationalLicenseInfo( int InternationalLicenseID )
        {
            InitializeComponent();
            this._InterNationalLicenseID = InternationalLicenseID;
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmInternationalLicenseInfo_Load( object sender, EventArgs e )
        {
            ctrInterNationalLicenseInfo1.LoadInfo( _InterNationalLicenseID );
        }
    }
}
