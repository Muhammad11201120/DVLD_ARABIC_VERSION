namespace DVLD_AR.Licenses.Local_License
{
    partial class frmIssueDriverLicenseForFirstTime
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
            this.ctrDrivingLicenseApplicationInfo1 = new DVLD_AR.Applications.LocalDrivingLicenseApplications.ctrDrivingLicenseApplicationInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // ctrDrivingLicenseApplicationInfo1
            // 
            this.ctrDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.ctrDrivingLicenseApplicationInfo1.ForeColor = System.Drawing.Color.White;
            this.ctrDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point( 12, 12 );
            this.ctrDrivingLicenseApplicationInfo1.Name = "ctrDrivingLicenseApplicationInfo1";
            this.ctrDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size( 1254, 626 );
            this.ctrDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label1.Location = new System.Drawing.Point( 12, 641 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 85, 24 );
            this.label1.TabIndex = 1;
            this.label1.Text = "ملاحظات : ";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point( 142, 644 );
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size( 1124, 123 );
            this.txtNotes.TabIndex = 2;
            this.txtNotes.Text = "";
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnIssueLicense.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnIssueLicense.Image = global::DVLD_AR.Properties.Resources.IssueDrivingLicense_321;
            this.btnIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssueLicense.Location = new System.Drawing.Point( 1035, 773 );
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size( 100, 49 );
            this.btnIssueLicense.TabIndex = 4;
            this.btnIssueLicense.Text = "إصدار";
            this.btnIssueLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler( this.btnIssueLicense_Click );
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_AR.Properties.Resources.Notes_32;
            this.pictureBox1.Location = new System.Drawing.Point( 102, 644 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 32, 32 );
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnClose.Image = global::DVLD_AR.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point( 1166, 773 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 100, 49 );
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "إغلاق";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // frmIssueDriverLicenseForFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 1272, 830 );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.btnIssueLicense );
            this.Controls.Add( this.pictureBox1 );
            this.Controls.Add( this.txtNotes );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.ctrDrivingLicenseApplicationInfo1 );
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIssueDriverLicenseForFirstTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إصدار رخصة قيادة لأول مرٌة";
            this.Load += new System.EventHandler( this.frmIssueDriverLicenseForFirstTime_Load );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private Applications.LocalDrivingLicenseApplications.ctrDrivingLicenseApplicationInfo ctrDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.Button btnClose;
    }
}