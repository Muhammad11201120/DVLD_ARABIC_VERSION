using DVLD_AR.GeneralClasses;
using DVLD_AR.Licenses.Local_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_AR.Licenses.DetainLicense
{
    public partial class frmDetainLicenseApplication : Form
    {
        private int _DetainedId = -1;
        private int _SelectedLicenseID = -1;
        public frmDetainLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmDetainLicenseApplication_Load( object sender, EventArgs e )
        {
            txtDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            txtCrreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }

        private void ctrDriverLicenseInfoWithFilter1_OnLicenseSelected( int obj )
        {
            _SelectedLicenseID = obj;
            txtLicenseID.Text = _SelectedLicenseID.ToString();
            lblShowPersonsLicensesHistory.Enabled = ( _SelectedLicenseID != -1 );
            if ( _SelectedLicenseID == -1 )
            {
                return;
            }
            if ( ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained )
            {
                MessageBox.Show( "هذه الرخصة محجوزة مسبقا", "غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            txtDetainFees.Focus();
            btnDetain.Enabled = true;
        }

        private void btnDetain_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show("؟ هل أنت متأكد من حجز هذه الرخصة","تأكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.No )
            {
                return;
            }
            _DetainedId = ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Detain( Convert.ToSingle( txtDetainFees.Text ), clsGlobal.CurrentUser.UserID );
            if ( _DetainedId == -1 )
            {
                MessageBox.Show( "لم يتم حجز الرخصة حاول مرة أخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            txtDetainID.Text = _DetainedId.ToString();
            MessageBox.Show("تم حجز الرخصة بنجاح","تم الحجز",MessageBoxButtons.OK, MessageBoxIcon.Information );
            btnDetain.Enabled = false;
            ctrDriverLicenseInfoWithFilter1.FilterEnabled = false;
            txtDetainFees.Enabled = false;
            lblShowNewLicense.Enabled = true;
        }

        private void lblShowPersonsLicensesHistory_Click( object sender, EventArgs e )
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void lblShowNewLicense_Click( object sender, EventArgs e )
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmDetainLicenseApplication_Activated( object sender, EventArgs e )
        {
            ctrDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }

        private void txtDetainFees_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtDetainFees.Text.Trim() ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtDetainFees, "هذا الحقل مطلوب" );
                return;
            }
            else
            {
                errorProvider1.SetError( txtDetainFees, null );

            };


            if ( !clsValidatoin.IsNumber( txtDetainFees.Text ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtDetainFees, "هذا الحقل لابد ان يكون قيمة رقمية" );
            }
            else
            {
                errorProvider1.SetError( txtDetainFees, null );
            };
        }
    }
}
