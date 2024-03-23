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

namespace DVLD_AR.Users.Controls
{
    public partial class ctrUserInfoCard : UserControl
    {
        private clsUser _User = null;
        private int _UersID = -1;
        public int UserID
        {
            get { return this._UersID; }
        }
        public ctrUserInfoCard()
        {
            InitializeComponent();
        }
        public void LoadUserInfo( int userID )
        {
            _UersID = userID;

            _User = clsUser.FindByUserID( UserID );
            if ( _User == null )
            {
                MessageBox.Show( "لا يوجد مستخدم بهذا المعرٌف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            // fill user info
            _FillUserInfo();
        }
        private void _FillUserInfo()
        {

            ctrPersonCard1.LoadPerson( _User.PersonID );
            txtUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            if ( _User.IsActive )
            {
                txtIsActive.Text = "نشط";
                txtIsActive.ForeColor = global::System.Drawing.Color.Green;
            }
            else
            {
                txtIsActive.Text = "غير نشط";
                txtIsActive.ForeColor = global::System.Drawing.Color.Red;
            }
        }
    }
}
