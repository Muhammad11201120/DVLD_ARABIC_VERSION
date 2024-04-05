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

namespace DVLD_AR.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _AppointmentID;
        private clsTestType.enTestType _TestType;

        private int _TestID = -1;
        private clsTest _Test;
        public frmTakeTest( int AppointmentID, clsTestType.enTestType TestType )
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _TestType = TestType;
        }

        private void frmTakeTest_Load( object sender, EventArgs e )
        {
            ctrScehduledTest1.TestTypeID = _TestType;

            ctrScehduledTest1.LoadInfo( _AppointmentID );

            if ( ctrScehduledTest1.TestAppointmentID == -1 )
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;


            int _TestID = ctrScehduledTest1.TestID;
            if ( _TestID != -1 )
            {
                _Test = clsTest.Find( _TestID );

                if ( _Test.TestResult )
                    rbtnPass.Checked = true;
                else
                    rbtnFail.Checked = true;
                txtNotes.Text = _Test.Notes;

                lblUserMessage.Visible = true;
                rbtnFail.Enabled = false;
                rbtnPass.Enabled = false;
                btnSave.Visible = false;
            }

            else
                _Test = new clsTest();
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "هل أنت متأكد من عملية حفظ نتيجة الإختبار ؟ / لايمكن تغيير النتيجة في حالة التأكيد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.No )
            {
                return;
            }

            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rbtnPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if ( _Test.Save() )
            {
                MessageBox.Show( "تم حفظ بيانات الإختبار بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information );
                btnSave.Enabled = false;

            }
            else
                MessageBox.Show( "لم يتم حفظ البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
