using DVLD_AR.Licenses;
using DVLD_AR.Licenses.DetainLicense;
using DVLD_AR.Licenses.Local_License;
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

namespace DVLD_AR.Applications.ReleaseDetainedLicense
{
    public partial class frmListAllDetainedLicenses : Form
    {
        DataTable dt = null;
        DataView dv = null;
        public frmListAllDetainedLicenses()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            dt = clsDetainedLicense.GetAllDetainedLicenses();
            dv = new DataView( dt );
            dataGridView1.DataSource = dv;
            dataGridView1.Columns[ "DetainID" ].HeaderText = "رقم الحجز";
            dataGridView1.Columns[ 0 ].Width = 90;
            dataGridView1.Columns[ "LicenseID" ].HeaderText = "رقم الرخصة";
            dataGridView1.Columns[ 0 ].Width = 90;
            dataGridView1.Columns[ "DetainDate" ].HeaderText = "تاريخ الحجز";
            dataGridView1.Columns[ 0 ].Width = 160;
            dataGridView1.Columns[ "IsReleased" ].HeaderText = "حالة  فك الحجز";
            dataGridView1.Columns[ 0 ].Width = 90;
            dataGridView1.Columns[ "FineFees" ].HeaderText = "رسوم الحجز";
            dataGridView1.Columns[ 0 ].Width = 90;
            dataGridView1.Columns[ "ReleaseDate" ].HeaderText = "تاريخ فك الحجز";
            dataGridView1.Columns[ 0 ].Width = 90;
            dataGridView1.Columns[ "NationalNo" ].HeaderText = "رقم الهوية";
            dataGridView1.Columns[ 0 ].Width = 90;
            dataGridView1.Columns[ "FullName" ].HeaderText = "الإسم";
            dataGridView1.Columns[ 0 ].Width = 330;
            dataGridView1.Columns[ "ReleaseApplicationID" ].HeaderText = "رقم طلب فك الحجز";
            dataGridView1.Columns[ 0 ].Width = 150;

        }
        private void frmListAllDetainedLicenses_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void txtFilter_TextChanged( object sender, EventArgs e )
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch ( cbxFilter.Text )
            {
                case "رقم الحجز":
                    FilterColumn = "DetainID";
                    break;
                case "حالة فك الحجز":
                    {
                        FilterColumn = "IsReleased";
                        break;
                    };

                case "رقم الهوية":
                    FilterColumn = "NationalNo";
                    break;


                case "الإسم":
                    FilterColumn = "FullName";
                    break;

                case "رقم طلب فك الحجز":
                    FilterColumn = "ReleaseApplicationID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if ( txtFilter.Text.Trim() == "" || FilterColumn == "None" )
            {
                dv.RowFilter = "";
                lblTotalRecords.Text = dv.Count.ToString();
                return;
            }


            if ( FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID" )
                //in this case we deal with numbers not string.
                dv.RowFilter = string.Format( "[{0}] = {1}", FilterColumn, txtFilter.Text.Trim() );
            else
                dv.RowFilter = string.Format( "[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim() );

            lblTotalRecords.Text = dv.Count.ToString();
        }

        private void cbxIsReleased_SelectedIndexChanged( object sender, EventArgs e )
        {
            string FilterColumn = "IsReleased";
            string FilterValue = cbxIsReleased.Text;

            switch ( FilterValue )
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if ( FilterValue == "All" )
                dv.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                dv.RowFilter = string.Format( "[{0}] = {1}", FilterColumn, FilterValue );

            lblTotalRecords.Text = dv.Count.ToString();
        }

        private void cbxFilter_SelectedIndexChanged( object sender, EventArgs e )
        {
            if ( cbxFilter.Text == "Is Released" )
            {
                txtFilter.Visible = false;
                cbxIsReleased.Visible = true;
                cbxIsReleased.Focus();
                cbxIsReleased.SelectedIndex = 0;
            }

            else

            {

                txtFilter.Visible = ( cbxFilter.Text != "None" );
                cbxIsReleased.Visible = false;

                if ( cbxFilter.Text == "None" )
                {
                    txtFilter.Enabled = false;
                    //_dtDetainedLicenses.DefaultView.RowFilter = "";
                    //lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();

                }
                else
                    txtFilter.Enabled = true;

                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_KeyPress( object sender, KeyPressEventArgs e )
        {
            //we allow number incase person id or user id is selected.
            if ( cbxFilter.Text == "رقم الحجز" || cbxFilter.Text == "رقم طلب فك الحجز" )
                e.Handled = !char.IsDigit( e.KeyChar ) && !char.IsControl( e.KeyChar );
        }

        private void contextMenuStrip1_Opening( object sender, CancelEventArgs e )
        {
            فكالحجزعنالرخصةToolStripMenuItem.Enabled = !( bool ) dataGridView1.CurrentRow.Cells[ 3 ].Value;
        }

        private void فكالحجزعنالرخصةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense( ( int ) dataGridView1.CurrentRow.Cells[ 1 ].Value );
            frm.ShowDialog();
            _LoadData();
        }

        private void سجلجميعرخصالشخصToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int personID = clsPerson.Find( dataGridView1.CurrentRow.Cells[ 6 ].Value.ToString() ).PersonID;
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory( personID );
            frm.ShowDialog();
        }

        private void معلوماتالرخصةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo( ( int ) dataGridView1.CurrentRow.Cells[ 1 ].Value );
            frm.ShowDialog();
        }

        private void معلوماتالشخصToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int personID = clsPerson.Find( dataGridView1.CurrentRow.Cells[ 6 ].Value.ToString() ).PersonID;
            frmShowPersonInfo frm = new frmShowPersonInfo( personID );
            frm.ShowDialog();
        }

        private void btnDetain_Click( object sender, EventArgs e )
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.ShowDialog();
            _LoadData();
        }

        private void btnRelease_Click( object sender, EventArgs e )
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            _LoadData();
        }
    }
}
