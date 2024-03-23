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

namespace DVLD_AR.Users
{
    public partial class frmAllUsersList : Form
    {
        public frmAllUsersList()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            DataTable dt = clsUser.GetAllUsers();
            DataView dv = new DataView( dt );
            dataGridView1.DataSource = dv;
        }
        private void frmAllUsersList_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void btnAddUser_Click( object sender, EventArgs e )
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }

        private void إظهارمعلوماتالمستخدمToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Form frm = new frmShowUserInfo( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            frm.ShowDialog();
        }

        private void إظافةمستخدمجديدToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Form frm = new frmAddUpdateUser();
            frm.ShowDialog();
            _LoadData();
        }

        private void تعديلToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAddUpdateUser frm = new frmAddUpdateUser( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            frm.ShowDialog();
            _LoadData();
        }

        private void حذفToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( clsUser.DeleteUser( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value ) )
            {
                MessageBox.Show( "تم حذف هذا المستخدم بنجاح" );
                _LoadData();
            }
            else
                MessageBox.Show( "لم يتم حذف المستخدم لارتباطه ببيانات اخرى في النظام" );
        }

        private void إرسالبريدالكنرونيToolStripMenuItem_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "سيتم تنفيذ هذه الخاصية لاحقا" );
            return;
        }

        private void مكالمةهاتفيةToolStripMenuItem_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "سيتم تنفيذ هذه الخاصية لاحقا" );
            return;
        }

        private void خروجToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
