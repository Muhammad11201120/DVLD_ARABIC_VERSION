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
        public void _ResestDefaultValues()
        {
            _ApplicationID = -1;
            lblApplicant.Text = "???";
            lblApplicationDate.Text = "???";
            lblApplicationFees.Text = "???";
            lblApplicationStatus.Text = "???";
            lblApplicationType.Text = "???";
            lblApplicationStatusDate.Text = "???";
            lblCreatedByUserID.Text = "???";
            lblApplicationID.Text = "???";
        }
        public void _FillData()
        {
            _ApplicationID = _Application.ApplicationID;
            lblApplicant.Text = _Application.ApplicantFullName;
            lblApplicationDate.Text = _Application.ApplicationDate.ToShortDateString();
            lblApplicationFees.Text = _Application.PaidFees.ToString();
            lblApplicationStatus.Text = _Application.ApplicationStatus.ToString();
            lblApplicationType.Text = _Application.ApplicationDate.ToString();
            lblApplicationStatusDate.Text = _Application.LastStatusDate.ToShortDateString();
            lblCreatedByUserID.Text = clsGlobal.CurrentUser.UserName;
            lblApplicationID.Text = _Application.ApplicationID.ToString();
        }
        public void _LoadData()
        {
            _Application = clsApplication.FindBaseApplication( _ApplicationID );
            if ( _Application == null )
            {
                _ResestDefaultValues();
                MessageBox.Show( ToString(), "الطلب غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
                _FillData();
        }

        private void llPersonInfo_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            frmShowPersonInfo frm = new frmShowPersonInfo( _ApplicationID );
            frm.ShowDialog();

            _LoadData();
        }
    }
}
