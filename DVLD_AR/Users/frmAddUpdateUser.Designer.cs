namespace DVLD_AR.Users
{
    partial class frmAddUpdateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmAddUpdateUser ) );
            this.lblTilte = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tapUser = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrPersonCardWithFilter1 = new DVLD_AR.People.Controllers.ctrPersonCardWithFilter();
            this.tpUserInfo = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtConfirmPassord = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.chbxIsActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider( this.components );
            this.tapUser.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpUserInfo.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox4 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox3 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // lblTilte
            // 
            this.lblTilte.AutoSize = true;
            this.lblTilte.Font = new System.Drawing.Font( "Rubik", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblTilte.Location = new System.Drawing.Point( 486, 29 );
            this.lblTilte.Name = "lblTilte";
            this.lblTilte.Size = new System.Drawing.Size( 261, 42 );
            this.lblTilte.TabIndex = 0;
            this.lblTilte.Text = "إظافة مستخدم جديد";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point( 12, 102 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 1254, 618 );
            this.panel1.TabIndex = 1;
            // 
            // tapUser
            // 
            this.tapUser.Controls.Add( this.tpPersonInfo );
            this.tapUser.Controls.Add( this.tpUserInfo );
            this.tapUser.Location = new System.Drawing.Point( 12, 105 );
            this.tapUser.Name = "tapUser";
            this.tapUser.RightToLeftLayout = true;
            this.tapUser.SelectedIndex = 0;
            this.tapUser.Size = new System.Drawing.Size( 1250, 612 );
            this.tapUser.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.tpPersonInfo.Controls.Add( this.btnNext );
            this.tpPersonInfo.Controls.Add( this.ctrPersonCardWithFilter1 );
            this.tpPersonInfo.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.tpPersonInfo.Location = new System.Drawing.Point( 4, 22 );
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding( 3 );
            this.tpPersonInfo.Size = new System.Drawing.Size( 1242, 586 );
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "المعلومات الشخصية";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnNext.Image = global::DVLD_AR.Properties.Resources.nextRtl1;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point( 25, 515 );
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size( 107, 47 );
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "التالي";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler( this.btnNext_Click );
            // 
            // ctrPersonCardWithFilter1
            // 
            this.ctrPersonCardWithFilter1.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.ctrPersonCardWithFilter1.FilterEnabled = true;
            this.ctrPersonCardWithFilter1.Location = new System.Drawing.Point( 25, 7 );
            this.ctrPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
            this.ctrPersonCardWithFilter1.Name = "ctrPersonCardWithFilter1";
            this.ctrPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrPersonCardWithFilter1.Size = new System.Drawing.Size( 1193, 519 );
            this.ctrPersonCardWithFilter1.TabIndex = 0;
            // 
            // tpUserInfo
            // 
            this.tpUserInfo.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.tpUserInfo.Controls.Add( this.pictureBox4 );
            this.tpUserInfo.Controls.Add( this.pictureBox3 );
            this.tpUserInfo.Controls.Add( this.pictureBox2 );
            this.tpUserInfo.Controls.Add( this.pictureBox1 );
            this.tpUserInfo.Controls.Add( this.txtConfirmPassord );
            this.tpUserInfo.Controls.Add( this.txtPassword );
            this.tpUserInfo.Controls.Add( this.txtUserName );
            this.tpUserInfo.Controls.Add( this.txtUserID );
            this.tpUserInfo.Controls.Add( this.chbxIsActive );
            this.tpUserInfo.Controls.Add( this.label5 );
            this.tpUserInfo.Controls.Add( this.label4 );
            this.tpUserInfo.Controls.Add( this.label3 );
            this.tpUserInfo.Controls.Add( this.label2 );
            this.tpUserInfo.Location = new System.Drawing.Point( 4, 22 );
            this.tpUserInfo.Name = "tpUserInfo";
            this.tpUserInfo.Padding = new System.Windows.Forms.Padding( 3 );
            this.tpUserInfo.Size = new System.Drawing.Size( 1242, 586 );
            this.tpUserInfo.TabIndex = 1;
            this.tpUserInfo.Text = "معلومات التسجيل والدخول";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_AR.Properties.Resources.Person_32;
            this.pictureBox4.Location = new System.Drawing.Point( 929, 235 );
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size( 32, 32 );
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_AR.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point( 929, 164 );
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size( 32, 32 );
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_AR.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point( 929, 306 );
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size( 32, 32 );
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_AR.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point( 929, 101 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 32, 32 );
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtConfirmPassord
            // 
            this.txtConfirmPassord.Location = new System.Drawing.Point( 637, 309 );
            this.txtConfirmPassord.Name = "txtConfirmPassord";
            this.txtConfirmPassord.Size = new System.Drawing.Size( 286, 20 );
            this.txtConfirmPassord.TabIndex = 9;
            this.txtConfirmPassord.Validating += new System.ComponentModel.CancelEventHandler( this.txtConfirmPassord_Validating );
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point( 637, 241 );
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size( 286, 20 );
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler( this.txtPassword_Validating );
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point( 637, 173 );
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size( 286, 20 );
            this.txtUserName.TabIndex = 7;
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point( 637, 105 );
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size( 286, 20 );
            this.txtUserID.TabIndex = 6;
            // 
            // chbxIsActive
            // 
            this.chbxIsActive.AutoSize = true;
            this.chbxIsActive.Checked = true;
            this.chbxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxIsActive.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.chbxIsActive.Location = new System.Drawing.Point( 832, 377 );
            this.chbxIsActive.Name = "chbxIsActive";
            this.chbxIsActive.Size = new System.Drawing.Size( 91, 24 );
            this.chbxIsActive.TabIndex = 5;
            this.chbxIsActive.Text = "حالة النشاط";
            this.chbxIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label5.Location = new System.Drawing.Point( 967, 309 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 127, 24 );
            this.label5.TabIndex = 3;
            this.label5.Text = "تأكيد كلمة المرور : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label4.Location = new System.Drawing.Point( 967, 243 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 93, 24 );
            this.label4.TabIndex = 2;
            this.label4.Text = "كلمة المرور : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label3.Location = new System.Drawing.Point( 967, 173 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 124, 24 );
            this.label3.TabIndex = 1;
            this.label3.Text = "إسم المستخدم : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label2.Location = new System.Drawing.Point( 967, 105 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 162, 24 );
            this.label2.TabIndex = 0;
            this.label2.Text = "رقم معرُف المستخدم : ";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnClose.Image = global::DVLD_AR.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point( 1025, 749 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 107, 47 );
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "إلغاء";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnSave.Image = global::DVLD_AR.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point( 1155, 749 );
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size( 107, 47 );
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler( this.btnSave_Click );
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 1274, 915 );
            this.Controls.Add( this.tapUser );
            this.Controls.Add( this.btnSave );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.panel1 );
            this.Controls.Add( this.lblTilte );
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "frmAddUpdateUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdateUser";
            this.Activated += new System.EventHandler( this.frmAddUpdateUser_Activated );
            this.Load += new System.EventHandler( this.frmAddUpdateUser_Load );
            this.tapUser.ResumeLayout( false );
            this.tpPersonInfo.ResumeLayout( false );
            this.tpUserInfo.ResumeLayout( false );
            this.tpUserInfo.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox4 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox3 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTilte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tapUser;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpUserInfo;
        private People.Controllers.ctrPersonCardWithFilter ctrPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtConfirmPassord;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.CheckBox chbxIsActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}