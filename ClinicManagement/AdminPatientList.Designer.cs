namespace ClinicManagement
{
    partial class AdminPatientList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridPatientList = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnBackAdmin = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPcount = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPatientList
            // 
            this.GridPatientList.AllowUserToAddRows = false;
            this.GridPatientList.AllowUserToDeleteRows = false;
            this.GridPatientList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GridPatientList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPatientList.BackgroundColor = System.Drawing.Color.Gray;
            this.GridPatientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPatientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridPatientList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userid,
            this.username,
            this.gender,
            this.phone,
            this.email,
            this.dateOfBirth,
            this.divission,
            this.district,
            this.thana});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPatientList.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridPatientList.EnableHeadersVisualStyles = false;
            this.GridPatientList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPatientList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPatientList.Location = new System.Drawing.Point(16, 52);
            this.GridPatientList.Name = "GridPatientList";
            this.GridPatientList.ReadOnly = true;
            this.GridPatientList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPatientList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridPatientList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPatientList.Size = new System.Drawing.Size(893, 439);
            this.GridPatientList.TabIndex = 89;
            this.GridPatientList.UseCustomBackColor = true;
            this.GridPatientList.UseCustomForeColor = true;
            this.GridPatientList.UseStyleColors = true;
            this.GridPatientList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPatientList_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "User Id";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "User Name";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.DataPropertyName = "dateOfBirth";
            this.dateOfBirth.HeaderText = "Date Of Birth";
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ReadOnly = true;
            // 
            // divission
            // 
            this.divission.DataPropertyName = "divission";
            this.divission.HeaderText = "Divission";
            this.divission.Name = "divission";
            this.divission.ReadOnly = true;
            // 
            // district
            // 
            this.district.DataPropertyName = "district";
            this.district.HeaderText = "District";
            this.district.Name = "district";
            this.district.ReadOnly = true;
            // 
            // thana
            // 
            this.thana.DataPropertyName = "thana";
            this.thana.HeaderText = "Thana";
            this.thana.Name = "thana";
            this.thana.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1058, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 87;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnBackAdmin
            // 
            this.btnBackAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackAdmin.Location = new System.Drawing.Point(203, 23);
            this.btnBackAdmin.Name = "btnBackAdmin";
            this.btnBackAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnBackAdmin.TabIndex = 91;
            this.btnBackAdmin.Text = "Back";
            this.btnBackAdmin.UseCustomBackColor = true;
            this.btnBackAdmin.UseSelectable = true;
            this.btnBackAdmin.Click += new System.EventHandler(this.BtnBackAdmin_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Lime;
            this.metroLabel1.Location = new System.Drawing.Point(1010, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 92;
            this.metroLabel1.Text = "Total Patients";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtPcount
            // 
            this.txtPcount.AutoSize = true;
            this.txtPcount.Location = new System.Drawing.Point(1010, 89);
            this.txtPcount.Name = "txtPcount";
            this.txtPcount.Size = new System.Drawing.Size(0, 0);
            this.txtPcount.TabIndex = 93;
            this.txtPcount.UseStyleColors = true;
            // 
            // AdminPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 584);
            this.Controls.Add(this.txtPcount);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnBackAdmin);
            this.Controls.Add(this.GridPatientList);
            this.Controls.Add(this.btnDelete);
            this.Name = "AdminPatientList";
            this.Text = "AdminPatientList";
            this.Load += new System.EventHandler(this.AdminPatientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GridPatientList;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn divission;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn thana;
        private MetroFramework.Controls.MetroButton btnBackAdmin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel txtPcount;
    }
}