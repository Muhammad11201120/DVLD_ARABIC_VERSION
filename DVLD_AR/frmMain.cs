using DVLD_AR.Applications.LocalDrivingLicenseApplications;
using DVLD_AR.Applications.Manage_Application_Types;
using DVLD_AR.Applications.ReleaseDetainedLicense;
using DVLD_AR.Applications.Renew_Local_License;
using DVLD_AR.Drivers;
using DVLD_AR.GeneralClasses;
using DVLD_AR.Login;
using DVLD_AR.People;
using DVLD_AR.Tests.TestTypes;
using DVLD_AR.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_AR
{
    public partial class frmMain : Form
    {
        private Form _frmLogin = null;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain( Form frm )
        {
            InitializeComponent();
            _frmLogin = frm;
        }
        private void ألأشخاثToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmListAllPeople frm = new frmListAllPeople();
            frm.ShowDialog();
        }

        private void المستخدمونToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAllUsersList frm = new frmAllUsersList();
            frm.ShowDialog();
        }

        private void frmMain_FormClosed( object sender, FormClosedEventArgs e )
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void إظهارجميعبياناتالمستخدمالحاليToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmShowUserInfo frm = new frmShowUserInfo( clsGlobal.CurrentUser.UserID );
            frm.ShowDialog();
        }

        private void تغييركلمةالمرورToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmChangeUserPassword frm = new frmChangeUserPassword( clsGlobal.CurrentUser.UserID );
            frm.ShowDialog();
        }

        private void تسجيلالخرToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void toolStripMenuItem4_Click( object sender, EventArgs e )
        {
            frmAllApplicationTypesList frm = new frmAllApplicationTypesList();
            frm.ShowDialog();
        }

        private void toolStripMenuItem5_Click( object sender, EventArgs e )
        {
            frmListAllTestTypes frm = new frmListAllTestTypes();
            frm.ShowDialog();
        }

        private void رخصةمحليةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAddEditLocaLDrivingLicenseApplication frm = new frmAddEditLocaLDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void إدارةالرخصالمحليةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAllLocalDrivingApplicationsList frm = new frmAllLocalDrivingApplicationsList();
            frm.ShowDialog();
        }

        private void toolStripMenuItem7_Click( object sender, EventArgs e )
        {
            frmRenewLicense frm = new frmRenewLicense();
            frm.ShowDialog();
        }

        private void السائقونToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmListAllDrivers frm = new frmListAllDrivers();
            frm.ShowDialog();
        }

        private void فكحجزرخصةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            DVLD_AR.Licenses.DetainLicense.frmDetainLicenseApplication frm = new Licenses.DetainLicense.frmDetainLicenseApplication();
            frm.ShowDialog();
        }

        private void فكحجزرخصةToolStripMenuItem1_Click( object sender, EventArgs e )
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void إدارةالرخصالمحجوزةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmListAllDetainedLicenses frm = new frmListAllDetainedLicenses();
            frm.ShowDialog();
        }
    }
}
