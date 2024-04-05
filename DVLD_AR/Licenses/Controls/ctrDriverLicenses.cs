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

namespace DVLD_AR.Licenses.Controls
{
    public partial class ctrDriverLicenses : UserControl
    {
        private int _DriverID;
        private clsDriver _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;
        public ctrDriverLicenses()
        {
            InitializeComponent();
        }
        private void _LoadLocalLicenseInfo()
        {

            _dtDriverLocalLicensesHistory = clsDriver.GetLicenses( _DriverID );


            dgvLocalLicensesHistory.DataSource = _dtDriverLocalLicensesHistory;
            lblLocalLicensesRecords.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

            if ( dgvLocalLicensesHistory.Rows.Count > 0 )
            {
                dgvLocalLicensesHistory.Columns[ 0 ].HeaderText = "رقم الرخصة";
                dgvLocalLicensesHistory.Columns[ 0 ].Width = 110;

                dgvLocalLicensesHistory.Columns[ 1 ].HeaderText = "رقم الطلب";
                dgvLocalLicensesHistory.Columns[ 1 ].Width = 110;

                dgvLocalLicensesHistory.Columns[ 2 ].HeaderText = "نوع الرخصة";
                dgvLocalLicensesHistory.Columns[ 2 ].Width = 270;

                dgvLocalLicensesHistory.Columns[ 3 ].HeaderText = "تاريخ الإصدار";
                dgvLocalLicensesHistory.Columns[ 3 ].Width = 170;

                dgvLocalLicensesHistory.Columns[ 4 ].HeaderText = "تاريخ الإنتهاء";
                dgvLocalLicensesHistory.Columns[ 4 ].Width = 170;

                dgvLocalLicensesHistory.Columns[ 5 ].HeaderText = "حالة الرخصة";
                dgvLocalLicensesHistory.Columns[ 5 ].Width = 110;

            }
        }

        private void _LoadInternationalLicenseInfo()
        {

            _dtDriverInternationalLicensesHistory = clsDriver.GetInternationalLicenses( _DriverID );


            dgvInternationalLicensesHistory.DataSource = _dtDriverInternationalLicensesHistory;
            lblInternationalLicensesRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();

            if ( dgvInternationalLicensesHistory.Rows.Count > 0 )
            {
                dgvInternationalLicensesHistory.Columns[ 0 ].HeaderText = "رقم الرخصة";
                dgvInternationalLicensesHistory.Columns[ 0 ].Width = 160;

                dgvInternationalLicensesHistory.Columns[ 1 ].HeaderText = "رقم الطلب";
                dgvInternationalLicensesHistory.Columns[ 1 ].Width = 130;

                dgvInternationalLicensesHistory.Columns[ 2 ].HeaderText = "رقم الرخصة المحلية";
                dgvInternationalLicensesHistory.Columns[ 2 ].Width = 130;

                dgvInternationalLicensesHistory.Columns[ 3 ].HeaderText = "تاريخ الإصدار";
                dgvInternationalLicensesHistory.Columns[ 3 ].Width = 180;

                dgvInternationalLicensesHistory.Columns[ 4 ].HeaderText = "تاريخ الإنتهاء";
                dgvInternationalLicensesHistory.Columns[ 4 ].Width = 180;

                dgvInternationalLicensesHistory.Columns[ 5 ].HeaderText = "حالظ الرخصة";
                dgvInternationalLicensesHistory.Columns[ 5 ].Width = 120;

            }
        }

        public void LoadInfo( int DriverID )
        {
            _DriverID = DriverID;
            _Driver = clsDriver.FindByDriverID( _DriverID );
            if ( _Driver == null )
            {
                MessageBox.Show( "لايوجد سائق بهذا الرقم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();

        }

        public void LoadInfoByPersonID( int PersonID )
        {

            _Driver = clsDriver.FindByPersonID( PersonID );
            if ( _Driver == null )
            {
                MessageBox.Show( "لايوجد سائق بهذا الرقم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            _DriverID = _Driver.DriverID;
            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }

        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();
            _dtDriverInternationalLicensesHistory.Clear();
        }

        private void معلوماتالرخصةالمحليةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int LicenseID = ( int ) dgvLocalLicensesHistory.CurrentRow.Cells[ 0 ].Value;
            frmShowLicenseInfo frm = new frmShowLicenseInfo( LicenseID );
            frm.ShowDialog();
        }

        private void معلوماتالرخصةالدوليةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int InternationalLicenseID = ( int ) dgvInternationalLicensesHistory.CurrentRow.Cells[ 0 ].Value;
            //frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo( InternationalLicenseID );
            //frm.ShowDialog();
        }
    }
}
