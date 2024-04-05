namespace DVLD_AR.Applications.Replace_Lost_Or_Damaged_License
{
    partial class frmReplacementForDamagedOrLostLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacementForDamagedOrLostLicense));
            this.lblTilte = new System.Windows.Forms.Label();
            this.ctrDriverLicenseInfoWithFilter1 = new DVLD_AR.Licenses.Controls.ctrDriverLicenseInfoWithFilter();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCreatedByName = new System.Windows.Forms.TextBox();
            this.txtPldLicenseID = new System.Windows.Forms.TextBox();
            this.txtNewLicenseID = new System.Windows.Forms.TextBox();
            this.txtAppFees = new System.Windows.Forms.TextBox();
            this.txtReplacementAppID = new System.Windows.Forms.TextBox();
            this.txtAppDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShowNewLicense = new System.Windows.Forms.Label();
            this.lblShowPersonsLicensesHistory = new System.Windows.Forms.Label();
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbReplacementFor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTilte
            // 
            this.lblTilte.AutoSize = true;
            this.lblTilte.Font = new System.Drawing.Font("Rubik", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilte.Location = new System.Drawing.Point(326, 9);
            this.lblTilte.Name = "lblTilte";
            this.lblTilte.Size = new System.Drawing.Size(491, 53);
            this.lblTilte.TabIndex = 0;
            this.lblTilte.Text = "إصدار بدل رخصة ( فاقد - تالف )";
            // 
            // ctrDriverLicenseInfoWithFilter1
            // 
            this.ctrDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ctrDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrDriverLicenseInfoWithFilter1.ForeColor = System.Drawing.Color.White;
            this.ctrDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(9, 181);
            this.ctrDriverLicenseInfoWithFilter1.Name = "ctrDriverLicenseInfoWithFilter1";
            this.ctrDriverLicenseInfoWithFilter1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(1124, 603);
            this.ctrDriverLicenseInfoWithFilter1.TabIndex = 1;
            this.ctrDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplacementFor.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReplacementFor.ForeColor = System.Drawing.Color.White;
            this.gbReplacementFor.Location = new System.Drawing.Point(12, 75);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(1118, 100);
            this.gbReplacementFor.TabIndex = 2;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "سبب الإصدار  :";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLostLicense.Location = new System.Drawing.Point(380, 40);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(113, 36);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.Text = "بدل فاقد";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Checked = true;
            this.rbDamagedLicense.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDamagedLicense.Location = new System.Drawing.Point(625, 40);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(114, 36);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "بدل تالف";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCreatedByName);
            this.groupBox2.Controls.Add(this.txtPldLicenseID);
            this.groupBox2.Controls.Add(this.txtNewLicenseID);
            this.groupBox2.Controls.Add(this.txtAppFees);
            this.groupBox2.Controls.Add(this.txtReplacementAppID);
            this.groupBox2.Controls.Add(this.txtAppDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 790);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1118, 195);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات سبب إصدار البدل : ";
            // 
            // txtCreatedByName
            // 
            this.txtCreatedByName.Location = new System.Drawing.Point(6, 89);
            this.txtCreatedByName.Name = "txtCreatedByName";
            this.txtCreatedByName.Size = new System.Drawing.Size(417, 26);
            this.txtCreatedByName.TabIndex = 12;
            // 
            // txtPldLicenseID
            // 
            this.txtPldLicenseID.Location = new System.Drawing.Point(6, 35);
            this.txtPldLicenseID.Name = "txtPldLicenseID";
            this.txtPldLicenseID.Size = new System.Drawing.Size(417, 26);
            this.txtPldLicenseID.TabIndex = 11;
            // 
            // txtNewLicenseID
            // 
            this.txtNewLicenseID.Location = new System.Drawing.Point(584, 142);
            this.txtNewLicenseID.Name = "txtNewLicenseID";
            this.txtNewLicenseID.Size = new System.Drawing.Size(362, 26);
            this.txtNewLicenseID.TabIndex = 10;
            // 
            // txtAppFees
            // 
            this.txtAppFees.Location = new System.Drawing.Point(6, 141);
            this.txtAppFees.Name = "txtAppFees";
            this.txtAppFees.Size = new System.Drawing.Size(417, 26);
            this.txtAppFees.TabIndex = 9;
            // 
            // txtReplacementAppID
            // 
            this.txtReplacementAppID.Location = new System.Drawing.Point(584, 35);
            this.txtReplacementAppID.Name = "txtReplacementAppID";
            this.txtReplacementAppID.Size = new System.Drawing.Size(362, 26);
            this.txtReplacementAppID.TabIndex = 8;
            // 
            // txtAppDate
            // 
            this.txtAppDate.Location = new System.Drawing.Point(584, 89);
            this.txtAppDate.Name = "txtAppDate";
            this.txtAppDate.Size = new System.Drawing.Size(362, 26);
            this.txtAppDate.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "مدخل المعلومات :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "رقم الرخصة القديمة :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(952, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "رقم الرخصة الجديدة :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "رسوم الطلب :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(952, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "تاريخ الطلب  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(952, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "رقم طلب إصدار البدل :";
            // 
            // lblShowNewLicense
            // 
            this.lblShowNewLicense.AutoSize = true;
            this.lblShowNewLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowNewLicense.Enabled = false;
            this.lblShowNewLicense.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowNewLicense.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblShowNewLicense.Location = new System.Drawing.Point(227, 998);
            this.lblShowNewLicense.Name = "lblShowNewLicense";
            this.lblShowNewLicense.Size = new System.Drawing.Size(297, 32);
            this.lblShowNewLicense.TabIndex = 10;
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
            this.lblShowPersonsLicensesHistory.Location = new System.Drawing.Point(6, 998);
            this.lblShowPersonsLicensesHistory.Name = "lblShowPersonsLicensesHistory";
            this.lblShowPersonsLicensesHistory.Size = new System.Drawing.Size(188, 32);
            this.lblShowPersonsLicensesHistory.TabIndex = 9;
            this.lblShowPersonsLicensesHistory.Text = "تاريخ رخص المتقدم";
            this.lblShowPersonsLicensesHistory.Click += new System.EventHandler(this.lblShowPersonsLicensesHistory_Click);
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueReplacement.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReplacement.ForeColor = System.Drawing.Color.Green;
            this.btnIssueReplacement.Image = global::DVLD_AR.Properties.Resources.Renew_Driving_License_32;
            this.btnIssueReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssueReplacement.Location = new System.Drawing.Point(839, 991);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(128, 48);
            this.btnIssueReplacement.TabIndex = 8;
            this.btnIssueReplacement.Text = "إصدار البدل";
            this.btnIssueReplacement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueReplacement.UseVisualStyleBackColor = true;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnClose.Image = global::DVLD_AR.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1002, 991);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 48);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "إغلاق";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReplacementForDamagedOrLostLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1142, 1051);
            this.Controls.Add(this.lblShowNewLicense);
            this.Controls.Add(this.lblShowPersonsLicensesHistory);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.ctrDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.lblTilte);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReplacementForDamagedOrLostLicense";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إصدار رخصة بدل فاقد أو بدل تالف";
            this.Activated += new System.EventHandler(this.frmReplacementForDamagedOrLostLicense_Activated);
            this.Load += new System.EventHandler(this.frmReplacementForDamagedOrLostLicense_Load);
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTilte;
        private Licenses.Controls.ctrDriverLicenseInfoWithFilter ctrDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblShowNewLicense;
        private System.Windows.Forms.Label lblShowPersonsLicensesHistory;
        private System.Windows.Forms.Button btnIssueReplacement;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private System.Windows.Forms.TextBox txtCreatedByName;
        private System.Windows.Forms.TextBox txtPldLicenseID;
        private System.Windows.Forms.TextBox txtNewLicenseID;
        private System.Windows.Forms.TextBox txtAppFees;
        private System.Windows.Forms.TextBox txtReplacementAppID;
        private System.Windows.Forms.TextBox txtAppDate;
    }
}