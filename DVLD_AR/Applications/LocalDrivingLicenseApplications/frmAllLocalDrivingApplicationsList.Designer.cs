namespace DVLD_AR.Applications.LocalDrivingLicenseApplications
{
    partial class frmAllLocalDrivingApplicationsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllLocalDrivingApplicationsList));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.إظهارمعلوماتالToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.تعديلالطلبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالطلبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.إالغاءالطلبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.جدولةالإختباراتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إختبارالنظرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.الإختبارالكتابيToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.إختبارالميدانالعمليToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.إصدارالرخصةأولمرةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.إظهارالرخصةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.تاريخرخصالمستفيدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.cbxFilters = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewLocalLicenseApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(649, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "طلبات الرخص المحلية";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1593, 478);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1593, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إظهارمعلوماتالToolStripMenuItem,
            this.toolStripSeparator1,
            this.تعديلالطلبToolStripMenuItem,
            this.حذفالطلبToolStripMenuItem,
            this.toolStripSeparator2,
            this.إالغاءالطلبToolStripMenuItem,
            this.toolStripSeparator3,
            this.جدولةالإختباراتToolStripMenuItem,
            this.toolStripSeparator4,
            this.إصدارالرخصةأولمرةToolStripMenuItem,
            this.toolStripSeparator5,
            this.إظهارالرخصةToolStripMenuItem,
            this.toolStripSeparator6,
            this.تاريخرخصالمستفيدToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 344);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // إظهارمعلوماتالToolStripMenuItem
            // 
            this.إظهارمعلوماتالToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.PersonDetails_322;
            this.إظهارمعلوماتالToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.إظهارمعلوماتالToolStripMenuItem.Name = "إظهارمعلوماتالToolStripMenuItem";
            this.إظهارمعلوماتالToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.إظهارمعلوماتالToolStripMenuItem.Text = "إظهار معلومات الطلب";
            this.إظهارمعلوماتالToolStripMenuItem.Click += new System.EventHandler(this.إظهارمعلوماتالToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // تعديلالطلبToolStripMenuItem
            // 
            this.تعديلالطلبToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.edit_32;
            this.تعديلالطلبToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.تعديلالطلبToolStripMenuItem.Name = "تعديلالطلبToolStripMenuItem";
            this.تعديلالطلبToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.تعديلالطلبToolStripMenuItem.Text = "تعديل الطلب";
            this.تعديلالطلبToolStripMenuItem.Click += new System.EventHandler(this.تعديلالطلبToolStripMenuItem_Click);
            // 
            // حذفالطلبToolStripMenuItem
            // 
            this.حذفالطلبToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.Delete_32_2;
            this.حذفالطلبToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.حذفالطلبToolStripMenuItem.Name = "حذفالطلبToolStripMenuItem";
            this.حذفالطلبToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.حذفالطلبToolStripMenuItem.Text = "حذف الطلب";
            this.حذفالطلبToolStripMenuItem.Click += new System.EventHandler(this.حذفالطلبToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // إالغاءالطلبToolStripMenuItem
            // 
            this.إالغاءالطلبToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.Delete_321;
            this.إالغاءالطلبToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.إالغاءالطلبToolStripMenuItem.Name = "إالغاءالطلبToolStripMenuItem";
            this.إالغاءالطلبToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.إالغاءالطلبToolStripMenuItem.Text = "إالغاء الطلب";
            this.إالغاءالطلبToolStripMenuItem.Click += new System.EventHandler(this.إالغاءالطلبToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(222, 6);
            // 
            // جدولةالإختباراتToolStripMenuItem
            // 
            this.جدولةالإختباراتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إختبارالنظرToolStripMenuItem,
            this.toolStripSeparator7,
            this.الإختبارالكتابيToolStripMenuItem,
            this.toolStripSeparator8,
            this.إختبارالميدانالعمليToolStripMenuItem});
            this.جدولةالإختباراتToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.TestType_321;
            this.جدولةالإختباراتToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.جدولةالإختباراتToolStripMenuItem.Name = "جدولةالإختباراتToolStripMenuItem";
            this.جدولةالإختباراتToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.جدولةالإختباراتToolStripMenuItem.Text = "جدولة الإختبارات";
            // 
            // إختبارالنظرToolStripMenuItem
            // 
            this.إختبارالنظرToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.Vision_Test_32;
            this.إختبارالنظرToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.إختبارالنظرToolStripMenuItem.Name = "إختبارالنظرToolStripMenuItem";
            this.إختبارالنظرToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.إختبارالنظرToolStripMenuItem.Text = "إختبار النظر";
            this.إختبارالنظرToolStripMenuItem.Click += new System.EventHandler(this.إختبارالنظرToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(221, 6);
            // 
            // الإختبارالكتابيToolStripMenuItem
            // 
            this.الإختبارالكتابيToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.Written_Test_32;
            this.الإختبارالكتابيToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.الإختبارالكتابيToolStripMenuItem.Name = "الإختبارالكتابيToolStripMenuItem";
            this.الإختبارالكتابيToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.الإختبارالكتابيToolStripMenuItem.Text = "الإختبار الكتابي ( النظري )";
            this.الإختبارالكتابيToolStripMenuItem.Click += new System.EventHandler(this.الإختبارالكتابيToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // إختبارالميدانالعمليToolStripMenuItem
            // 
            this.إختبارالميدانالعمليToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.Street_Test_321;
            this.إختبارالميدانالعمليToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.إختبارالميدانالعمليToolStripMenuItem.Name = "إختبارالميدانالعمليToolStripMenuItem";
            this.إختبارالميدانالعمليToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.إختبارالميدانالعمليToolStripMenuItem.Text = "إختبار الميدان ( العملي )";
            this.إختبارالميدانالعمليToolStripMenuItem.Click += new System.EventHandler(this.إختبارالميدانالعمليToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(222, 6);
            // 
            // إصدارالرخصةأولمرةToolStripMenuItem
            // 
            this.إصدارالرخصةأولمرةToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.IssueDrivingLicense_32;
            this.إصدارالرخصةأولمرةToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.إصدارالرخصةأولمرةToolStripMenuItem.Name = "إصدارالرخصةأولمرةToolStripMenuItem";
            this.إصدارالرخصةأولمرةToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.إصدارالرخصةأولمرةToolStripMenuItem.Text = "إصدار الرخصة ( أول مرٌة )";
            this.إصدارالرخصةأولمرةToolStripMenuItem.Click += new System.EventHandler(this.إصدارالرخصةأولمرةToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(222, 6);
            // 
            // إظهارالرخصةToolStripMenuItem
            // 
            this.إظهارالرخصةToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.License_View_32;
            this.إظهارالرخصةToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.إظهارالرخصةToolStripMenuItem.Name = "إظهارالرخصةToolStripMenuItem";
            this.إظهارالرخصةToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.إظهارالرخصةToolStripMenuItem.Text = "إظهار الرخصة";
            this.إظهارالرخصةToolStripMenuItem.Click += new System.EventHandler(this.إظهارالرخصةToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(222, 6);
            // 
            // تاريخرخصالمستفيدToolStripMenuItem
            // 
            this.تاريخرخصالمستفيدToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.PersonLicenseHistory_32;
            this.تاريخرخصالمستفيدToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.تاريخرخصالمستفيدToolStripMenuItem.Name = "تاريخرخصالمستفيدToolStripMenuItem";
            this.تاريخرخصالمستفيدToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.تاريخرخصالمستفيدToolStripMenuItem.Text = "تاريخ رخص المستفيد";
            this.تاريخرخصالمستفيدToolStripMenuItem.Click += new System.EventHandler(this.تاريخرخصالمستفيدToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 837);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = " # عدد السجلات : ";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(152, 837);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(34, 24);
            this.lblRecords.TabIndex = 4;
            this.lblRecords.Text = "???";
            // 
            // cbxFilters
            // 
            this.cbxFilters.Font = new System.Drawing.Font("Arial Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilters.FormattingEnabled = true;
            this.cbxFilters.Items.AddRange(new object[] {
            "لاشئ",
            "المعرٌف",
            "الهويٌة",
            "الإسم",
            "الحالة"});
            this.cbxFilters.Location = new System.Drawing.Point(82, 308);
            this.cbxFilters.Name = "cbxFilters";
            this.cbxFilters.Size = new System.Drawing.Size(276, 28);
            this.cbxFilters.TabIndex = 5;
            this.cbxFilters.SelectedIndexChanged += new System.EventHandler(this.cbxFilters_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(364, 311);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(322, 26);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "البحث : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_AR.Properties.Resources.Local_32;
            this.pictureBox2.Location = new System.Drawing.Point(701, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnClose.Image = global::DVLD_AR.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(1496, 837);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 39);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "إغلاق";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewLocalLicenseApplication
            // 
            this.btnAddNewLocalLicenseApplication.Image = global::DVLD_AR.Properties.Resources.New_Application_64;
            this.btnAddNewLocalLicenseApplication.Location = new System.Drawing.Point(1496, 256);
            this.btnAddNewLocalLicenseApplication.Name = "btnAddNewLocalLicenseApplication";
            this.btnAddNewLocalLicenseApplication.Size = new System.Drawing.Size(109, 82);
            this.btnAddNewLocalLicenseApplication.TabIndex = 8;
            this.btnAddNewLocalLicenseApplication.UseVisualStyleBackColor = true;
            this.btnAddNewLocalLicenseApplication.Click += new System.EventHandler(this.btnAddNewLocalLicenseApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_AR.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(677, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmAllLocalDrivingApplicationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1617, 888);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewLocalLicenseApplication);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbxFilters);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAllLocalDrivingApplicationsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة طلبات الرخص المحلية";
            this.Load += new System.EventHandler(this.frmAllLocalDrivingApplicationsList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.ComboBox cbxFilters;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNewLocalLicenseApplication;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem إظهارمعلوماتالToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem تعديلالطلبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالطلبToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem إالغاءالطلبToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem جدولةالإختباراتToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem إصدارالرخصةأولمرةToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem إظهارالرخصةToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem تاريخرخصالمستفيدToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem إختبارالنظرToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem الإختبارالكتابيToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem إختبارالميدانالعمليToolStripMenuItem;
    }
}