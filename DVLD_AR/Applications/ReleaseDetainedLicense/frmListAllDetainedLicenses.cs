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
            dv = new DataView(dt);
            dataGridView1.DataSource = dv;
        }
        private void frmListAllDetainedLicenses_Load( object sender, EventArgs e )
        {
            _LoadData();
        }
    }
}
