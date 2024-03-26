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

namespace DVLD_AR.Tests.TestTypes
{
    public partial class frmListAllTestTypes : Form
    {
        public frmListAllTestTypes()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            DataTable dt = clsTestType.GetAllTestTypes();
            DataView dv = new DataView( dt );
            dataGridView1.DataSource = dv;
        }
        private void frmListAllTestTypes_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void تعديلنوعالإختبارToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmEditTestTypes frm = new frmEditTestTypes( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            frm.ShowDialog();
            _LoadData();
        }
    }
}
