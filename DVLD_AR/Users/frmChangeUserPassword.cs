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
    public partial class frmChangeUserPassword : Form
    {
        private int _UserID = -1;
        private clsUser _User = null;
        public frmChangeUserPassword( int userID )
        {
            InitializeComponent();
            this._UserID = userID;
        }

        private void _ResetDefaultValues()
        {
            txtCurrentPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfirmNewPassword.Text += string.Empty;
            txtCurrentPassword.Focus();
        }
        private void frmChangeUserPassword_Load( object sender, EventArgs e )
        {
            _User = clsUser.FindByUserID( _UserID );
            if ( _User == null )
            {
                MessageBox.Show( "لا يوجد مستخدم بهذا الرقم الرجاء التأكد من صحٌة المعلومات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error );
                this.Close();
                return;
            }
            ctrUserInfoCard1.LoadUserInfo( _UserID );
        }

        private void txtCurrentPassword_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtCurrentPassword.Text.Trim() ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtCurrentPassword, "هذا الحقل مطلوب" );
            }
            else
            {
                errorProvider1.SetError( txtCurrentPassword, null );
            }
            if ( _User.Password.Trim() != txtCurrentPassword.Text.Trim() )
            {
                e.Cancel = true;
                MessageBox.Show( "كلمة المرور خاطئة الرجاء التأكد من صحٌة كلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                errorProvider1.SetError( txtCurrentPassword, null );
            }
        }

        private void txtNewPassword_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtNewPassword.Text.Trim() ) )
            {
                e.Cancel = true;
                MessageBox.Show( "هذا الحقل مطلوب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
                errorProvider1.SetError( txtCurrentPassword, null );
        }

        private void txtConfirmNewPassword_Validating( object sender, CancelEventArgs e )
        {
            if ( txtConfirmNewPassword.Text.Trim() != txtNewPassword.Text.Trim() )
            {
                e.Cancel = true;
                MessageBox.Show( "حقل تأكيد كلمة المرور لا يطابق حقل كلمة المرور الجديدة الرجاء التأكد من تطابق الحقلين", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
                errorProvider1.SetError( txtCurrentPassword, null );
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            if ( !this.ValidateChildren() )
            {
                MessageBox.Show( "بعض الحقول ليست صحيحه مرٌر الفاره على العلامة الحمراء ليظهر لك نوع الخطأ", "خطأ في القيم المدخلة", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            _User.Password = txtNewPassword.Text;
            if ( _User.Save() )
            {
                MessageBox.Show( "تم تغيير كلمة المرور بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information );
                //_ResetDefaultValues();
            }
            else
                MessageBox.Show( "خطأ أثناء محاولة تغيير كلمة المرور, الرجاء المحاولة في وقت لاحق", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
