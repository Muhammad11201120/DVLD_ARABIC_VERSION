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

namespace DVLD_AR.Licenses.International_License.Controls
{
    public partial class ctrInterNationalLicenseInfo : UserControl
    {
        private int _InternationalLicenseID;
        private clsInternationalLicense _InternationalLicense;
        public ctrInterNationalLicenseInfo()
        {
            InitializeComponent();
        }
        public int InternationalLicenseID
        {
            get { return _InternationalLicenseID; }
        }

        private void _LoadPersonImage()
        {
            if ( _InternationalLicense.DriverInfo.PersonInfo.Gendor == 0 )
                pbxPersonImage.Image = Resources.Male512;
            else
                pbxPersonImage.Image = Resources.Female512;

            string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;

            if ( ImagePath != "" )
                if ( System.IO.File.Exists( ImagePath ) )
                    pbxPersonImage.Load( ImagePath );
                else
                    MessageBox.Show( "هذه الصورة غير موجودة " + ImagePath, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );

        }

        public void LoadInfo( int InternationalLicenseID )
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = clsInternationalLicense.Find( _InternationalLicenseID );
            if ( _InternationalLicense == null )
            {
                MessageBox.Show( "لا توجد رخصة دولية بهذا الرقم ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                _InternationalLicenseID = -1;
                return;
            }

            txtInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            txtAppID.Text = _InternationalLicense.ApplicationID.ToString();
            txtIsActive.Text = _InternationalLicense.IsActive ? "نعم" : "لا";
            txtLocalLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            txtName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            txtNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            txtGendor.Text = _InternationalLicense.DriverInfo.PersonInfo.Gendor == 0 ? "ذكر" : "أنثى";
            txtBirthDate.Text = clsFormat.DateToShort( _InternationalLicense.DriverInfo.PersonInfo.DateOfBirth );

            txtDriverID.Text = _InternationalLicense.DriverID.ToString();
            txtIsssueDate.Text = clsFormat.DateToShort( _InternationalLicense.IssueDate );
            txtExDate.Text = clsFormat.DateToShort( _InternationalLicense.ExpirationDate );

            _LoadPersonImage();
        }
    }
}
