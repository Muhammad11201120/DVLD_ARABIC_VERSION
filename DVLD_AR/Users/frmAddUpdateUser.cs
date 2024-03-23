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

namespace DVLD_AR.Users
{
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        private enMode _Mode = enMode.ADDNEW;
        private int _UserID = -1;
        private clsUser _User = null;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.ADDNEW;
        }
        public frmAddUpdateUser( int userID )
        {
            InitializeComponent();
            _Mode = enMode.UPDATE;
            this._UserID = userID;
        }
        private void _RefreshValues()
        {
            if ( _Mode == enMode.ADDNEW )
            {
                _User = new clsUser();
                tpUserInfo.Enabled = false;
                ctrPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblTilte.Text = "تحديث معلومات المستخدم";
                tpUserInfo.Enabled = true;
                btnSave.Enabled = true;
            }
        }
        private void _LoadData()
        {
            _User = clsUser.FindByUserID( _UserID );
            ctrPersonCardWithFilter1.FilterEnabled = false;
            if ( _User == null )
            {
                MessageBox.Show( " لا يوجد مستخدم بهذا المعرٌف " + _UserID, "المستخدم غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                this.Close();
                return;
            }
            txtUserID.Text = _UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassord.Text = _User.Password;
            chbxIsActive.Checked = _User.IsActive;
            ctrPersonCardWithFilter1.LoadPersonInfo( _User.PersonID );
        }
        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();

        }

        private void frmAddUpdateUser_Load( object sender, EventArgs e )
        {
            _RefreshValues();
            if ( _Mode == enMode.UPDATE )
            {
                _LoadData();
            }
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            if ( !this.ValidateChildren() )
            {
                MessageBox.Show( "بعض الحقول ليست صحيحه مرٌر الفاره على العلامة الحمراء ليظهر لك نوع الخطأ", "خطأ في القيم المدخلة", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            _User.PersonID = ctrPersonCardWithFilter1.PersonId;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = chbxIsActive.Checked;
            txtUserID.Text = _User.UserID.ToString();
            if ( _User.Save() )
            {
                txtUserID.Text = _User.UserID.ToString();
                _Mode = enMode.UPDATE;
                lblTilte.Text = "تحديث معلومات المستخدم";
                MessageBox.Show( "تم حفظ المعلومات بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else
            {
                MessageBox.Show( "هناك خطأ أثناء عملية حفظ البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void txtConfirmPassord_Validating( object sender, CancelEventArgs e )
        {
            if ( txtConfirmPassord.Text.Trim() != txtPassword.Text.Trim() )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtConfirmPassord, "كلمة المرورو وتأكيد كلمة المرور ليست متطابقتان" );
            }
            else
            {
                errorProvider1.SetError( txtConfirmPassord, null );
            }
        }

        private void txtPassword_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtPassword.Text.Trim() ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtConfirmPassord, "هذا الحقل مطلوب" );
            }
            else
            {
                errorProvider1.SetError( txtConfirmPassord, null );
            }
        }
        private void txtUserName_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtUserName.Text.Trim() ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtUserName, "إهذا الحقل مطلوب" );
                return;
            }
            else
            {
                errorProvider1.SetError( txtUserName, null );
            };


            if ( _Mode == enMode.ADDNEW )
            {

                if ( clsUser.isUserExist( txtUserName.Text.Trim() ) )
                {
                    e.Cancel = true;
                    errorProvider1.SetError( txtUserName, "هذا الإسم مستخدم من قبل مستخدم اخر" );
                }
                else
                {
                    errorProvider1.SetError( txtUserName, null );
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if ( _User.UserName != txtUserName.Text.Trim() )
                {
                    if ( clsUser.isUserExist( txtUserName.Text.Trim() ) )
                    {
                        e.Cancel = true;
                        errorProvider1.SetError( txtUserName, "هذا الإسم مستخدم من قبل مستخدم اخر" );
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError( txtUserName, null );
                    };
                }
            }
        }

        private void btnNext_Click( object sender, EventArgs e )
        {
            if ( _Mode == enMode.UPDATE )
            {
                btnSave.Enabled = true;
                tpUserInfo.Enabled = true;
                tapUser.SelectedTab = tapUser.TabPages[ "tpUserInfo" ];
                return;
            }

            //incase of add new mode.
            if ( ctrPersonCardWithFilter1.PersonId != -1 )
            {

                if ( clsUser.isUserExistForPersonID( ctrPersonCardWithFilter1.PersonId ) )
                {

                    MessageBox.Show( "هذا الشخص لديه حساب مستخدم بالفعل, الرجاء التاكد من صحة المعلومات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    ctrPersonCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tpUserInfo.Enabled = true;
                    tapUser.SelectedTab = tapUser.TabPages[ "tpUserInfo" ];
                }
            }

            else

            {
                MessageBox.Show( "الرجاء إدخال البيانات ", "أدخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Error );
                ctrPersonCardWithFilter1.FilterFocus();

            }
        }

        private void frmAddUpdateUser_Activated( object sender, EventArgs e )
        {
            ctrPersonCardWithFilter1.FilterFocus();
        }
    }
}
