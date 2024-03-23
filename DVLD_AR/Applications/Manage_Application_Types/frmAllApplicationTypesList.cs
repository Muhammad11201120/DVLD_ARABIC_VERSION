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

namespace DVLD_AR.Applications.Manage_Application_Types
{
    public partial class frmAllApplicationTypesList : Form
    {
        private void _LoadData()
        {
            DataTable dt = clsApplicationType.GetAllApplicationTypes();
            DataView dv = new DataView( dt );
            dataGridView1.DataSource = dv;

            lblRecords.Text = dt.Rows.Count.ToString();
        }
        public frmAllApplicationTypesList()
        {
            InitializeComponent();
        }

        private void frmAllApplicationTypesList_Load( object sender, EventArgs e )
        {
            _LoadData();

        }

        private void تعديلنوعالطلبToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmEditApplicationType frm = new frmEditApplicationType( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            frm.ShowDialog();
        }
    }
}
