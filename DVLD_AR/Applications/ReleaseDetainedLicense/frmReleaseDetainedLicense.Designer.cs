namespace DVLD_AR.Applications.ReleaseDetainedLicense
{
    partial class frmReleaseDetainedLicense
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
            this.ctrDriverLicenseInfoWithFilter1 = new DVLD_AR.Licenses.Controls.ctrDriverLicenseInfoWithFilter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReleaseAppID = new System.Windows.Forms.TextBox();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.txtTottalFees = new System.Windows.Forms.TextBox();
            this.txtReleaseAppFees = new System.Windows.Forms.TextBox();
            this.txtDetainDate = new System.Windows.Forms.TextBox();
            this.txtDetainID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShowNewLicense = new System.Windows.Forms.Label();
            this.lblShowPersonsLicensesHistory = new System.Windows.Forms.Label();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrDriverLicenseInfoWithFilter1
            // 
            this.ctrDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ctrDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrDriverLicenseInfoWithFilter1.ForeColor = System.Drawing.Color.White;
            this.ctrDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 84);
            this.ctrDriverLicenseInfoWithFilter1.Name = "ctrDriverLicenseInfoWithFilter1";
            this.ctrDriverLicenseInfoWithFilter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1124, 603);
            this.ctrDriverLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "فك الحجز عن رخصة";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReleaseAppID);
            this.groupBox1.Controls.Add(this.txtFineFees);
            this.groupBox1.Controls.Add(this.txtCreatedBy);
            this.groupBox1.Controls.Add(this.txtLicenseID);
            this.groupBox1.Controls.Add(this.txtTottalFees);
            this.groupBox1.Controls.Add(this.txtReleaseAppFees);
            this.groupBox1.Controls.Add(this.txtDetainDate);
            this.groupBox1.Controls.Add(this.txtDetainID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 693);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات فك الحجز عن الرخصة : ";
            // 
            // txtReleaseAppID
            // 
            this.txtReleaseAppID.Location = new System.Drawing.Point(62, 160);
            this.txtReleaseAppID.Name = "txtReleaseAppID";
            this.txtReleaseAppID.Size = new System.Drawing.Size(318, 26);
            this.txtReleaseAppID.TabIndex = 18;
            // 
            // txtFineFees
            // 
            this.txtFineFees.Location = new System.Drawing.Point(62, 120);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(318, 26);
            this.txtFineFees.TabIndex = 17;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(62, 80);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(318, 26);
            this.txtCreatedBy.TabIndex = 16;
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.Location = new System.Drawing.Point(62, 40);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(318, 26);
            this.txtLicenseID.TabIndex = 15;
            // 
            // txtTottalFees
            // 
            this.txtTottalFees.Location = new System.Drawing.Point(598, 160);
            this.txtTottalFees.Name = "txtTottalFees";
            this.txtTottalFees.Size = new System.Drawing.Size(318, 26);
            this.txtTottalFees.TabIndex = 14;
            // 
            // txtReleaseAppFees
            // 
            this.txtReleaseAppFees.Location = new System.Drawing.Point(598, 120);
            this.txtReleaseAppFees.Name = "txtReleaseAppFees";
            this.txtReleaseAppFees.Size = new System.Drawing.Size(318, 26);
            this.txtReleaseAppFees.TabIndex = 13;
            // 
            // txtDetainDate
            // 
            this.txtDetainDate.Location = new System.Drawing.Point(598, 81);
            this.txtDetainDate.Name = "txtDetainDate";
            this.txtDetainDate.Size = new System.Drawing.Size(318, 26);
            this.txtDetainDate.TabIndex = 12;
            // 
            // txtDetainID
            // 
            this.txtDetainID.Location = new System.Drawing.Point(598, 40);
            this.txtDetainID.Name = "txtDetainID";
            this.txtDetainID.Size = new System.Drawing.Size(318, 26);
            this.txtDetainID.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(433, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "رقم طلب فك الحجز :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "مدخل المعلومات :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "رقم الرخصة :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "رسوم الحجز :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(960, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "مجموع الرسوم :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(960, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "رسوم طلب فك الحجز :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(960, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاريخ الحجز :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(960, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "رقم الحجز :";
            // 
            // lblShowNewLicense
            // 
            this.lblShowNewLicense.AutoSize = true;
            this.lblShowNewLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowNewLicense.Enabled = false;
            this.lblShowNewLicense.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNewLicense.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblShowNewLicense.Location = new System.Drawing.Point(16, 925);
            this.lblShowNewLicense.Name = "lblShowNewLicense";
            this.lblShowNewLicense.Size = new System.Drawing.Size(297, 32);
            this.lblShowNewLicense.TabIndex = 22;
            this.lblShowNewLicense.Text = "إظهار معلومات الرخصة الجديدة";
            this.lblShowNewLicense.Click += new System.EventHandler(this.lblShowNewLicense_Click);
            // 
            // lblShowPersonsLicensesHistory
            // 
            this.lblShowPersonsLicensesHistory.AutoSize = true;
            this.lblShowPersonsLicensesHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowPersonsLicensesHistory.Enabled = false;
            this.lblShowPersonsLicensesHistory.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPersonsLicensesHistory.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblShowPersonsLicensesHistory.Location = new System.Drawing.Point(340, 925);
            this.lblShowPersonsLicensesHistory.Name = "lblShowPersonsLicensesHistory";
            this.lblShowPersonsLicensesHistory.Size = new System.Drawing.Size(188, 32);
            this.lblShowPersonsLicensesHistory.TabIndex = 21;
            this.lblShowPersonsLicensesHistory.Text = "تاريخ رخص المتقدم";
            this.lblShowPersonsLicensesHistory.Click += new System.EventHandler(this.lblShowPersonsLicensesHistory_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelease.Enabled = false;
            this.btnRelease.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.ForeColor = System.Drawing.Color.Green;
            this.btnRelease.Image = global::DVLD_AR.Properties.Resources.Renew_Driving_License_32;
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelease.Location = new System.Drawing.Point(859, 911);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(128, 48);
            this.btnRelease.TabIndex = 20;
            this.btnRelease.Text = "فك الحجز";
            this.btnRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnClose.Image = global::DVLD_AR.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1008, 911);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 48);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "إغلاق";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1148, 981);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.lblShowPersonsLicensesHistory);
            this.Controls.Add(this.lblShowNewLicense);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrDriverLicenseInfoWithFilter1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReleaseDetainedLicense";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فك الحجز عن رخصة";
            this.Activated += new System.EventHandler(this.frmReleaseDetainedLicense_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Controls.ctrDriverLicenseInfoWithFilter ctrDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReleaseAppID;
        private System.Windows.Forms.TextBox txtFineFees;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.TextBox txtTottalFees;
        private System.Windows.Forms.TextBox txtReleaseAppFees;
        private System.Windows.Forms.TextBox txtDetainDate;
        private System.Windows.Forms.TextBox txtDetainID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblShowNewLicense;
        private System.Windows.Forms.Label lblShowPersonsLicensesHistory;
        private System.Windows.Forms.Button btnRelease;
    }
}