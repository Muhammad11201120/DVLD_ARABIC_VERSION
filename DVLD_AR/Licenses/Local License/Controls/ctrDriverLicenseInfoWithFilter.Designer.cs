namespace DVLD_AR.Licenses.Controls
{
    partial class ctrDriverLicenseInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrDriverLicenseInfo1 = new DVLD_AR.Licenses.Controls.ctrDriverLicenseInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider( this.components );
            this.gbFilter.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox4 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add( this.btnSearch );
            this.gbFilter.Controls.Add( this.pictureBox4 );
            this.gbFilter.Controls.Add( this.txtLicenseID );
            this.gbFilter.Controls.Add( this.label1 );
            this.gbFilter.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point( 3, 3 );
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size( 1118, 137 );
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "بحث : ";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnSearch.Image = global::DVLD_AR.Properties.Resources.License_View_321;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point( 243, 47 );
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size( 96, 43 );
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "بحث";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler( this.btnSearch_Click );
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_AR.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point( 874, 52 );
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size( 32, 32 );
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.Location = new System.Drawing.Point( 345, 55 );
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size( 523, 26 );
            this.txtLicenseID.TabIndex = 1;
            this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.txtLicenseID_KeyPress );
            this.txtLicenseID.Validating += new System.ComponentModel.CancelEventHandler( this.txtLicenseID_Validating );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 906, 56 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 99, 24 );
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الرخصة : ";
            // 
            // ctrDriverLicenseInfo1
            // 
            this.ctrDriverLicenseInfo1.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.ctrDriverLicenseInfo1.ForeColor = System.Drawing.Color.White;
            this.ctrDriverLicenseInfo1.Location = new System.Drawing.Point( 3, 146 );
            this.ctrDriverLicenseInfo1.Name = "ctrDriverLicenseInfo1";
            this.ctrDriverLicenseInfo1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrDriverLicenseInfo1.Size = new System.Drawing.Size( 1118, 454 );
            this.ctrDriverLicenseInfo1.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrIssueDriverLicenseWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.Controls.Add( this.ctrDriverLicenseInfo1 );
            this.Controls.Add( this.gbFilter );
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrIssueDriverLicenseWithFilter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size( 1124, 603 );
            this.gbFilter.ResumeLayout( false );
            this.gbFilter.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox4 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
