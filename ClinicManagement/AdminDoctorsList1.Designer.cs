namespace ClinicManagement
{
    partial class AdminDoctorsList1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridDoctorsList = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bmdcregno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnFromDoctorsList = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDcount = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridDoctorsList)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDoctorsList
            // 
            this.GridDoctorsList.AllowUserToAddRows = false;
            this.GridDoctorsList.AllowUserToDeleteRows = false;
            this.GridDoctorsList.AllowUserToResizeRows = false;
            this.GridDoctorsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridDoctorsList.BackgroundColor = System.Drawing.Color.Silver;
            this.GridDoctorsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridDoctorsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridDoctorsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDoctorsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridDoctorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDoctorsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userid,
            this.username,
            this.gender,
            this.phone,
            this.email,
            this.dateOfBirth,
            this.specialty,
            this.degree,
            this.bmdcregno,
            this.description,
            this.divission,
            this.district,
            this.thana});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDoctorsList.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridDoctorsList.EnableHeadersVisualStyles = false;
            this.GridDoctorsList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridDoctorsList.GridColor = System.Drawing.Color.Blue;
            this.GridDoctorsList.Location = new System.Drawing.Point(23, 58);
            this.GridDoctorsList.Name = "GridDoctorsList";
            this.GridDoctorsList.ReadOnly = true;
            this.GridDoctorsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDoctorsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridDoctorsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridDoctorsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDoctorsList.Size = new System.Drawing.Size(924, 521);
            this.GridDoctorsList.TabIndex = 55;
            this.GridDoctorsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDoctorsList_CellContentClick);
            this.GridDoctorsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDoctorsList_CellDoubleClick);
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
            this.userid.HeaderText = "User ID";
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
            this.phone.HeaderText = "Phone Number";
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
            // specialty
            // 
            this.specialty.DataPropertyName = "specialty";
            this.specialty.HeaderText = "Specialty";
            this.specialty.Name = "specialty";
            this.specialty.ReadOnly = true;
            // 
            // degree
            // 
            this.degree.DataPropertyName = "degree";
            this.degree.HeaderText = "Degree";
            this.degree.Name = "degree";
            this.degree.ReadOnly = true;
            // 
            // bmdcregno
            // 
            this.bmdcregno.DataPropertyName = "bmdcregno";
            this.bmdcregno.HeaderText = "Bmdcreg No";
            this.bmdcregno.Name = "bmdcregno";
            this.bmdcregno.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
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
            // BtnFromDoctorsList
            // 
            this.BtnFromDoctorsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnFromDoctorsList.Location = new System.Drawing.Point(154, 25);
            this.BtnFromDoctorsList.Name = "BtnFromDoctorsList";
            this.BtnFromDoctorsList.Size = new System.Drawing.Size(75, 23);
            this.BtnFromDoctorsList.TabIndex = 56;
            this.BtnFromDoctorsList.Text = "Back";
            this.BtnFromDoctorsList.UseCustomBackColor = true;
            this.BtnFromDoctorsList.UseSelectable = true;
            this.BtnFromDoctorsList.Click += new System.EventHandler(this.BtnFromDoctorsList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1114, 544);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel1.Location = new System.Drawing.Point(1051, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 57;
            this.metroLabel1.Text = "Total Doctors";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txtDcount
            // 
            this.txtDcount.AutoSize = true;
            this.txtDcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDcount.Location = new System.Drawing.Point(1051, 95);
            this.txtDcount.Name = "txtDcount";
            this.txtDcount.Size = new System.Drawing.Size(0, 0);
            this.txtDcount.TabIndex = 58;
            this.txtDcount.UseStyleColors = true;
            // 
            // AdminDoctorsList1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 602);
            this.Controls.Add(this.txtDcount);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnFromDoctorsList);
            this.Controls.Add(this.GridDoctorsList);
            this.Controls.Add(this.btnDelete);
            this.Name = "AdminDoctorsList1";
            this.Text = "Doctor\'s List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDoctorsList1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDoctorsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid GridDoctorsList;
        private MetroFramework.Controls.MetroButton BtnFromDoctorsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn bmdcregno;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn divission;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn thana;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel txtDcount;
    }
}