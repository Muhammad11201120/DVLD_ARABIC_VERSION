using DVLD_AR.Applications.LocalDrivingLicenseApplications;
using DVLD_AR.GeneralClasses;
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

namespace DVLD_AR.Licenses.Local_License
{
    public partial class frmIssueDriverLicenseForFirstTime : Form
    {
        private int _LocalDrivingLicenseApplicationID;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        public frmIssueDriverLicenseForFirstTime( int localDrivingLicenseAppID )
        {
            InitializeComponent();
            this._LocalDrivingLicenseApplicationID = localDrivingLicenseAppID;
        }

        private void frmIssueDriverLicenseForFirstTime_Load( object sender, EventArgs e )
        {
            txtNotes.Focus();
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID( _LocalDrivingLicenseApplicationID );

            if ( _LocalDrivingLicenseApplication == null )
            {

                MessageBox.Show( "لا يوجد طلب بهذا الرقم", "غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Error );
                this.Close();
                return;
            }


            if ( !_LocalDrivingLicenseApplication.PassedAllTests() )
            {

                MessageBox.Show( "يجب على المتقدم تجاوز جميع الإختبارات أولا..", "غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Error );
                this.Close();
                return;
            }

            int LicenseID = _LocalDrivingLicenseApplication.GetActiveLicenseID();
            if ( LicenseID != -1 )
            {

                MessageBox.Show( "المتقدم لديه هذه الرخصة مسبقا", "غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Error );
                this.Close();
                return;
            }

            ctrDrivingLicenseApplicationInfo1.LoadInfoByLocalDrivingAppID( _LocalDrivingLicenseApplicationID );
        }

        private void btnIssueLicense_Click( object sender, EventArgs e )
        {
            int LicenseID = _LocalDrivingLicenseApplication.IssueLicenseForTheFirtTime( txtNotes.Text.Trim(), clsGlobal.CurrentUser.UserID );

            if ( LicenseID != -1 )
            {
                MessageBox.Show( "تم إصدار الرخصة بنجاح" + LicenseID.ToString(),
                    "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information );

                this.Close();
            }
            else
            {
                MessageBox.Show( "لم تصدر الرخصة ! ",
                 "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
