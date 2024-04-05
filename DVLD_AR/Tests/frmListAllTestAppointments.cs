using DVLD_AR.Properties;
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
using static DVLD_Buisness.clsTestType;

namespace DVLD_AR.Tests.TestTypes
{
    public partial class frmListAllTestAppointments : Form
    {
        DataTable dt = null;
        DataView dv = null;
        private int _LocalDrivingLicenseApplicationID;
        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;

        public frmListAllTestAppointments( int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestType )
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;
        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch ( _TestType )
            {

                case clsTestType.enTestType.VisionTest:
                    {
                        lblTitle.Text = "مواعيد إختبار النظر";
                        this.Text = lblTitle.Text;
                        pbTestType.Image = Resources.Vision_512;
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        lblTitle.Text = "مواعيد الإختبار النظري - الكتابي";
                        this.Text = lblTitle.Text;
                        pbTestType.Image = Resources.Written_Test_512;
                        break;
                    }
                case clsTestType.enTestType.StreetTest:
                    {
                        lblTitle.Text = "مواعيد الإختبار الميداني - العملي";
                        this.Text = lblTitle.Text;
                        pbTestType.Image = Resources.driving_test_512;
                        break;
                    }
            }
        }

        private void frmListAllTestAppointments_Load( object sender, EventArgs e )
        {
            _LoadTestTypeImageAndTitle();
            ctrDrivingLicenseApplicationInfo1.LoadInfoByLocalDrivingAppID( _LocalDrivingLicenseApplicationID );
            dt = clsTestAppointment.GetApplicationTestAppointmentsPerTestType( _LocalDrivingLicenseApplicationID, _TestType );
            if ( dt.Rows.Count > 0 )
            {
                dv = new DataView( dt );
                dataGridView1.DataSource = dv;
            }
        }

        private void btnAddAppointment_Click( object sender, EventArgs e )
        {
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID( _LocalDrivingLicenseApplicationID );


            if ( localDrivingLicenseApplication.IsThereAnActiveScheduledTest( _TestType ) )
            {
                MessageBox.Show( "لايمكن تحديد موعد اخر زز نظرا لوجود موعد نشط لهذا الشخص", "غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }



            //---
            clsTest LastTest = localDrivingLicenseApplication.GetLastTestPerTestType( _TestType );

            if ( LastTest == null )
            {
                frmScheduleTest frm1 = new frmScheduleTest( _LocalDrivingLicenseApplicationID, _TestType );
                frm1.ShowDialog();
                frmListAllTestAppointments_Load( null, null );
                return;
            }

            //if person already passed the test s/he cannot retake it.
            if ( LastTest.TestResult == true )
            {
                MessageBox.Show( "هذا الشخص اجتاز هذا الإختبار مسبقا", "غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            frmScheduleTest frm2 = new frmScheduleTest
                ( LastTest.TestAppointmentInfo.LocalDrivingLicenseApplicationID, _TestType );
            frm2.ShowDialog();
            frmListAllTestAppointments_Load( null, null );
            //---
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void تعديلموعدالإختبارToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int TestAppointmentID = ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value;


            frmScheduleTest frm = new frmScheduleTest( _LocalDrivingLicenseApplicationID, _TestType, TestAppointmentID );
            frm.ShowDialog();
            frmListAllTestAppointments_Load( null, null );
        }

        private void إجراءالإختبارToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int TestAppointmentID = ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value;

            frmTakeTest frm = new frmTakeTest( TestAppointmentID, _TestType );
            frm.ShowDialog();
            frmListAllTestAppointments_Load( null, null );
        }
    }
}
