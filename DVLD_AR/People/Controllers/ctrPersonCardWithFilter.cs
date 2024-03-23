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

namespace DVLD_AR.People.Controllers
{
    public partial class ctrPersonCardWithFilter : UserControl
    {
        //define a custom event handler delegate with parameter
        public event Action<int> OnPersonSelected;
        //create a protected method to raise the event
        protected virtual void PersonSelected( int personID )
        {
            Action<int> handler = OnPersonSelected;
            if ( handler != null )
            {
                handler( personID ); // raise the event with the parameter
            }
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btnAddPerson.Visible = _ShowAddPerson;
            }
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbxFilter.Enabled = _FilterEnabled;
            }
        }
        public ctrPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public int PersonId
        {
            get { return ctrPersonCard1.PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return ctrPersonCard1.SelectedPersonInfo; }
        }
        public void LoadPersonInfo( int PersonID )
        {

            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();
            FindNow();

        }
        private void FindNow()
        {
            switch ( cbFilterBy.Text )
            {
                case "المعرٌف":

                    ctrPersonCard1.LoadPerson( int.Parse( txtFilterValue.Text ) );
                    break;

                case "الهوية":

                    ctrPersonCard1.LoadPerson( txtFilterValue.Text );
                    break;

                default:
                    break;
            }

            if ( OnPersonSelected != null && FilterEnabled )
                // Raise the event with a parameter
                OnPersonSelected( ctrPersonCard1.PersonID );
        }

        private void cbFilterBy_SelectedIndexChanged( object sender, EventArgs e )
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void btnSearchForPerson_Click( object sender, EventArgs e )
        {
            if ( !this.ValidateChildren() )
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show( "بعض القيم في الحقول غير صحيحة, ضع الفارة على علامة التعجب الحمراء ليظهر لك نوع الخطأ!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;

            }

            FindNow();
        }

        private void gbxFilter_Enter( object sender, EventArgs e )
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrEmpty( txtFilterValue.Text.Trim() ) && gbxFilter.Text == string.Empty )
            {
                errorProvider1.SetError( txtFilterValue, "هذا الحقل مطلوب !" );
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError( txtFilterValue, null );
            }
        }

        private void btnAddPerson_Click( object sender, EventArgs e )
        {
            frmAddUpdatePerson frm1 = new frmAddUpdatePerson();
            frm1.DataBack += DataBackEvent; // Subscribe to the event
            frm1.ShowDialog();
        }
        private void DataBackEvent( object sender, int PersonID )
        {
            // Handle the data received

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrPersonCard1.LoadPerson( PersonID );
        }
        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress( object sender, KeyPressEventArgs e )
        {
            // Check if the pressed key is Enter (character code 13)
            if ( e.KeyChar == ( char ) 13 )
            {
                btnSearchForPerson.PerformClick();
            }

            //this will allow only digits if person id is selected
            if ( cbFilterBy.Text == "المعرٌف" )
                e.Handled = !char.IsDigit( e.KeyChar ) && !char.IsControl( e.KeyChar );
        }
    }
}
