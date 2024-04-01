using DVLD_AR.GeneralClasses;
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

namespace DVLD_AR.Login
{
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Close();
        }

        private void btnLogin_Click( object sender, EventArgs e )
        {
            clsUser user = clsUser.FindByUsernameAndPassword( txtUserName.Text.Trim(), txtPassword.Text.Trim() );
            if ( user != null )
            {
                if ( chbxRememberMe.Checked )
                {
                    clsGlobal.RememberUsernameAndPassword( txtUserName.Text.Trim(), txtPassword.Text.Trim() );
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword( "", "" );
                }
                if ( !user.IsActive )
                {
                    txtUserName.Focus();
                    MessageBox.Show( "حسابك ليس نشط الرجاء الاتصال على مدير النظام", "حساب غير نشط", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;
                }
                clsGlobal.CurrentUser = user;
                this.Hide();
                frmMain frm = new frmMain( this );
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show( "خطأ في اسم المستخدم أو كلمة المرور, الرجاء التأكد من صحة المعلومات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

        }

        private void frmLogin_Load( object sender, EventArgs e )
        {
            string userName = string.Empty, password = string.Empty;

            if ( clsGlobal.GetStoredCredential( ref userName, ref password ) )
            {
                txtUserName.Text = userName;
                txtPassword.Text = password;
                chbxRememberMe.Checked = true;
            }
            else
                chbxRememberMe.Checked = false;
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
