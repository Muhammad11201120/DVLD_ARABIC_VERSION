using DVLD_AR.GeneralClasses;
using DVLD_AR.People.Controllers;
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
    public partial class frmAddEditLocaLDrivingLicenseApplication : Form
    {
        public enum _enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        private _enMode _Mode;
        private int _LocalApplicatioLicenseID = -1;
        private int _SelectedPersnID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication = null;


        public frmAddEditLocaLDrivingLicenseApplication()
        {
            InitializeComponent();
            this._Mode = _enMode.ADDNEW;
        }
        public frmAddEditLocaLDrivingLicenseApplication( int localDrivingLicenseApplicationID )
        {
            InitializeComponent();
            this._Mode = _enMode.UPDATE;
            this._LocalApplicatioLicenseID = localDrivingLicenseApplicationID;
        }
        private void _FillLicenseClassesComboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();
            foreach ( DataRow row in dtLicenseClasses.Rows )
            {
                cbxLicenseClass.Items.Add( row[ "ClassName" ] );
            }
        }
        private void _RefreshDefaultValues()
        {
            _FillLicenseClassesComboBox();
            if ( this._Mode == _enMode.ADDNEW )
            {
                lblTiltle.Text = "إظافة طلب رخصة محلية جديد";
                this.Text = "ظافة طلب رخصة محلية جديد";
                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                ctrPersonCardWithFilter1.FilterFocus();
                tpApplicationInfo.Enabled = false;
                cbxLicenseClass.SelectedIndex = 2;
                lblApplicationFees.Text = clsApplicationType.Find( ( int ) clsApplication.enApplicationType.NewDrivingLicense ).Fees.ToString();
                lblApplicationDate.Text = DateTime.Now.ToShortDateString();
                lblCreatedByUserID.Text = clsGlobal.CurrentUser.UserName;
            }
            else
            {
                lblTiltle.Text = "تعديل طلب رخصة محلية";
                this.Text = "تعديل طلب رخصة محلية";

                tpApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }
        }
        private void _LoadData()
        {
            ctrPersonCardWithFilter1.FilterEnabled = false;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID( _LocalApplicatioLicenseID );
            if ( _LocalDrivingLicenseApplication == null )
            {
                MessageBox.Show( "لا يمكن العثور على الطلب المحدد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                this.Close();
                return;
            }

            ctrPersonCardWithFilter1.LoadPersonInfo( _LocalDrivingLicenseApplication.ApplicantPersonID );
            lblApplicationDate.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToShortDateString();
            lblApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblCreatedByUserID.Text = _LocalDrivingLicenseApplication.CreatedByUserID.ToString();
            lblApplicationFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            cbxLicenseClass.SelectedIndex = cbxLicenseClass.FindString( clsLicenseClass.Find( _LocalDrivingLicenseApplication.LicenseClassID ).ClassName );
        }
        private void DataBackEvent( object sender, int PersonID )
        {
            // Handle the data received
            _SelectedPersnID = PersonID;
            ctrPersonCardWithFilter1.LoadPersonInfo( PersonID );
        }

        private void btnNext_Click( object sender, EventArgs e )
        {
            if ( _Mode == _enMode.UPDATE )
            {
                btnSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages[ "tpApplicationInfo" ];
                return;
            }


            //incase of add new mode.
            if ( ctrPersonCardWithFilter1.PersonId != -1 )
            {
                btnSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages[ "tpApplicationInfo" ];
            }
            else

            {
                MessageBox.Show( "الرجاء تحديد شخص", "تحديد شخص", MessageBoxButtons.OK, MessageBoxIcon.Error );
                ctrPersonCardWithFilter1.FilterFocus();
            }
        }

        private void btnSave_Click( object sender, EventArgs e )
        {

            int LicenseClassID = clsLicenseClass.Find( cbxLicenseClass.Text ).LicenseClassID;

            // to check if user already have active application for the same license class.
            int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass( _SelectedPersnID, clsApplication.enApplicationType.NewDrivingLicense, LicenseClassID );

            //check if user already (have active application) for the same license class.
            if ( ActiveApplicationID != -1 )
            {
                MessageBox.Show( "الرجاء اختيار نوع رخصة اخر , رقم الشخص المدخل لديه طلب فعُال لنفس نوع الرخصة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                cbxLicenseClass.Focus();
                return;
            }


            //check if user already (have issued license) of the same driving  class.
            if ( clsLicense.IsLicenseExistByPersonID( ctrPersonCardWithFilter1.PersonId, LicenseClassID ) )
            {

                MessageBox.Show( "رقم الشخص المدخل لديه بالفعل رخصة من نفس النوع", "غير مسموح", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = ctrPersonCardWithFilter1.PersonId; ;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = ( int ) clsApplication.enApplicationType.NewDrivingLicense;
            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToSingle( lblApplicationFees.Text );
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;


            if ( _LocalDrivingLicenseApplication.Save() )
            {
                lblApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                //change form mode to update.
                _Mode = _enMode.UPDATE;
                lblTiltle.Text = "تعديل طلب رخصة محلية";
                this.Text = "تعديل طلب رخصة محلية";

                MessageBox.Show( "تم حفظ البيانات بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information );

            }
            else
                MessageBox.Show( "لم يتم حفظ البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );


        }

        private void frmAddEditLocaLDrivingLicenseApplication_Activated( object sender, EventArgs e )
        {
            ctrPersonCardWithFilter1.FilterFocus();
        }

        private void ctrPersonCardWithFilter1_OnPersonSelected( int obj )
        {
            _SelectedPersnID = obj;
        }

        private void frmAddEditLocaLDrivingLicenseApplication_Load( object sender, EventArgs e )
        {
            _RefreshDefaultValues();
            if ( _Mode == _enMode.UPDATE )
            {
                _LoadData();
            }
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}