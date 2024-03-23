namespace DVLD_AR.People
{
    partial class frmListAllPeople
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تفاصيلمعلوماتالشخصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.إظافةشخصجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالشخصمنالنظامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.إرسالبريدالكترونيToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إجراءإتصالهاتفيToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFilters = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "جميع الإشخاص في النظام";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 426);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1546, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تفاصيلمعلوماتالشخصToolStripMenuItem,
            this.toolStripSeparator1,
            this.إظافةشخصجديدToolStripMenuItem,
            this.تعديلToolStripMenuItem,
            this.حذفالشخصمنالنظامToolStripMenuItem,
            this.toolStripSeparator2,
            this.إرسالبريدالكترونيToolStripMenuItem,
            this.إجراءإتصالهاتفيToolStripMenuItem,
            this.toolStripSeparator3,
            this.خروجToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 310);
            // 
            // تفاصيلمعلوماتالشخصToolStripMenuItem
            // 
            this.تفاصيلمعلوماتالشخصToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.PersonDetails_32;
            this.تفاصيلمعلوماتالشخصToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.تفاصيلمعلوماتالشخصToolStripMenuItem.Name = "تفاصيلمعلوماتالشخصToolStripMenuItem";
            this.تفاصيلمعلوماتالشخصToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.تفاصيلمعلوماتالشخصToolStripMenuItem.Text = "تفاصيل معلومات الشخص";
            this.تفاصيلمعلوماتالشخصToolStripMenuItem.Click += new System.EventHandler(this.تفاصيلمعلوماتالشخصToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // إظافةشخصجديدToolStripMenuItem
            // 
            this.إظافةشخصجديدToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.AddPerson_32;
            this.إظافةشخصجديدToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.إظافةشخصجديدToolStripMenuItem.Name = "إظافةشخصجديدToolStripMenuItem";
            this.إظافةشخصجديدToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.إظافةشخصجديدToolStripMenuItem.Text = "إظافة شخص جديد";
            this.إظافةشخصجديدToolStripMenuItem.Click += new System.EventHandler(this.إظافةشخصجديدToolStripMenuItem_Click);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.edit_32;
            this.تعديلToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.تعديلToolStripMenuItem.Text = "تعديل بيانات الشخص";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفالشخصمنالنظامToolStripMenuItem
            // 
            this.حذفالشخصمنالنظامToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.Delete_32;
            this.حذفالشخصمنالنظامToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.حذفالشخصمنالنظامToolStripMenuItem.Name = "حذفالشخصمنالنظامToolStripMenuItem";
            this.حذفالشخصمنالنظامToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.حذفالشخصمنالنظامToolStripMenuItem.Text = "حذف الشخص من النظام";
            this.حذفالشخصمنالنظامToolStripMenuItem.Click += new System.EventHandler(this.حذفالشخصمنالنظامToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // إرسالبريدالكترونيToolStripMenuItem
            // 
            this.إرسالبريدالكترونيToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.send_email_32;
            this.إرسالبريدالكترونيToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.إرسالبريدالكترونيToolStripMenuItem.Name = "إرسالبريدالكترونيToolStripMenuItem";
            this.إرسالبريدالكترونيToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.إرسالبريدالكترونيToolStripMenuItem.Text = "إرسال بريد الكتروني";
            // 
            // إجراءإتصالهاتفيToolStripMenuItem
            // 
            this.إجراءإتصالهاتفيToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.call_32;
            this.إجراءإتصالهاتفيToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.إجراءإتصالهاتفيToolStripMenuItem.Name = "إجراءإتصالهاتفيToolStripMenuItem";
            this.إجراءإتصالهاتفيToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.إجراءإتصالهاتفيToolStripMenuItem.Text = "إجراء إتصال هاتفي";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.Image = global::DVLD_AR.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(737, 764);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "إغلاق";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::DVLD_AR.Properties.Resources.Add_Person_40;
            this.btnAddPerson.Location = new System.Drawing.Point(1448, 277);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(112, 44);
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_AR.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(670, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "البحث بواسطة : ";
            // 
            // cbxFilters
            // 
            this.cbxFilters.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilters.FormattingEnabled = true;
            this.cbxFilters.Items.AddRange(new object[] {
            "الأب",
            "الإسم",
            "الإيميل",
            "الجد",
            "الجنس",
            "الجنسية",
            "العائلة",
            "المعرٌف",
            "الهاتف",
            "الهوية"});
            this.cbxFilters.Location = new System.Drawing.Point(136, 294);
            this.cbxFilters.Name = "cbxFilters";
            this.cbxFilters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxFilters.Size = new System.Drawing.Size(263, 28);
            this.cbxFilters.Sorted = true;
            this.cbxFilters.TabIndex = 6;
            this.cbxFilters.SelectedIndexChanged += new System.EventHandler(this.cbxFilters_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(405, 296);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(311, 26);
            this.txtFilter.TabIndex = 7;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(231, 6);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Image = global::DVLD_AR.Properties.Resources.sign_out_32__2;
            this.خروجToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(234, 38);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // frmListAllPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1572, 820);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbxFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmListAllPeople";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "قائمة بجميع الأسماء";
            this.Load += new System.EventHandler(this.frmListAllPeople_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تفاصيلمعلوماتالشخصToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem إظافةشخصجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفالشخصمنالنظامToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem إرسالبريدالكترونيToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إجراءإتصالهاتفيToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFilters;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
    }
}