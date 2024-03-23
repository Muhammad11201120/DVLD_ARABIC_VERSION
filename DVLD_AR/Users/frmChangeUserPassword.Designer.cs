namespace DVLD_AR.Users
{
    partial class frmChangeUserPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmChangeUserPassword ) );
            this.ctrUserInfoCard1 = new DVLD_AR.Users.Controls.ctrUserInfoCard();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider( this.components );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox3 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // ctrUserInfoCard1
            // 
            this.ctrUserInfoCard1.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.ctrUserInfoCard1.ForeColor = System.Drawing.Color.White;
            this.ctrUserInfoCard1.Location = new System.Drawing.Point( 12, 72 );
            this.ctrUserInfoCard1.Name = "ctrUserInfoCard1";
            this.ctrUserInfoCard1.Size = new System.Drawing.Size( 1187, 540 );
            this.ctrUserInfoCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Rubik", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point( 513, 32 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 184, 37 );
            this.label1.TabIndex = 1;
            this.label1.Text = "تغيير كلمة المرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point( 98, 664 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 142, 24 );
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة المرور الحالية : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point( 641, 664 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 151, 24 );
            this.label3.TabIndex = 3;
            this.label3.Text = "كلمة المرور الجديدة : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point( 59, 711 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 181, 24 );
            this.label4.TabIndex = 4;
            this.label4.Text = "تأكيد كلمة المرور الجديدة :";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point( 284, 664 );
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size( 316, 20 );
            this.txtCurrentPassword.TabIndex = 5;
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler( this.txtCurrentPassword_Validating );
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Location = new System.Drawing.Point( 284, 714 );
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size( 316, 20 );
            this.txtConfirmNewPassword.TabIndex = 6;
            this.txtConfirmNewPassword.Validating += new System.ComponentModel.CancelEventHandler( this.txtConfirmNewPassword_Validating );
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point( 836, 664 );
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size( 316, 20 );
            this.txtNewPassword.TabIndex = 7;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler( this.txtNewPassword_Validating );
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_AR.Properties.Resources.Password_32;
            this.pictureBox1.Location = new System.Drawing.Point( 246, 660 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 32, 32 );
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_AR.Properties.Resources.Password_32;
            this.pictureBox2.Location = new System.Drawing.Point( 798, 660 );
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size( 32, 32 );
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_AR.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point( 246, 710 );
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size( 32, 32 );
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnSave.Image = global::DVLD_AR.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point( 836, 714 );
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size( 134, 37 );
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "تأكيد و حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler( this.btnSave_Click );
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnClose.Image = global::DVLD_AR.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point( 1018, 714 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 134, 37 );
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "إلغاء";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 1210, 775 );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.btnSave );
            this.Controls.Add( this.pictureBox3 );
            this.Controls.Add( this.pictureBox2 );
            this.Controls.Add( this.pictureBox1 );
            this.Controls.Add( this.txtNewPassword );
            this.Controls.Add( this.txtConfirmNewPassword );
            this.Controls.Add( this.txtCurrentPassword );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.ctrUserInfoCard1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "frmChangeUserPassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تغيير كلمة المرور";
            this.Load += new System.EventHandler( this.frmChangeUserPassword_Load );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox3 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrUserInfoCard ctrUserInfoCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}