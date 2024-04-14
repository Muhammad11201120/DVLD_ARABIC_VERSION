using DVLD_AR.Licenses;
using DVLD_AR.Licenses.International_License;
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

namespace DVLD_AR.Applications.International_License
{
    public partial class frmListAllInterNationalLicenses : Form
    {
        private DataTable dt = null;
        private DataView dv = null;
        public frmListAllInterNationalLicenses()
        {
            InitializeComponent();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
        private void _LoadData()
        {
            dt = clsInternationalLicense.GetAllInternationalLicenses();
            dv = new DataView( dt );
            dataGridView1.DataSource = dv;
            cbFilters.SelectedIndex = 0;

            lblRecords.Text = dv.Count.ToString();

            dataGridView1.Columns[ 0 ].HeaderText = "رقم الرخصة الدولية";
            dataGridView1.Columns[ 0 ].Width = 160;

            dataGridView1.Columns[ 1 ].HeaderText = "رقم الطلب";
            dataGridView1.Columns[ 1 ].Width = 150;

            dataGridView1.Columns[ 2 ].HeaderText = "رقم السائق";
            dataGridView1.Columns[ 2 ].Width = 130;

            dataGridView1.Columns[ 3 ].HeaderText = "رقم الرخصة المحلية";
            dataGridView1.Columns[ 3 ].Width = 130;

            dataGridView1.Columns[ 4 ].HeaderText = "تاريخ الإصدار";
            dataGridView1.Columns[ 4 ].Width = 180;

            dataGridView1.Columns[ 5 ].HeaderText = "تارخ الأنتهاء";
            dataGridView1.Columns[ 5 ].Width = 180;

            dataGridView1.Columns[ 6 ].HeaderText = "حالة الرخصة";
            dataGridView1.Columns[ 6 ].Width = 120;

        }

        private void btnAdd_Click( object sender, EventArgs e )
        {
            frmNewInterNationalLicenseApplication frm = new frmNewInterNationalLicenseApplication();
            frm.ShowDialog();
            _LoadData();
        }

        private void معلوماتالمتقدمToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int DriverID = ( int ) dataGridView1.CurrentRow.Cells[ 2 ].Value;
            int PersonID = clsDriver.FindByDriverID( DriverID ).PersonID;

            frmShowPersonInfo frm = new frmShowPersonInfo( PersonID );
            frm.ShowDialog();
        }

        private void معلوماتالرخصةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int InternationalLicenseID = ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value;
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo( InternationalLicenseID );
            frm.ShowDialog();
        }

        private void سجلالرخصةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int DriverID = ( int ) dataGridView1.CurrentRow.Cells[ 2 ].Value;
            int PersonID = clsDriver.FindByDriverID( DriverID ).PersonID;
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory( PersonID );
            frm.ShowDialog();
        }

        private void txtFilter_TextChanged( object sender, EventArgs e )
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch ( cbFilters.Text )
            {
                case "رقم الرخصة الدولية":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "رقم الطلب":
                    {
                        FilterColumn = "ApplicationID";
                        break;
                    };

                case "رقم السائق":
                    FilterColumn = "DriverID";
                    break;

                case "رقم الرخصة المحلية":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;

                case "حالة الرخصة":
                    FilterColumn = "IsActive";
                    break;


                default:
                    FilterColumn = "لاشيء";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if ( txtFilter.Text.Trim() == "" || FilterColumn == "لاشيء" )
            {
                dv.RowFilter = "";
                lblRecords.Text = dv.Count.ToString();
                return;
            }



            dv.RowFilter = string.Format( "[{0}] = {1}", FilterColumn, txtFilter.Text.Trim() );

            lblRecords.Text = dv.Count.ToString();
        }

        private void txtFilter_KeyPress( object sender, KeyPressEventArgs e )
        {
            e.Handled = !char.IsDigit( e.KeyChar ) && !char.IsControl( e.KeyChar );
        }

        private void cbIsActive_SelectedIndexChanged( object sender, EventArgs e )
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch ( FilterValue )
            {
                case "الكل":
                    break;
                case "نعم":
                    FilterValue = "1";
                    break;
                case "لا":
                    FilterValue = "0";
                    break;
                default:
                    FilterValue = "الكل";
                    break;
            }
            if ( FilterValue == "الكل" )
                dv.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                dv.RowFilter = string.Format( "[{0}] = {1}", FilterColumn, FilterValue );

            lblRecords.Text = dv.Count.ToString();
        }

        private void cbFilters_SelectedIndexChanged( object sender, EventArgs e )
        {
            if ( cbFilters.Text == "حالة الرخصة" )
            {
                txtFilter.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }

            else

            {

                txtFilter.Visible = ( cbFilters.Text != "لاشيء" );
                cbIsActive.Visible = false;

                if ( cbFilters.Text == "لاشيء" )
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

        private void frmListAllInterNationalLicenses_Load( object sender, EventArgs e )
        {
            _LoadData();
        }
    }
}
