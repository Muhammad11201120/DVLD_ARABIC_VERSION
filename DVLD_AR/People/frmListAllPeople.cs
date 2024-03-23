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

namespace DVLD_AR.People
{
    public partial class frmListAllPeople : Form
    {
        DataTable dt = null;
        DataView dv = null;
        public frmListAllPeople()
        {
            InitializeComponent();
        }
        private void _LoadPeople()
        {
            dt = clsPerson.GetAllPeople();

            dv = new DataView( dt );

            dataGridView1.DataSource = dv;
        }
        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnAddPerson_Click( object sender, EventArgs e )
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
        }

        private void frmListAllPeople_Load( object sender, EventArgs e )
        {
            _LoadPeople();
        }

        private void تعديلToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson( clsPerson.Find( int.Parse( dataGridView1.CurrentRow.Cells[ 0 ].Value.ToString() ) ).PersonID );
            frm.ShowDialog();
            _LoadPeople();
        }

        private void تفاصيلمعلوماتالشخصToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmShowPersonInfo frm = new frmShowPersonInfo( int.Parse( dataGridView1.CurrentRow.Cells[ 0 ].Value.ToString() ) );
            frm.ShowDialog();
        }

        private void إظافةشخصجديدToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _LoadPeople();
        }

        private void txtFilter_TextChanged( object sender, EventArgs e )
        {
            string FilterName = string.Empty;
            switch ( cbxFilters.Text )
            {
                case "المعرٌف":
                    FilterName = "المعرٌف";
                    break;
                case "الإسم":
                    FilterName = "الإسم الأول";
                    break;
                case "الأب":
                    FilterName = "الإسم الثاني";
                    break;
                case "الجد":
                    FilterName = "الإسم الثالث";
                    break;
                case "العائلة":
                    FilterName = "الإسم العائلة";
                    break;
                case "الجنس":
                    FilterName = "الجنس";
                    break;
                case "الجنسية":
                    FilterName = "الجنسية";
                    break;
                case "الإيميل":
                    FilterName = "الإيميل";
                    break;
                case "الهاتف":
                    FilterName = "رقم الهاتف";
                    break;
                case "الهوية":
                    FilterName = "رقم الهوية";
                    break;
                default:
                    FilterName = "لاشيء";
                    break;
            }
            if ( txtFilter.Text.Trim() == string.Empty )
            {
                dv.RowFilter = "";
                return;
            }
            if ( cbxFilters.Text == "المعرٌف" )
                //in this case we deal with integer not string.
                dv.RowFilter = string.Format( "[{0}] = {1}", FilterName, txtFilter.Text.Trim() );
            else
                dv.RowFilter = string.Format( "[{0}] LIKE '{1}%'", FilterName, txtFilter.Text.Trim() );
        }

        private void cbxFilters_SelectedIndexChanged( object sender, EventArgs e )
        {
            txtFilter.Visible = ( cbxFilters.Text != string.Empty );

            if ( txtFilter.Visible )
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_KeyPress( object sender, KeyPressEventArgs e )
        {
            //we allow number incase person id is selected.
            if ( cbxFilters.Text == "المعرٌف" )
                e.Handled = !char.IsDigit( e.KeyChar ) && !char.IsControl( e.KeyChar );
        }

        private void dataGridView1_DoubleClick( object sender, EventArgs e )
        {
            frmShowPersonInfo frm = new frmShowPersonInfo( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            frm.ShowDialog();
        }

        private void حذفالشخصمنالنظامToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "  هل أنت متأكد من عملية حذف  " + dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString().Trim() + " " + dataGridView1.CurrentRow.Cells[ 5 ].Value.ToString().Trim(), "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question ) == DialogResult.OK )
            {
                if ( clsPerson.DeletePerson( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value ) )
                {
                    MessageBox.Show( "تم الحذف بنجاح" );
                    _LoadPeople();
                }
                else
                {
                    MessageBox.Show( "لم يتم الحذف نظرا لارتباط هذا الشخص ببيانات أخرى في النظام", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        private void خروجToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
