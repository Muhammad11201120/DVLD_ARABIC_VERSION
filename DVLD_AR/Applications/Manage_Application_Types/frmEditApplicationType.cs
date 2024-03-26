using DVLD_AR.GeneralClasses;
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
            this._ApplicationType = clsApplicationType.Find( this._ApplicationTypeID );
        }
        private void _LoadData()
        {

            if ( this._ApplicationType == null )
            {
                MessageBox.Show( "لايوجد نوع طلب بهذا الرقم" );
                this.Close();
                return;
            }
            lblApplicationTypeID.Text = _ApplicationTypeID.ToString();
            txtApplicationTypeTitle.Text = _ApplicationType.Title.ToString();
            txtApplicationTypeFees.Text = _ApplicationType.Fees.ToString();
        }
        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmEditApplicationType_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            if ( !this.ValidateChildren() )
            {
                MessageBox.Show( "القيم في بعض الحقول غير صحيحة مرٌر الفاره على علامة التعجب الحمراء ليظهر لك نوع الخطأ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information );
                return;
            }
            _ApplicationType.Title = txtApplicationTypeTitle.Text.Trim();
            _ApplicationType.Fees = float.Parse( txtApplicationTypeFees.Text.Trim() );
            if ( _ApplicationType.Save() )
            {
                MessageBox.Show( "تم حفظ البيانات بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information );
                this.Close();
            }
            else
            {
                MessageBox.Show( "خطأ أثناء محاولة حفظ البيانات الرجاء المحاولة مرة أخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void txtApplicationTypeTitle_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtApplicationTypeTitle.Text ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtApplicationTypeTitle, "هذا الحقل مطلوب" );
            }
            else
            {
                errorProvider1.SetError( txtApplicationTypeTitle, null );
            }
        }

        private void txtApplicationTypeFees_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtApplicationTypeFees.Text ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtApplicationTypeFees, "هذا الحقل مطلوب" );
            }
            else
            {
                errorProvider1.SetError( txtApplicationTypeTitle, null );
            }
            if ( !clsValidatoin.IsNumber( txtApplicationTypeFees.Text ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtApplicationTypeFees, "الرجاء إدخال قيمة رقمية فقط" );
            }
            else
            {
                errorProvider1.SetError( txtApplicationTypeTitle, null );
            }
        }
    }
}
