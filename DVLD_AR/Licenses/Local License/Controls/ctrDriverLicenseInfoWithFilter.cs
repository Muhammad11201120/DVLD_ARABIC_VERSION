﻿using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_AR.Licenses.Controls
{
    public partial class ctrDriverLicenseInfoWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnLicenseSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void LicenseSelected( int LicenseID )
        {
            Action<int> handler = OnLicenseSelected;
            if ( handler != null )
            {
                handler( LicenseID ); // Raise the event with the parameter
            }
        }
        public ctrDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }
        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }
        private int _LicenseID = -1;

        public int LicenseID
        {
            get { return ctrDriverLicenseInfo1.LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        {
            get { return ctrDriverLicenseInfo1.SelectedLicenseInfo; }
        }
        public void LoadLicenseInfo( int LicenseID )
        {
            txtLicenseID.Text = LicenseID.ToString();
            ctrDriverLicenseInfo1.LoadInfo( LicenseID );
            _LicenseID = ctrDriverLicenseInfo1.LicenseID;
            if ( OnLicenseSelected != null && FilterEnabled )
                // Raise the event with a parameter
                OnLicenseSelected( _LicenseID );
        }

        private void txtLicenseID_KeyPress( object sender, KeyPressEventArgs e )
        {
            e.Handled = !char.IsDigit( e.KeyChar ) && !char.IsControl( e.KeyChar );

            // Check if the pressed key is Enter (character code 13)
            if ( e.KeyChar == ( char ) 13 )
            {
                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click( object sender, EventArgs e )
        {
            if ( !this.ValidateChildren() )
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show( "بعض الحقول إما فارغة أو القيم المدخلة غير صحيحة .. الرجاء التأكد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
                txtLicenseID.Focus();
                return;

            }
            _LicenseID = int.Parse( txtLicenseID.Text );
            LoadLicenseInfo( _LicenseID );
        }

        private void txtLicenseID_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtLicenseID.Text.Trim() ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtLicenseID, "This field is required!" );
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError( txtLicenseID, null );
            }
        }
        public void txtLicenseIDFocus()
        {
            txtLicenseID.Focus();
        }
    }
}
