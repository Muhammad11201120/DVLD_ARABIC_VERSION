namespace DVLD_AR.Licenses.DetainLicense
{
    partial class frmDetainLicenseApplication
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
            this.ctrDriverLicenseInfoWithFilter1 = new DVLD_AR.Licenses.Controls.ctrDriverLicenseInfoWithFilter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCrreatedBy = new System.Windows.Forms.TextBox();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.txtDetainFees = new System.Windows.Forms.TextBox();
            this.txtDetainDate = new System.Windows.Forms.TextBox();
            this.txtDetainID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.lblShowNewLicense = new System.Windows.Forms.Label();
            this.lblShowPersonsLicensesHistory = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrDriverLicenseInfoWithFilter1
            // 
            this.ctrDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ctrDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrDriverLicenseInfoWithFilter1.ForeColor = System.Drawing.Color.White;
            this.ctrDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(11, 98);
            this.ctrDriverLicenseInfoWithFilter1.Name = "ctrDriverLicenseInfoWithFilter1";
            this.ctrDriverLicenseInfoWithFilter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1124, 603);
            this.ctrDriverLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rubik", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(491, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 47);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "حجز رخصة";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCrreatedBy);
            this.groupBox1.Controls.Add(this.txtLicenseID);
            this.groupBox1.Controls.Add(this.txtDetainFees);
            this.groupBox1.Controls.Add(this.txtDetainDate);
            this.groupBox1.Controls.Add(this.txtDetainID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 707);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1122, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الحجز : ";
            // 
            // txtCrreatedBy
            // 
            this.txtCrreatedBy.Location = new System.Drawing.Point(188, 96);
            this.txtCrreatedBy.Name = "txtCrreatedBy";
            this.txtCrreatedBy.Size = new System.Drawing.Size(254, 26);
            this.txtCrreatedBy.TabIndex = 9;
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.Location = new System.Drawing.Point(188, 46);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(254, 26);
            this.txtLicenseID.TabIndex = 8;
            // 
            // txtDetainFees
            // 
            this.txtDetainFees.Location = new System.Drawing.Point(686, 149);
            this.txtDetainFees.Name = "txtDetainFees";
            this.txtDetainFees.Size = new System.Drawing.Size(254, 26);
            this.txtDetainFees.TabIndex = 7;
            this.txtDetainFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtDetainFees_Validating);
            // 
            // txtDetainDate
            // 
            this.txtDetainDate.Location = new System.Drawing.Point(686, 96);
            this.txtDetainDate.Name = "txtDetainDate";
            this.txtDetainDate.Size = new System.Drawing.Size(254, 26);
            this.txtDetainDate.TabIndex = 6;
            // 
            // txtDetainID
            // 
            this.txtDetainID.Location = new System.Drawing.Point(686, 46);
            this.txtDetainID.Name = "txtDetainID";
            this.txtDetainID.Size = new System.Drawing.Size(254, 26);
            this.txtDetainID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "مدخل المعلومات :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "رقم الرخصة :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(993, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "رسوم فك الحجز :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(993, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخ الحجز :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(993, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الحجز :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnClose.Image = global::DVLD_AR.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1040, 921);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 44);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "إغلاق";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Enabled = false;
            this.btnDetain.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnDetain.Image = global::DVLD_AR.Properties.Resources.Detain_32;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetain.Location = new System.Drawing.Point(930, 921);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(91, 44);
            this.btnDetain.TabIndex = 4;
            this.btnDetain.Text = "حجز";
            this.btnDetain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // lblShowNewLicense
            // 
            this.lblShowNewLicense.AutoSize = true;
            this.lblShowNewLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowNewLicense.Enabled = false;
            this.lblShowNewLicense.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNewLicense.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblShowNewLicense.Location = new System.Drawing.Point(236, 933);
            this.lblShowNewLicense.Name = "lblShowNewLicense";
            this.lblShowNewLicense.Size = new System.Drawing.Size(297, 32);
            this.lblShowNewLicense.TabIndex = 8;
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
            this.lblShowPersonsLicensesHistory.Location = new System.Drawing.Point(8, 933);
            this.lblShowPersonsLicensesHistory.Name = "lblShowPersonsLicensesHistory";
            this.lblShowPersonsLicensesHistory.Size = new System.Drawing.Size(188, 32);
            this.lblShowPersonsLicensesHistory.TabIndex = 7;
            this.lblShowPersonsLicensesHistory.Text = "تاريخ رخص المتقدم";
            this.lblShowPersonsLicensesHistory.Click += new System.EventHandler(this.lblShowPersonsLicensesHistory_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1143, 993);
            this.Controls.Add(this.lblShowNewLicense);
            this.Controls.Add(this.lblShowPersonsLicensesHistory);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrDriverLicenseInfoWithFilter1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDetainLicenseApplication";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حجز رخصة";
            this.Activated += new System.EventHandler(this.frmDetainLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmDetainLicenseApplication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrDriverLicenseInfoWithFilter ctrDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCrreatedBy;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.TextBox txtDetainFees;
        private System.Windows.Forms.TextBox txtDetainDate;
        private System.Windows.Forms.TextBox txtDetainID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShowNewLicense;
        private System.Windows.Forms.Label lblShowPersonsLicensesHistory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}