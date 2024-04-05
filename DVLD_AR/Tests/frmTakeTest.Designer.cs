namespace DVLD_AR.Tests
{
    partial class frmTakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmTakeTest ) );
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnPass = new System.Windows.Forms.RadioButton();
            this.rbtnFail = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.ctrScehduledTest1 = new DVLD_AR.Tests.Controls.ctrScehduledTest();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label1.Location = new System.Drawing.Point( 12, 699 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 67, 24 );
            this.label1.TabIndex = 1;
            this.label1.Text = "النتيجة : ";
            // 
            // rbtnPass
            // 
            this.rbtnPass.AutoSize = true;
            this.rbtnPass.Checked = true;
            this.rbtnPass.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rbtnPass.Location = new System.Drawing.Point( 106, 697 );
            this.rbtnPass.Name = "rbtnPass";
            this.rbtnPass.Size = new System.Drawing.Size( 59, 28 );
            this.rbtnPass.TabIndex = 2;
            this.rbtnPass.TabStop = true;
            this.rbtnPass.Text = "اجتاز";
            this.rbtnPass.UseVisualStyleBackColor = true;
            // 
            // rbtnFail
            // 
            this.rbtnFail.AutoSize = true;
            this.rbtnFail.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.rbtnFail.Location = new System.Drawing.Point( 198, 697 );
            this.rbtnFail.Name = "rbtnFail";
            this.rbtnFail.Size = new System.Drawing.Size( 79, 28 );
            this.rbtnFail.TabIndex = 3;
            this.rbtnFail.Text = "لم يجتاز";
            this.rbtnFail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label2.Location = new System.Drawing.Point( 12, 748 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 84, 24 );
            this.label2.TabIndex = 4;
            this.label2.Text = "ملاحظات : ";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point( 16, 778 );
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size( 548, 96 );
            this.txtNotes.TabIndex = 5;
            this.txtNotes.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnClose.Image = global::DVLD_AR.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point( 473, 894 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 92, 35 );
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "إغلاق";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnSave.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "btnSave.Image" ) ) );
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point( 359, 894 );
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size( 92, 35 );
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler( this.btnSave_Click );
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.button2.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.button2.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "button2.Image" ) ) );
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point( 359, 894 );
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size( 92, 35 );
            this.button2.TabIndex = 7;
            this.button2.Text = "حفظ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblUserMessage.ForeColor = System.Drawing.Color.IndianRed;
            this.lblUserMessage.Location = new System.Drawing.Point( 296, 699 );
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size( 254, 24 );
            this.lblUserMessage.TabIndex = 8;
            this.lblUserMessage.Text = "لايمكن التعديل على نتيجة هذا الإختبار";
            this.lblUserMessage.Visible = false;
            // 
            // ctrScehduledTest1
            // 
            this.ctrScehduledTest1.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.ctrScehduledTest1.ForeColor = System.Drawing.Color.White;
            this.ctrScehduledTest1.Location = new System.Drawing.Point( 11, 12 );
            this.ctrScehduledTest1.Name = "ctrScehduledTest1";
            this.ctrScehduledTest1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrScehduledTest1.Size = new System.Drawing.Size( 554, 665 );
            this.ctrScehduledTest1.TabIndex = 0;
            this.ctrScehduledTest1.TestTypeID = DVLD_Buisness.clsTestType.enTestType.VisionTest;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 576, 941 );
            this.Controls.Add( this.lblUserMessage );
            this.Controls.Add( this.btnSave );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.txtNotes );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.rbtnFail );
            this.Controls.Add( this.rbtnPass );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.ctrScehduledTest1 );
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "frmTakeTest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إجراء الإختبار";
            this.Load += new System.EventHandler( this.frmTakeTest_Load );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrScehduledTest ctrScehduledTest1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnPass;
        private System.Windows.Forms.RadioButton rbtnFail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblUserMessage;
    }
}