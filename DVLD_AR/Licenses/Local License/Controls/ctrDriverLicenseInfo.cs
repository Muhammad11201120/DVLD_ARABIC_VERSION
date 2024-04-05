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

namespace DVLD_AR.Licenses.Controls
{
    public partial class ctrDriverLicenseInfo : UserControl
    {
        private int _LicenseID;
        private clsLicense _License;
        public int LicenseID
        {
            get { return _LicenseID; }
        }
        public clsLicense SelectedLicenseInfo
        {
            get { return _License; }
        }
        public ctrDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void _LoadPersonImage()
        {
            if ( _License.DriverInfo.PersonInfo.Gendor == 0 )
                pbPersonImage.Image = Resources.Male512;
            else
                pbPersonImage.Image = Resources.Female512;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if ( ImagePath != "" )
                if ( System.IO.File.Exists( ImagePath ) )
                    pbPersonImage.Load( ImagePath );
                else
                    MessageBox.Show( "هذه الصورة غير موجودة ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
        public void LoadInfo( int LicenseID )
        {
            _LicenseID = LicenseID;
            _License = clsLicense.Find( _LicenseID );
            if ( _License == null )
            {
                MessageBox.Show( "لا توجد رخصة بهذا الرقم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                _LicenseID = -1;
                return;
            }

            txtLicenseID.Text = _License.LicenseID.ToString();
            txtLicenseStatus.Text = _License.IsActive ? "نعم" : "لا";
            txtLicenseIsDetained.Text = _License.IsDetained ? "موقوفة" : "غير موقوفة";
            txtLicenseType.Text = _License.LicenseClassIfo.ClassName;
            txtName.Text = _License.DriverInfo.PersonInfo.FullName;
            txtNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            txtGendor.Text = _License.DriverInfo.PersonInfo.Gendor == 0 ? "ذكر" : "أنثى";
            txtBirthDate.Text = clsFormat.DateToShort( _License.DriverInfo.PersonInfo.DateOfBirth );

            txtDriverID.Text = _License.DriverID.ToString();
            txtIssueDate.Text = clsFormat.DateToShort( _License.IssueDate );
            txtExDate.Text = clsFormat.DateToShort( _License.ExpirationDate );
            txtIssueReason.Text = _License.IssueReasonText;
            txtNotes.Text = _License.Notes == string.Empty ? "لا يوجد ملاحظات إظافية" : _License.Notes;
            _LoadPersonImage();
        }
    }
}
