using DVLD_Buisness;
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
    public partial class ctrDrivingLicenseApplicationInfo : UserControl
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication = null;
        private int _LicenseID = -1;
        public int LocalDrivingLicenseApplicationID
        {
            get { return _LocalDrivingLicenseApplicationID; }
        }

        public ctrDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        public void ResetDefaultValues()
        {
            _LocalDrivingLicenseApplicationID = -1;
            txtLocalLicenseAppID.Text = "???";
            txtLicenseType.Text = "???";
            txtPassedTests.Text = "???";
        }
        public void LoadInfoByLocalDrivingAppID( int localDrivingAppID )
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID( localDrivingAppID );
            if ( _LocalDrivingLicenseApplication == null )
            {
                ResetDefaultValues();
                MessageBox.Show( ToString(), "الطلب غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            FillInfo();

        }
        public void LoadInfoByApplicantID( int applicantID )
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByApplicationID( applicantID );
            if ( _LocalDrivingLicenseApplication == null )
            {
                ResetDefaultValues();
                MessageBox.Show( ToString(), "الطلب غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            FillInfo();

        }
        public void FillInfo()
        {

            _LicenseID = _LocalDrivingLicenseApplication.GetActiveLicenseID();

            //incase there is license enable the show link.
            llLicenseInfo.Enabled = ( _LicenseID != -1 );


            txtLocalLicenseAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            txtLicenseType.Text = clsLicenseClass.Find( _LocalDrivingLicenseApplication.LicenseClassID ).ClassName;
            txtPassedTests.Text = _LocalDrivingLicenseApplication.GetPassedTestCount().ToString() + "/3";
            ctrApplicationBiscInfo1.LoadData( _LocalDrivingLicenseApplication.ApplicationID );
        }

        private void llLicenseInfo_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            //show license info
        }
    }
}
