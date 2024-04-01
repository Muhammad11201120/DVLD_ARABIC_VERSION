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
    public partial class frmAllLocalDrivingApplicationsList : Form
    {
        DataTable dt = null;
        DataView dv = null;
        public frmAllLocalDrivingApplicationsList()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            dt = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            if ( dt.Rows.Count > 0 )
            {
                dv = new DataView( dt );
                dataGridView1.DataSource = dv;
            }
            cbxFilters.SelectedIndex = 0;
            lblRecords.Text = dv.Count.ToString();
        }

        private void frmAllLocalDrivingApplicationsList_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void btnAddNewLocalLicenseApplication_Click( object sender, EventArgs e )
        {
            frmAddEditLocaLDrivingLicenseApplication frm = new frmAddEditLocaLDrivingLicenseApplication();
            frm.ShowDialog();
            _LoadData();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void txtFilter_TextChanged( object sender, EventArgs e )
        {
            string FilterColumn = string.Empty;
            switch ( cbxFilters.Text )
            {
                case "المعرٌف":
                    FilterColumn = "المعرٌف";
                    break;
                case "الهويٌة":
                    FilterColumn = "الهويٌة";
                    break;
                case "الإسم":
                    FilterColumn = "الإسم";
                    break;
                case "الحالة":
                    FilterColumn = "الحالة";
                    break;
                default:
                    FilterColumn = "لاشئ";
                    break;
            }
            //Reset the filters in case of empty string or 
            if ( txtFilter.Text.Trim() == string.Empty || FilterColumn == "لاشئ" )
            {
                dv.RowFilter = string.Empty;
                lblRecords.Text = dv.Count.ToString();
                return;
            }
            if ( FilterColumn == "المعرٌف" )
                dv.RowFilter = string.Format( "[{0}] = {1}", FilterColumn, txtFilter.Text.Trim() );
            else
                dv.RowFilter = string.Format( "[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim() );

            lblRecords.Text = dv.Count.ToString();
        }

        private void txtFilter_KeyPress( object sender, KeyPressEventArgs e )
        {
            //we allow number incase person id is selected.
            if ( cbxFilters.Text == "المعرٌف" )
                e.Handled = !char.IsDigit( e.KeyChar ) && !char.IsControl( e.KeyChar );
        }

        private void تعديلالطلبToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAddEditLocaLDrivingLicenseApplication frm = new frmAddEditLocaLDrivingLicenseApplication( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            frm.ShowDialog();
            _LoadData();
        }

        private void إظهارمعلوماتالToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmLocalDrivingLicenseInfo frm = new frmLocalDrivingLicenseInfo( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            frm.ShowDialog();
            _LoadData();
        }

        private void حذفالطلبToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "هل انت متأكد من إجراء عملية الحذف؟", "تأكيد", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information ) == DialogResult.No )
                return;
            clsLocalDrivingLicenseApplication LocalDrivinLicenseApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            if ( LocalDrivinLicenseApp != null )
            {
                if ( LocalDrivinLicenseApp.Delete() )
                {
                    MessageBox.Show( "تم حذف الطلب بنجاح", "تمت عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    _LoadData();
                }
                else
                {
                    MessageBox.Show( "لم يتم حذف الطلب بنجاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        private void إالغاءالطلبToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "هل انت متأكد من إجراء عملية الإلغاء؟", "تأكيد", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information ) == DialogResult.No )
                return;
            clsLocalDrivingLicenseApplication LocalDrivinLicenseApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            if ( LocalDrivinLicenseApp != null )
            {
                if ( LocalDrivinLicenseApp.Cancel() )
                {
                    MessageBox.Show( "تم إلغاء الطلب بنجاح", "تمت عملية الإلغاء", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    _LoadData();
                }
                else
                {
                    MessageBox.Show( "لم يتم إلغاء الطلب بنجاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        private void cbxFilters_SelectedIndexChanged( object sender, EventArgs e )
        {
            txtFilter.Visible = ( cbxFilters.Text != "لاشئ" );
            if ( txtFilter.Visible )
            {
                txtFilter.Text = string.Empty;
                txtFilter.Focus();
            }
            dv.RowFilter = string.Empty;
            lblRecords.Text = dv.Count.ToString();
        }

        private void contextMenuStrip1_Opening( object sender, CancelEventArgs e )
        {
            int LocalDrivingLicenseApplicationID = ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID( LocalDrivingLicenseApplicationID );

            int TotalPassedTests = ( int ) dataGridView1.CurrentRow.Cells[ 5 ].Value;

            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();

            //Enabled only if person passed all tests and Does not have license. 
            إصدارالرخصةأولمرةToolStripMenuItem.Enabled = ( TotalPassedTests == 3 ) && !LicenseExists;

            إظهارالرخصةToolStripMenuItem.Enabled = LicenseExists;
            تعديلالطلبToolStripMenuItem.Enabled = !LicenseExists && ( LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New );
            جدولةالإختباراتToolStripMenuItem.Enabled = ( TotalPassedTests < 3 );

            //Enable/Disable Cancel Menue Item
            //We only canel the applications with status=new.
            إالغاءالطلبToolStripMenuItem.Enabled = ( LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New );

            //Enable/Disable Delete Menue Item
            //We only allow delete incase the application status is new not complete or Cancelled.
            حذفالطلبToolStripMenuItem.Enabled =
                ( LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New );



            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType( clsTestType.enTestType.VisionTest ); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType( clsTestType.enTestType.WrittenTest );
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType( clsTestType.enTestType.StreetTest );

            جدولةالإختباراتToolStripMenuItem.Enabled = ( !PassedVisionTest || !PassedWrittenTest || !PassedStreetTest ) && ( LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New );

            if ( جدولةالإختباراتToolStripMenuItem.Enabled )
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                إختبارالنظرToolStripMenuItem.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                الإختبارالكتابيToolStripMenuItem.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                إختبارالميدانالعمليToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }
        }

        private void إصدارالرخصةأولمرةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            //int LocalDrivingLicenseApplicationID = ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value;
            //frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime( LocalDrivingLicenseApplicationID );
            //frm.ShowDialog();
            ////refresh
            //_LoadData();
        }

        private void إظهارالرخصةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int LicenseID = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value ).GetActiveLicenseID();
            //if ( LicenseID != -1 )
            //{
            //    frmShowLicenseInfo frm = new frmShowLicenseInfo( LicenseID );
            //    frm.ShowDialog();

            //}
            //else
            //{
            //    MessageBox.Show( "لا توجد رخصة!", "لاتوجد رخصة", MessageBoxButtons.OK, MessageBoxIcon.Error );
            //    return;
            //}
        }

        private void تاريخرخصالمستفيدToolStripMenuItem_Click( object sender, EventArgs e )
        {
            //clsLocalDrivingLicenseApplication LocalDrivingLicenseApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            //Show Person Licenses history
            //frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory( LocalDrivingLicenseApp.ApplicantPersonID );
            //frm.ShowDialog();
        }
        private void ScheduleTest( clsTestType.enTestType TestType )
        {
            int LocalDrivingLicenseApplicationID = ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID( LocalDrivingLicenseApplicationID );
            //frmScheduleTest frm = new frmScheduleTest( LocalDrivingLicenseApplicationID, TestType );
            //frm.ShowDialog();
            //refresh
            _LoadData();
        }
        private void إختبارالنظرToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ScheduleTest( clsTestType.enTestType.VisionTest );
        }

        private void الإختبارالكتابيToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ScheduleTest( clsTestType.enTestType.WrittenTest );
        }

        private void إختبارالميدانالعمليToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ScheduleTest( clsTestType.enTestType.StreetTest );
        }
    }
}
