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
    public partial class frmEditApplicationType : Form
    {
        private int _ApplicationTypeID = -1;
        clsApplicationType _ApplicationType = null;
        public frmEditApplicationType( int applicationTypeID )
        {
            InitializeComponent();
            this._ApplicationTypeID = applicationTypeID;
            clsApplicationType.Find( applicationTypeID );
        }
        private void _LoadDatat()
        {
            if ( this._ApplicationType == null )
            {
                MessageBox.Show( "لايوجد نوع طلب بهذا الرقم" );
                this.Close();
                return;
            }
            lblApplicationTypeID.Text = _ApplicationTypeID.ToString();
            txtApplicationTypeTitle.Text = _ApplicationTypeID.ToString();
            txtApplicationTypeFees.Text = _ApplicationType.Fees.ToString();
        }
        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmEditApplicationType_Load( object sender, EventArgs e )
        {
            _LoadDatat();
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            _ApplicationType.Title = txtApplicationTypeTitle.Text.Trim();
            _ApplicationType.Fees = float.Parse( txtApplicationTypeFees.Text.Trim() );
            if ( _ApplicationType.Save() )
            {
                MessageBox.Show( "تم حفظ البيانات بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else
            {
                MessageBox.Show( "خطأ أثناء محاولة حفظ البيانات الرجاء المحاولة مرة أخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
