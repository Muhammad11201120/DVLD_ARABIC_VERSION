using DVLD_AR.GeneralClasses;
using DVLD_AR.Properties;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DVLD_AR.People
{
    public partial class frmAddUpdatePerson : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler( object sender, int PersonID );

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        public enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        public enum enGendor
        {
            MALE = 0,
            FEMALE = 1
        }
        enMode Mode = enMode.ADDNEW;
        private int _PersonID = -1;
        clsPerson _Person = null;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            Mode = enMode.ADDNEW;
        }
        public frmAddUpdatePerson( int personID )
        {
            InitializeComponent();
            Mode = enMode.UPDATE;
            this._PersonID = personID;
        }
        private void _RefreshDeafultValues()
        {
            // Fill the comboboxes
            _FillCountries();
            if ( Mode == enMode.ADDNEW )
            {
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "تحديث بيانات الشخص";
            }
            if ( rbtnMale.Checked )
            {
                pbxPersonImage.Image = Resources.Male512;
            }
            else
            {
                pbxPersonImage.Image = Resources.Female512;
            }
            lblRemoveImage.Visible = ( pbxPersonImage.ImageLocation != null );

            dtbDateOfBirth.MaxDate = DateTime.Now.AddYears( -18 );
            dtbDateOfBirth.Value = dtbDateOfBirth.MaxDate;

            dtbDateOfBirth.MinDate = DateTime.Now.AddYears( -100 );
        }
        private void _LoadData()
        {
            _Person = clsPerson.Find( _PersonID );
            if ( _Person == null )
            {
                MessageBox.Show( "لايوجد شخص بهذا المعرف الرجاء التأكد من إدخال المعلومات الصحيحة" );
                this.Close();
                return;
            }
            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;
            dtbDateOfBirth.Value = _Person.DateOfBirth;
            if ( _Person.Gendor == ( int ) enGendor.MALE )
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnFemale.Checked = true;
            }
            if ( _Person.NationalityCountryID > 0 )
            {
                cbxCountries.SelectedIndex = cbxCountries.FindString( _Person.CountryInfo.Country_enName );
            }
            if ( _Person.ImagePath != string.Empty )
            {
                pbxPersonImage.ImageLocation = _Person.ImagePath;
            }
            else if ( _Person.Gendor == ( short ) enGendor.MALE )
            {
                pbxPersonImage.Image = Resources.Male512;
            }
            else
            {
                pbxPersonImage.Image = Resources.Female512;
            }
            lblRemoveImage.Visible = ( _Person.ImagePath != string.Empty );
        }
        private void _FillCountries()
        {
            // Fill the countries
            DataTable dt = clsCountry.GetAllCountries();
            if ( dt.Rows != null )
            {
                cbxCountries.DataSource = dt;
                cbxCountries.DisplayMember = "Country_enName";
                cbxCountries.SelectedItem = "Saudi Arabia";
            }
        }
        private void button2_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmAddUpdatePerson_Load( object sender, EventArgs e )
        {
            _RefreshDeafultValues();
            if ( Mode == enMode.UPDATE )
            {
                _LoadData();
            }
        }

        private void rbtnFemale_CheckedChanged( object sender, EventArgs e )
        {
            if ( pbxPersonImage.ImageLocation == null )
                pbxPersonImage.Image = Resources.Female512;
        }

        private void rbtnMale_CheckedChanged( object sender, EventArgs e )
        {
            if ( pbxPersonImage.ImageLocation == null )
                pbxPersonImage.Image = Resources.Male512;
        }

        private void lblRemoveImage_Click( object sender, EventArgs e )
        {

            pbxPersonImage.ImageLocation = null;



            if ( rbtnMale.Checked )
                pbxPersonImage.Image = Resources.Male512;
            else
                pbxPersonImage.Image = Resources.Female512;

            lblRemoveImage.Visible = false;
        }

        private void lblSetImage_Click( object sender, EventArgs e )
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if ( openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbxPersonImage.Load( selectedFilePath );
                lblRemoveImage.Visible = true;
                // ...
            }
        }
        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if ( _Person.ImagePath != pbxPersonImage.ImageLocation )
            {
                if ( _Person.ImagePath != "" )
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete( _Person.ImagePath );
                    }
                    catch ( IOException )
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if ( pbxPersonImage.ImageLocation != null )
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbxPersonImage.ImageLocation.ToString();

                    if ( clsUtil.CopyImageToProjectImagesFolder( ref SourceImageFile ) )
                    {
                        pbxPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show( "حصل خطأ أثناء عملية تحميل الصورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                        return false;
                    }
                }

            }
            return true;
        }
        private void btnSave_Click( object sender, EventArgs e )
        {

            if ( !this.ValidateChildren() )
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show( "قيم بعض الحقول غير صحيحة!, مرٌر الفأره على العلامة الحمراء ليظهر لك نوع الخطأ", "خطا في عملية التحقق", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;

            }

            if ( !_HandlePersonImage() )
            {
                this.Close();
                return;
            }


            int NationalityCountryID = clsCountry.Find( cbxCountries.Text ).ID;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtbDateOfBirth.Value;

            if ( rbtnMale.Checked )
                _Person.Gendor = ( short ) enGendor.MALE;
            else
                _Person.Gendor = ( short ) enGendor.FEMALE;

            _Person.NationalityCountryID = NationalityCountryID;

            if ( pbxPersonImage.ImageLocation != null )
                _Person.ImagePath = pbxPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if ( _Person.Save() )
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                //change form mode to update.
                Mode = enMode.UPDATE;
                lblTitle.Text = "تحديث البيانات";

                MessageBox.Show( "تم تحديث البيانات بنجاح.", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information );


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke( this, _Person.PersonID );
            }
            else
                MessageBox.Show( "خطأ: لم يتم تحديث الييانات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );

        }
        private void ValidateEmptyTextBox( object sender, CancelEventArgs e )
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ( ( TextBox ) sender );
            if ( string.IsNullOrEmpty( Temp.Text.Trim() ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( Temp, "هذا الحقل مطلوب" );
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError( Temp, null );
            }

        }

        private void txtEmail_Validating( object sender, CancelEventArgs e )
        {
            //no need to validate the email incase it's empty.
            if ( txtEmail.Text.Trim() == "" )
                return;

            if ( Mode == enMode.ADDNEW )
            {
                //validate email format
                if ( !clsValidatoin.ValidateEmail( txtEmail.Text ) )
                {
                    e.Cancel = true;
                    errorProvider1.SetError( txtEmail, "الرجاء إدخال الإيميل بالصيغة الصحيحة" );
                }
                else
                {
                    errorProvider1.SetError( txtEmail, null );
                };
            }
        }

        private void txtNationalNo_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtNationalNo.Text.Trim() ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtNationalNo, "هذا الحقل مطلوب" );
                return;
            }
            else
            {
                errorProvider1.SetError( txtNationalNo, null );
            }

            if ( Mode == enMode.ADDNEW )
            {
                //Make sure the national number is not used by another person
                if ( txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.isPersonExist( txtNationalNo.Text.Trim() ) )
                {
                    e.Cancel = true;
                    errorProvider1.SetError( txtNationalNo, "عفوا هذا الرقم الوطني مستخدم بالفعل الرجاء التأكد من صحة الرقم الوطني !" );

                }
                else
                {
                    errorProvider1.SetError( txtNationalNo, null );
                }
            }
        }

        private void txtEmail_TextChanged( object sender, EventArgs e )
        {
            //validate email format

            if ( !clsValidatoin.ValidateEmail( txtEmail.Text ) )
            {

                errorProvider1.SetError( txtEmail, "الرجاء إدخال الإيميل بالصيغة الصحيحة" );
                btnSave.Enabled = false;
                btnSave.ForeColor = Color.Gray;
            }
            else
            {
                errorProvider1.SetError( txtEmail, null );
                btnSave.Enabled = true;
                btnSave.ForeColor = Color.FromArgb( 34, 34, 34 );
            };
        }
    }
}
