using DVLD_AR.Licenses;
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

namespace DVLD_AR.Drivers
{
    public partial class frmListAllDrivers : Form
    {
        DataTable dt = null;
        public frmListAllDrivers()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            cbxFilters.SelectedIndex = 0;
            dt = clsDriver.GetAllDrivers();

            dgvDrivers.DataSource = dt;
            lblRecords.Text = dt.Rows.Count.ToString();
            if ( dgvDrivers.Rows.Count > 0 )
            {
                dgvDrivers.Columns[ 0 ].HeaderText = "رقم السائق";
                dgvDrivers.Columns[ 0 ].Width = 120;

                dgvDrivers.Columns[ 1 ].HeaderText = "الرقم الشخصي";
                dgvDrivers.Columns[ 1 ].Width = 120;

                dgvDrivers.Columns[ 2 ].HeaderText = "الهويٌة";
                dgvDrivers.Columns[ 2 ].Width = 140;

                dgvDrivers.Columns[ 3 ].HeaderText = "الإسم";
                dgvDrivers.Columns[ 3 ].Width = 320;

                dgvDrivers.Columns[ 4 ].HeaderText = "التاريخ";
                dgvDrivers.Columns[ 4 ].Width = 170;

                dgvDrivers.Columns[ 5 ].HeaderText = "الرخص النشطة";
                dgvDrivers.Columns[ 5 ].Width = 150;
            }

        }
        private void frmListAllDrivers_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void cbxFilters_SelectedIndexChanged( object sender, EventArgs e )
        {
            txtFilter.Visible = ( cbxFilters.Text != "الكل" );


            if ( cbxFilters.Text == "الكل" )
            {
                txtFilter.Enabled = false;
            }
            else
                txtFilter.Enabled = true;

            txtFilter.Text = "";
            txtFilter.Focus();
        }

        private void txtFilter_TextChanged( object sender, EventArgs e )
        {
            string FilterColumn = "";
            switch ( cbxFilters.Text )
            {
                case "رقم السائق":
                    FilterColumn = "DriverID";
                    break;

                case "الرقم الشخصي":
                    FilterColumn = "PersonID";
                    break;

                case "الهويٌة":
                    FilterColumn = "NationalNo";
                    break;


                case "الإسم":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "الكل";
                    break;

            }

            //Reset the filters in case nothing selected or filter value contains nothing.
            if ( txtFilter.Text.Trim() == "" || FilterColumn == "الكل" )
            {
                dt.DefaultView.RowFilter = "";
                lblRecords.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }
            if ( FilterColumn != "FullName" && FilterColumn != "NationalNo" )
                //in this case we deal with numbers not string.
                dt.DefaultView.RowFilter = string.Format( "[{0}] = {1}", FilterColumn, txtFilter.Text.Trim() );
            else
                dt.DefaultView.RowFilter = string.Format( "[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim() );

            lblRecords.Text = dt.Rows.Count.ToString();
        }

        private void txtFilter_KeyPress( object sender, KeyPressEventArgs e )
        {
            //we allow number incase person id or user id is selected.
            if ( cbxFilters.Text == "رقم السائق" || cbxFilters.Text == "الرقم الشخصي" )
                e.Handled = !char.IsDigit( e.KeyChar ) && !char.IsControl( e.KeyChar );
        }

        private void معلوماتالسائقToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmShowPersonInfo frm = new frmShowPersonInfo( Convert.ToInt32( dgvDrivers.SelectedRows[ 0 ].Cells[ 1 ].Value ) );
            frm.ShowDialog();
        }

        private void إصداررخصةدوليةToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void جميعرخصالسائقToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory( Convert.ToInt32( dgvDrivers.SelectedRows[ 0 ].Cells[ 1 ].Value ) );
            frm.ShowDialog();
        }
    }
}
