using DVLD_AR.GeneralClasses;
using DVLD_AR.Licenses;
using DVLD_AR.Licenses.Controls;
using DVLD_AR.Licenses.International_License;
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

namespace DVLD_AR.Applications.International_License
{
    public partial class frmNewInterNationalLicenseApplication : Form
    {
        int _InterNationalLicenseID = -1;
        public frmNewInterNationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void ctrDriverLicenseInfoWithFilter1_OnLicenseSelected( int obj )
        {
            int _SelectedLicenseID = obj;
            txtLocalLicenseID.Text = _SelectedLicenseID.ToString();
            lblShowPersonsLicensesHistory.Enabled = ( _SelectedLicenseID != -1 );
            if ( _SelectedLicenseID == -1 )
                return;
            //check the license class, person could not issue international license without having
            //normal license of class 3.

            if ( ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClass != 3 )
            {
                MessageBox.Show( "لابد أن تكون الرخصة المصدر عليها رخصة قيادة إعتيادية الفئة 3", "غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            //check if person already have an active international license
            int ActiveInternaionalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID( ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID );

            if ( ActiveInternaionalLicenseID != -1 )
            {
                MessageBox.Show( "هذا الشخص لديه رخصة دولية فعّالة مسبقا ", "غسر مسموح", MessageBoxButtons.OK, MessageBoxIcon.Error );
                lblShowNewLicense.Enabled = true;
                _InterNationalLicenseID = ActiveInternaionalLicenseID;
                btnIssue.Enabled = false;
                return;
            }

            btnIssue.Enabled = true;
        }

        private void btnIssue_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "أنت على وشك القيام بإصدار رخصة دولية ؟؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
            {
                return;
            }

            clsInternationalLicense InternationalLicense = new clsInternationalLicense();
            //those are the information for the base application, because it inhirts from application, they are part of the sub class.

            InternationalLicense.ApplicantPersonID = ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = clsApplicationType.Find( ( int ) clsApplication.enApplicationType.NewInternationalLicense ).Fees;
            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;


            InternationalLicense.DriverID = ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears( 1 );

            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if ( !InternationalLicense.Save() )
            {
                MessageBox.Show( "حدث خطأ أثناء محاولة إصدار الرخصة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );

                return;
            }

            txtInterNationalLicenseAppID.Text = InternationalLicense.ApplicationID.ToString();
            _InterNationalLicenseID = InternationalLicense.InternationalLicenseID;
            txtInterNationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            MessageBox.Show( "تم إصدار الرخصة الدولية بنجاح", "تم الإصدار", MessageBoxButtons.OK, MessageBoxIcon.Information );

            btnIssue.Enabled = false;
            ctrDriverLicenseInfoWithFilter1.FilterEnabled = false;
            lblShowNewLicense.Enabled = true;
        }

        private void frmNewInterNationalLicenseApplication_Load( object sender, EventArgs e )
        {
            txtAppDate.Text = clsFormat.DateToShort( DateTime.Now );
            txtIssueDate.Text = txtAppDate.Text;
            txtExDate.Text = clsFormat.DateToShort( DateTime.Now.AddYears( 1 ) );//add one year.
            txtIsseFees.Text = clsApplicationType.Find( ( int ) clsApplication.enApplicationType.NewInternationalLicense ).Fees.ToString();
            txtUserID.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void lblShowNewLicense_Click( object sender, EventArgs e )
        {
            frmInternationalLicenseInfo frm =
              new frmInternationalLicenseInfo( _InterNationalLicenseID );
            frm.ShowDialog();
        }

        private void lblShowPersonsLicensesHistory_Click( object sender, EventArgs e )
        {
            frmShowPersonLicenseHistory frm =
                new frmShowPersonLicenseHistory( ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID );
            frm.ShowDialog();
        }

        private void frmNewInterNationalLicenseApplication_Activated( object sender, EventArgs e )
        {
            ctrDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
