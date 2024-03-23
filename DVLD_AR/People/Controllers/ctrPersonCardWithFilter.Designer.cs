namespace DVLD_AR.People.Controllers
{
    partial class ctrPersonCardWithFilter
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
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnSearchForPerson = new System.Windows.Forms.Button();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrPersonCard1 = new DVLD_AR.People.Controllers.ctrPersonCard();
            this.gbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.btnAddPerson);
            this.gbxFilter.Controls.Add(this.btnSearchForPerson);
            this.gbxFilter.Controls.Add(this.txtFilterValue);
            this.gbxFilter.Controls.Add(this.cbFilterBy);
            this.gbxFilter.Controls.Add(this.label1);
            this.gbxFilter.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFilter.ForeColor = System.Drawing.Color.White;
            this.gbxFilter.Location = new System.Drawing.Point(3, 3);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxFilter.Size = new System.Drawing.Size(1179, 106);
            this.gbxFilter.TabIndex = 0;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "البحث";
            this.gbxFilter.Enter += new System.EventHandler(this.gbxFilter_Enter);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::DVLD_AR.Properties.Resources.AddPerson_32;
            this.btnAddPerson.Location = new System.Drawing.Point(83, 45);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 38);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnSearchForPerson
            // 
            this.btnSearchForPerson.Image = global::DVLD_AR.Properties.Resources.SearchPerson;
            this.btnSearchForPerson.Location = new System.Drawing.Point(175, 45);
            this.btnSearchForPerson.Name = "btnSearchForPerson";
            this.btnSearchForPerson.Size = new System.Drawing.Size(75, 38);
            this.btnSearchForPerson.TabIndex = 3;
            this.btnSearchForPerson.UseVisualStyleBackColor = true;
            this.btnSearchForPerson.Click += new System.EventHandler(this.btnSearchForPerson_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtFilterValue.Location = new System.Drawing.Point(313, 48);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(391, 30);
            this.txtFilterValue.TabIndex = 2;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Font = new System.Drawing.Font("Arial Nova Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "المعرٌف",
            "الهوية"});
            this.cbFilterBy.Location = new System.Drawing.Point(710, 47);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(354, 31);
            this.cbFilterBy.TabIndex = 1;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1070, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "بحث بواسطة :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // ctrPersonCard1
            // 
            this.ctrPersonCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ctrPersonCard1.Location = new System.Drawing.Point(3, 115);
            this.ctrPersonCard1.Name = "ctrPersonCard1";
            this.ctrPersonCard1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrPersonCard1.Size = new System.Drawing.Size(1179, 375);
            this.ctrPersonCard1.TabIndex = 1;
            // 
            // ctrPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.ctrPersonCard1);
            this.Controls.Add(this.gbxFilter);
            this.Name = "ctrPersonCardWithFilter";
            this.Size = new System.Drawing.Size(1187, 495);
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.Button btnSearchForPerson;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPerson;
        private ctrPersonCard ctrPersonCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
