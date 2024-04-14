namespace DVLD_AR.Applications.International_License
{
    partial class frmListAllInterNationalLicenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmListAllInterNationalLicenses ) );
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmApplications = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.معلوماتالمتقدمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.معلوماتالرخصةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.سجلالرخصةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).BeginInit();
            this.panel1.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridView1 ) ).BeginInit();
            this.cmApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Rubik", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label1.Location = new System.Drawing.Point( 526, 156 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 348, 45 );
            this.label1.TabIndex = 0;
            this.label1.Text = "قائمة جميع الرخص الدولية";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_AR.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point( 563, 13 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 272, 140 );
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_AR.Properties.Resources.International_32;
            this.pictureBox2.Location = new System.Drawing.Point( 591, 58 );
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size( 46, 43 );
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add( this.dataGridView1 );
            this.panel1.Location = new System.Drawing.Point( 12, 255 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 1376, 450 );
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font( "Rubik", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point( 0, 0 );
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font( "Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size( 1376, 450 );
            this.dataGridView1.TabIndex = 0;
            // 
            // cbFilters
            // 
            this.cbFilters.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange( new object[] {
            "لاشيء",
            "رقم الرخصة الدولية",
            "رقم الطلب",
            "رقم السائق",
            "رقم الرخصة المحلية",
            "حالة الرخصة"} );
            this.cbFilters.Location = new System.Drawing.Point( 67, 224 );
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size( 199, 28 );
            this.cbFilters.TabIndex = 4;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler( this.cbFilters_SelectedIndexChanged );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label2.Location = new System.Drawing.Point( 12, 228 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 49, 24 );
            this.label2.TabIndex = 5;
            this.label2.Text = "بحث :";
            // 
            // cbIsActive
            // 
            this.cbIsActive.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange( new object[] {
            "الكل",
            "نعم",
            "لا"} );
            this.cbIsActive.Location = new System.Drawing.Point( 272, 224 );
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size( 58, 28 );
            this.cbIsActive.TabIndex = 6;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler( this.cbIsActive_SelectedIndexChanged );
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.txtFilter.Location = new System.Drawing.Point( 272, 223 );
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size( 234, 26 );
            this.txtFilter.TabIndex = 7;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler( this.txtFilter_TextChanged );
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.txtFilter_KeyPress );
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label3.Location = new System.Drawing.Point( 12, 719 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 126, 24 );
            this.label3.TabIndex = 8;
            this.label3.Text = "# عدد السجلات :";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.lblRecords.Location = new System.Drawing.Point( 140, 719 );
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size( 20, 24 );
            this.lblRecords.TabIndex = 9;
            this.lblRecords.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnClose.Image = global::DVLD_AR.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point( 1283, 711 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 105, 44 );
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "إغلاق";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font( "Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.btnAdd.Image = global::DVLD_AR.Properties.Resources.New_Application_64;
            this.btnAdd.Location = new System.Drawing.Point( 1283, 177 );
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size( 105, 75 );
            this.btnAdd.TabIndex = 11;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler( this.btnAdd_Click );
            // 
            // cmApplications
            // 
            this.cmApplications.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.معلوماتالمتقدمToolStripMenuItem,
            this.toolStripSeparator1,
            this.معلوماتالرخصةToolStripMenuItem,
            this.toolStripSeparator2,
            this.سجلالرخصةToolStripMenuItem} );
            this.cmApplications.Name = "cmApplications";
            this.cmApplications.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmApplications.Size = new System.Drawing.Size( 188, 130 );
            // 
            // معلوماتالمتقدمToolStripMenuItem
            // 
            this.معلوماتالمتقدمToolStripMenuItem.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.معلوماتالمتقدمToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.PersonDetails_32;
            this.معلوماتالمتقدمToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.معلوماتالمتقدمToolStripMenuItem.Name = "معلوماتالمتقدمToolStripMenuItem";
            this.معلوماتالمتقدمToolStripMenuItem.Size = new System.Drawing.Size( 187, 38 );
            this.معلوماتالمتقدمToolStripMenuItem.Text = "معلومات المتقدم";
            this.معلوماتالمتقدمToolStripMenuItem.Click += new System.EventHandler( this.معلوماتالمتقدمToolStripMenuItem_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 184, 6 );
            // 
            // معلوماتالرخصةToolStripMenuItem
            // 
            this.معلوماتالرخصةToolStripMenuItem.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.معلوماتالرخصةToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.License_View_32;
            this.معلوماتالرخصةToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.معلوماتالرخصةToolStripMenuItem.Name = "معلوماتالرخصةToolStripMenuItem";
            this.معلوماتالرخصةToolStripMenuItem.Size = new System.Drawing.Size( 187, 38 );
            this.معلوماتالرخصةToolStripMenuItem.Text = "معلومات الرخصة";
            this.معلوماتالرخصةToolStripMenuItem.Click += new System.EventHandler( this.معلوماتالرخصةToolStripMenuItem_Click );
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size( 184, 6 );
            // 
            // سجلالرخصةToolStripMenuItem
            // 
            this.سجلالرخصةToolStripMenuItem.Font = new System.Drawing.Font( "Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.سجلالرخصةToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.PersonLicenseHistory_32;
            this.سجلالرخصةToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.سجلالرخصةToolStripMenuItem.Name = "سجلالرخصةToolStripMenuItem";
            this.سجلالرخصةToolStripMenuItem.Size = new System.Drawing.Size( 187, 38 );
            this.سجلالرخصةToolStripMenuItem.Text = "سجل الرخصة";
            this.سجلالرخصةToolStripMenuItem.Click += new System.EventHandler( this.سجلالرخصةToolStripMenuItem_Click );
            // 
            // frmListAllInterNationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ), ( ( int ) ( ( ( byte ) ( 34 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 1400, 767 );
            this.Controls.Add( this.btnAdd );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.lblRecords );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.txtFilter );
            this.Controls.Add( this.cbIsActive );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.cbFilters );
            this.Controls.Add( this.panel1 );
            this.Controls.Add( this.pictureBox2 );
            this.Controls.Add( this.pictureBox1 );
            this.Controls.Add( this.label1 );
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "frmListAllInterNationalLicenses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة جميع الرخص الدولية";
            this.Load += new System.EventHandler( this.frmListAllInterNationalLicenses_Load );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox1 ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.pictureBox2 ) ).EndInit();
            this.panel1.ResumeLayout( false );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridView1 ) ).EndInit();
            this.cmApplications.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip cmApplications;
        private System.Windows.Forms.ToolStripMenuItem معلوماتالمتقدمToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem معلوماتالرخصةToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem سجلالرخصةToolStripMenuItem;
    }
}