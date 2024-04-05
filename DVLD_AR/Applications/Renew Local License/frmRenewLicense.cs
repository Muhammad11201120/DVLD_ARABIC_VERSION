using DVLD_AR.GeneralClasses;
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

namespace DVLD_AR.Applications.Renew_Local_License
{
    public partial class frmRenewLicense : Form
    {
        private int _NewLicenseID = -1;

        public frmRenewLicense()
        {
            InitializeComponent();
        }

        private void frmRenewLicense_Load( object sender, EventArgs e )
        {
            ctrDriverLicenseInfoWithFilter1.txtLicenseIDFocus();


            txtAppDate.Text = clsFormat.DateToShort( DateTime.Now );
            txtIssueDate.Text = txtAppDate.Text;

            txtExDate.Text = "???";
            txtAppFees.Text = clsApplicationType.Find( ( int ) clsApplication.enApplicationType.RenewDrivingLicense ).Fees.ToString();
            txtCreatedByName.Text = clsGlobal.CurrentUser.UserName;
        }

        private void ctrDriverLicenseInfoWithFilter1_OnLicenseSelected( int obj )
        {
            int SelectedLicenseID = obj;

            txtOldLicenseID.Text = SelectedLicenseID.ToString();

            lblShowPersonsLicensesHistory.Enabled = ( SelectedLicenseID != -1 );

            if ( SelectedLicenseID == -1 )
            {
                return;
            }

            int DefaultValidityLength = ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.DefaultValidityLength;
            txtExDate.Text = clsFormat.DateToShort( DateTime.Now.AddYears( DefaultValidityLength ) );
            txtLicenseFees.Text = ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassIfo.ClassFees.ToString();
            txtTotalFees.Text = ( Convert.ToSingle( txtAppFees.Text ) + Convert.ToSingle( txtLicenseFees.Text ) ).ToString();
            txtNotes.Text = ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;


            //check the license is not Expired.
            if ( !ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired() )
            {
                MessageBox.Show( "هذه الرخصة غير منتهية تنتهي في تاريخ : " + clsFormat.DateToShort( ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate )
                    , "غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Error );
                btnRenew.Enabled = false;
                return;
            }

            //check the license is not Expired.
            if ( !ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive )
            {
                MessageBox.Show( "الرخصة المختارة غير نشطة"
                    , "غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Error );
                btnRenew.Enabled = false;
                return;
            }



            btnRenew.Enabled = true;
        }

        private void btnRenew_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "هل أنت متأكد من تجديد الرخصة ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
            {
                return;
            }


            clsLicense NewLicense =
                ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense( txtNotes.Text.Trim(),
                clsGlobal.CurrentUser.UserID );

            if ( NewLicense == null )
            {
                MessageBox.Show( "فشل في تجديد الرخصة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );

                return;
            }

            txtRenewAppID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            txtNewLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show( "تم تجديد الرخصة الرخصة المجددة برقم = " + _NewLicenseID.ToString(), "تم التجديد", MessageBoxButtons.OK, MessageBoxIcon.Information );

            btnRenew.Enabled = false;
            ctrDriverLicenseInfoWithFilter1.FilterEnabled = false;
            lblShowNewLicense.Enabled = true;


        }

        private void frmRenewLicense_Activated( object sender, EventArgs e )
        {
            ctrDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }

        private void lblShowPersonsLicensesHistory_Click( object sender, EventArgs e )
        {
            // frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory( ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.PersonID );
            // frm.ShowDialog();
        }

        private void lblShowNewLicense_Click( object sender, EventArgs e )
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo( _NewLicenseID );
            frm.ShowDialog();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
