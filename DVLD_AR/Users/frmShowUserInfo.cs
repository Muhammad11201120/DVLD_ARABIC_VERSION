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
    public partial class frmShowUserInfo : Form
    {
        private int _UserID = -1;
        public frmShowUserInfo( int userID )
        {
            InitializeComponent();
            this._UserID = userID;
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmShowUserInfo_Load( object sender, EventArgs e )
        {
            ctrUserInfoCard1.LoadUserInfo( _UserID );
        }
    }
}
