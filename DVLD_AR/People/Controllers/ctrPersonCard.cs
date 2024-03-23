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

namespace DVLD_AR.People.Controllers
{
    public partial class ctrPersonCard : UserControl
    {
        private clsPerson _Person;
        private int _PersonID = -1;
        public int PersonID
        {
            get { return _PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }
        public ctrPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPerson( int personID )
        {
            _Person = clsPerson.Find( personID );
            if ( _Person == null )
            {
                MessageBox.Show( "لايوجد شخص بهذا المعرٌف. = " + personID.ToString(), "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            _FillPersonInfo();
        }
        public void LoadPerson( string nationalNo )
        {
            _Person = clsPerson.Find( nationalNo );
            if ( _Person == null )
            {
                MessageBox.Show( "لايوجد مستخدم بهذه الهويٌة. = " + nationalNo, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            _FillPersonInfo();
        }
        private void _FillPersonInfo()
        {
            lblEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            txtPersonID.Text = _Person.PersonID.ToString();
            txtNationalNo.Text = _Person.NationalNo;
            txtFullName.Text = _Person.FullName;
            txtGendor.Text = _Person.Gendor == 0 ? "ذكر" : "أنثى";
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString().Trim();
            txtNationality.Text = clsCountry.Find( _Person.NationalityCountryID ).Country_enName.Trim();
            txtAddress.Text = _Person.Address;
            _LoadPersonImage();
        }
        private void _LoadPersonImage()
        {
            if ( _Person.Gendor == 0 )
                pbxPersonImage.Image = Resources.Male512;
            else
                pbxPersonImage.Image = Resources.Female512;

            string ImagePath = _Person.ImagePath;
            if ( ImagePath != "" )
                if ( System.IO.File.Exists( ImagePath ) )
                    pbxPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show( "لاتوجد هذه الصورة: = " + ImagePath, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );

        }

        private void lblEditPersonInfo_Click( object sender, EventArgs e )
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson( _PersonID );
            frm.ShowDialog();
            LoadPerson( _PersonID );
        }

    }
}
