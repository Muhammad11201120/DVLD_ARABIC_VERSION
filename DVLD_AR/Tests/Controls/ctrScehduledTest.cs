using DVLD_AR.GeneralClasses;
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

namespace DVLD_AR.Tests.Controls
{
    public partial class ctrScehduledTest : UserControl
    {
        private clsTestType.enTestType _TestTypeID;
        private int _TestID = -1;

        public clsTestType.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;

                switch ( _TestTypeID )
                {

                    case clsTestType.enTestType.VisionTest:
                        {
                            groupBox1.Text = " إختبار النظر ";
                            pictureBox1.Image = Resources.Vision_512;
                            break;
                        }

                    case clsTestType.enTestType.WrittenTest:
                        {
                            groupBox1.Text = " الإختبار الكتابي ";
                            pictureBox1.Image = Resources.Written_Test_512;
                            break;
                        }
                    case clsTestType.enTestType.StreetTest:
                        {
                            groupBox1.Text = " الإختبار الميداني ";
                            pictureBox1.Image = Resources.driving_test_512;
                            break;


                        }
                }
            }
        }

        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
        }

        public int TestID
        {
            get
            {
                return _TestID;
            }
        }

        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        private int _TestAppointmentID = -1;
        private clsTestAppointment _TestAppointment;

        public void LoadInfo( int TestAppointmentID )
        {

            _TestAppointmentID = TestAppointmentID;


            _TestAppointment = clsTestAppointment.Find( _TestAppointmentID );

            //incase we did not find any appointment .
            if ( _TestAppointment == null )
            {
                MessageBox.Show( "لايوجد موعد لهذا الإختبار", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                _TestAppointmentID = -1;
                return;
            }

            _TestID = _TestAppointment.TestID;

            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID( _LocalDrivingLicenseApplicationID );

            if ( _LocalDrivingLicenseApplication == null )
            {
                MessageBox.Show( "لاتوجد رخصة محليٌة لهذا الشخص ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            txtDrivingLicenseAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            txtLicenseClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            txtName.Text = _LocalDrivingLicenseApplication.PersonFullName;


            //this will show the trials for this test before 
            txtTrials.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest( _TestTypeID ).ToString();



            txtDate.Text = clsFormat.DateToShort( _TestAppointment.AppointmentDate );
            txtFees.Text = _TestAppointment.PaidFees.ToString();
            txtTestID.Text = ( _TestAppointment.TestID == -1 ) ? "لايوجد بعد" : _TestAppointment.TestID.ToString();



        }
        public ctrScehduledTest()
        {
            InitializeComponent();
        }
    }
}
