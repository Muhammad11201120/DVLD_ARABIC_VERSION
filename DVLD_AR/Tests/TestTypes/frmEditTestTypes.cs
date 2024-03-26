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

namespace DVLD_AR.Tests.TestTypes
{
    public partial class frmEditTestTypes : Form
    {

        private int _TestTypeID = -1;
        private clsTestType _TestType = null;

        public frmEditTestTypes( int testTypeID )
        {
            InitializeComponent();
            this._TestTypeID = testTypeID;
            if ( this._TestTypeID != -1 )
            {
                _TestType = clsTestType.Find( ( clsTestType.enTestType ) testTypeID );
            }
        }

        private void _LoadData()
        {
            if ( _TestType == null )
            {
                MessageBox.Show( "لايوجد لإختبار بهذا الرقم" );
                return;
            }
            lblTestTypeID.Text = ( ( int ) _TestType.ID ).ToString();
            txtTestTypeTitle.Text = _TestType.Title;
            txtDescription.Text = _TestType.Description;
            txtFees.Text = _TestType.Fees.ToString();
        }

        private void frmEditTestTypes_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            if ( !ValidateChildren() )
            {
                MessageBox.Show( "الرجاء ملئ الحقول الفارغة" );
                return;
            }
            _TestType.Title = txtTestTypeTitle.Text.Trim();
            _TestType.Description = txtDescription.Text.Trim();
            _TestType.Fees = Convert.ToSingle( txtFees.Text.Trim() );
            if ( _TestType.Save() )
            {
                MessageBox.Show( "تم حفظ التعديلات بنجاح" );
                this.Close();
            }
            else
            {
                MessageBox.Show( "حدث خطأ اثناء حفظ التعديلات" );
            }
        }

        private void txtTestTypeTitle_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtTestTypeTitle.Text ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtTestTypeTitle, "هذا الحقل مطلوب" );
            }
            else
            {
                errorProvider1.SetError( txtTestTypeTitle, null );
            }
        }

        private void txtDescription_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtDescription.Text ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtDescription, "هذا الحقل مطلوب" );
            }
            else
            {
                errorProvider1.SetError( txtDescription, null );
            }
        }

        private void txtFees_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtFees.Text ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtFees, "هذا الحقل مطلوب" );
            }
            else
            {
                errorProvider1.SetError( txtDescription, null );
            }
            if ( !clsValidatoin.IsNumber( txtFees.Text ) )
            {
                e.Cancel = true;
                errorProvider1.SetError( txtFees, "هذا الحقل يجب ان يكون رقم" );
            }
            else
            {
                errorProvider1.SetError( txtDescription, null );
            }
        }
    }
}
