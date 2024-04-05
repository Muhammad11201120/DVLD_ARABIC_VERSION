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
using static DVLD_Buisness.clsLicense;

namespace DVLD_AR.Applications.Replace_Lost_Or_Damaged_License
{
    public partial class frmReplacementForDamagedOrLostLicense : Form
    {
        private int _NewLicenseID = -1;
        public frmReplacementForDamagedOrLostLicense()
        {
            InitializeComponent();
        }
        private int _GetApplicationTypeID()
        {
            //this will decide which application type to use accirding 
            // to user selection.

            if ( rbDamagedLicense.Checked )

                return ( int ) clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return ( int ) clsApplication.enApplicationType.ReplaceLostDrivingLicense;
        }
        private enIssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if ( rbDamagedLicense.Checked )

                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }
        private void frmReplacementForDamagedOrLostLicense_Load( object sender, EventArgs e )
        {
            txtAppDate.Text = clsFormat.DateToShort( DateTime.Now );
            txtCreatedByName.Text = clsGlobal.CurrentUser.UserName;

            rbDamagedLicense.Checked = true;
        }
        private void frmReplacementForDamagedOrLostLicense_Activated( object sender, EventArgs e )
        {
            ctrDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void lblShowNewLicense_Click( object sender, EventArgs e )
        {
            frmShowLicenseInfo frm =
                 new frmShowLicenseInfo( _NewLicenseID );
            frm.ShowDialog();
        }

        private void lblShowPersonsLicensesHistory_Click( object sender, EventArgs e )
        {
            // frmShowPersonLicenseHistory frm =
            //new frmShowPersonLicenseHistory( ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID );
            // frm.ShowDialog();
        }

        private void btnIssueReplacement_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No )
            {
                return;
            }


            clsLicense NewLicense =
               ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Replace( _GetIssueReason(),
               clsGlobal.CurrentUser.UserID );

            if ( NewLicense == null )
            {
                MessageBox.Show( "Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );

                return;
            }

            txtAppDate.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;

            txtNewLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show( "Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information );

            btnIssueReplacement.Enabled = false;
            gbReplacementFor.Enabled = false;
            ctrDriverLicenseInfoWithFilter1.FilterEnabled = false;
            lblShowNewLicense.Enabled = true;
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void rbDamagedLicense_CheckedChanged( object sender, EventArgs e )
        {
            lblTilte.Text = "Replacement for Damaged License";
            this.Text = lblTilte.Text;
            txtAppFees.Text = clsApplicationType.Find( _GetApplicationTypeID() ).Fees.ToString();
        }

        private void rbLostLicense_CheckedChanged( object sender, EventArgs e )
        {
            lblTilte.Text = "Replacement for Lost License";
            this.Text = lblTilte.Text;
            txtAppFees.Text = clsApplicationType.Find( _GetApplicationTypeID() ).Fees.ToString();
        }

        private void ctrDriverLicenseInfoWithFilter1_OnLicenseSelected( int obj )
        {
            int SelectedLicenseID = obj;
            txtPldLicenseID.Text = SelectedLicenseID.ToString();
            lblShowPersonsLicensesHistory.Enabled = ( SelectedLicenseID != -1 );

            if ( SelectedLicenseID == -1 )
            {
                return;
            }

            //dont allow a replacement if is Active .
            if ( !ctrDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive )
            {
                MessageBox.Show( "Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error );
                btnIssueReplacement.Enabled = false;
                return;
            }

            btnIssueReplacement.Enabled = true;
        }


    }
}
