using DVLD_AR.GeneralClasses;
using DVLD_AR.Licenses;
using DVLD_AR.Licenses.Controls;
using DVLD_AR.Licenses.Local_License;
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

namespace DVLD_AR.Applications.ReleaseDetainedLicense
{
    public partial class frmReleaseDetainedLicense : Form
    {
        public int _SelectedLicenseID = -1;

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenseID;
            ctrDriverLicenseInfoWithFilter1.LoadLicenseInfo( _SelectedLicenseID );
            ctrDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void ctrDriverLicenseInfoWithFilter1_OnLicenseSelected( int obj )
        {
            _SelectedLicenseID = obj;
            txtLicenseID.Text = _SelectedLicenseID.ToString();
            lblShowPersonsLicensesHistory.Enabled =(_SelectedLicenseID != -1) ;
            if ( _SelectedLicenseID == -1 )
                return;
            if ( !ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained )
            {
                MessageBox.Show( "هذه الرخصة غير محجوزة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            txtReleaseAppFees.Text = clsApplicationType.Find( ( int ) clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense ).Fees.ToString();
            txtCreatedBy.Text = clsGlobal.CurrentUser.UserName;

            txtDetainID.Text = ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
            txtLicenseID.Text = ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();

            txtDetainDate.Text = clsFormat.DateToShort( ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainDate );
            txtFineFees.Text = ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
            txtTottalFees.Text = ( Convert.ToSingle( txtReleaseAppFees.Text ) + Convert.ToSingle( txtFineFees.Text ) ).ToString();

            btnRelease.Enabled = true;
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void lblShowNewLicense_Click( object sender, EventArgs e )
        {
            frmShowLicenseInfo frm =
           new frmShowLicenseInfo( _SelectedLicenseID );
            frm.ShowDialog();
        }

        private void lblShowPersonsLicensesHistory_Click( object sender, EventArgs e )
        {
            frmShowPersonLicenseHistory frm =
             new frmShowPersonLicenseHistory( ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID );
            frm.ShowDialog();
        }

        private void btnRelease_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "هل تريد فك الحجز عن هذه الرخصة ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
            {
                return;
            }

            int ApplicationID = -1;


            bool IsReleased = ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseDetainedLicense( clsGlobal.CurrentUser.UserID, ref ApplicationID ); ;

            txtReleaseAppID.Text = ApplicationID.ToString();

            if ( !IsReleased )
            {
                MessageBox.Show( "لم تتم عملية فك الحجز عن الرخصة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            MessageBox.Show( "تمت عملية فك الحجز عن الرخضة بنجاح ", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information );

            btnRelease.Enabled = false;
            ctrDriverLicenseInfoWithFilter1.FilterEnabled = false;
            lblShowNewLicense.Enabled = true;
        }

        private void frmReleaseDetainedLicense_Activated( object sender, EventArgs e )
        {
            ctrDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
