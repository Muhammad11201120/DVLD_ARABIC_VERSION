namespace DVLD_AR.Tests.TestTypes
{
    partial class frmEditTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmEditTestTypes ) );
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTestTypeID = new System.Windows.Forms.Label();
            this.txtTestTypeTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider( this.components );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Rubik", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label1.Location = new System.Drawing.Point( 184, 147 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 269, 42 );
            this.label1.TabIndex = 0;
            this.label1.Text = "تعديل أنواع الإختبارات";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_AR.Properties.Resources.Applications1;
            this.pictureBox1.Location = new System.Drawing.Point( 194, 12 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 249, 132 );
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label2.Location = new System.Drawing.Point( 12, 205 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 99, 24 );
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم المعرٌف : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label3.Location = new System.Drawing.Point( 12, 287 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 122, 24 );
            this.label3.TabIndex = 3;
            this.label3.Text = "إسم نوع الإختبار :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label4.Location = new System.Drawing.Point( 12, 369 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 136, 24 );
            this.label4.TabIndex = 4;
            this.label4.Text = "وصف نوع الإختبار : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label5.Location = new System.Drawing.Point( 12, 526 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 132, 24 );
            this.label5.TabIndex = 5;
            this.label5.Text = "رسوم نوع الإختبار : ";
            // 
            // lblTestTypeID
            // 
            this.lblTestTypeID.AutoSize = true;
            this.lblTestTypeID.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblTestTypeID.Location = new System.Drawing.Point( 161, 205 );
            this.lblTestTypeID.Name = "lblTestTypeID";
            this.lblTestTypeID.Size = new System.Drawing.Size( 26, 24 );
            this.lblTestTypeID.TabIndex = 6;
            this.lblTestTypeID.Text = "??";
            // 
            // txtTestTypeTitle
            // 
            this.txtTestTypeTitle.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.txtTestTypeTitle.Location = new System.Drawing.Point( 165, 290 );
            this.txtTestTypeTitle.Name = "txtTestTypeTitle";
            this.txtTestTypeTitle.Size = new System.Drawing.Size( 452, 23 );
            this.txtTestTypeTitle.TabIndex = 7;
            this.txtTestTypeTitle.Validating += new System.ComponentModel.CancelEventHandler( this.txtTestTypeTitle_Validating );
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.txtDescription.Location = new System.Drawing.Point( 165, 372 );
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size( 452, 128 );
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Text = "";
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler( this.txtDescription_Validating );
            // 
            // txtFees
            // 
            this.txtFees.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.txtFees.Location = new System.Drawing.Point( 165, 526 );
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size( 452, 23 );
            this.txtFees.TabIndex = 9;
            this.txtFees.Validating += new System.ComponentModel.CancelEventHandler( this.txtFees_Validating );
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnClose.Image = global::DVLD_AR.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point( 331, 620 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 99, 41 );
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "إغلاق";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnSave.Image = global::DVLD_AR.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point( 205, 619 );
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size( 99, 41 );
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler( this.btnSave_Click );
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEditTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 637, 684 );
            this.Controls.Add( this.btnSave );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.txtFees );
            this.Controls.Add( this.txtDescription );
            this.Controls.Add( this.txtTestTypeTitle );
            this.Controls.Add( this.lblTestTypeID );
            this.Controls.Add( this.label5 );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.pictureBox1 );
            this.Controls.Add( this.label1 );
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "frmEditTestTypes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تعديل أنواع الإختبارات";
            this.Load += new System.EventHandler( this.frmEditTestTypes_Load );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.errorProvider1 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTestTypeID;
        private System.Windows.Forms.TextBox txtTestTypeTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}