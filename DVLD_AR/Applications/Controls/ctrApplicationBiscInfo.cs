using DVLD_AR.GeneralClasses;
using DVLD_AR.People;
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

namespace DVLD_AR.Applications.Controls
{
    public partial class ctrApplicationBiscInfo : UserControl
    {
        private clsApplication _Application = null;
        private int _ApplicationID = -1;
        public int ApplicationID
        {
            get { return _ApplicationID; }
        }

        public ctrApplicationBiscInfo()
        {
            InitializeComponent();
        }
        public void ResestDefaultValues()
        {
            _ApplicationID = -1;
            txtApplicant.Text = "???";
            txtAppDate.Text = "???";
            txtAppFees.Text = "???";
            txtAppStatus.Text = "???";
            txtAppType.Text = "???";
            txtAppStatusDate.Text = "???";
            txtCreatedByUserID.Text = "???";
            txtAppID.Text = "???";
        }
        public void FillData()
        {
            _ApplicationID = _Application.ApplicationID;
            txtApplicant.Text = _Application.ApplicantFullName;
            txtAppDate.Text = _Application.ApplicationDate.ToShortDateString();
            txtAppFees.Text = _Application.PaidFees.ToString();
            txtAppStatus.Text = _Application.ApplicationStatus.ToString();
            txtAppType.Text = _Application.ApplicationTypeInfo.Title.ToString();
            txtAppStatusDate.Text = _Application.LastStatusDate.ToShortDateString();
            txtCreatedByUserID.Text = clsGlobal.CurrentUser.UserName;
            txtAppID.Text = _Application.ApplicationID.ToString();
        }
        public void LoadData( int applicationID )
        {
            _Application = clsApplication.FindBaseApplication( applicationID );
            if ( _Application == null )
            {
                ResestDefaultValues();
                MessageBox.Show( ToString(), "الطلب غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
                FillData();
        }

        private void llPersonInfo_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            frmShowPersonInfo frm = new frmShowPersonInfo( _ApplicationID );
            frm.ShowDialog();

            LoadData( _ApplicationID );
        }
    }
}
