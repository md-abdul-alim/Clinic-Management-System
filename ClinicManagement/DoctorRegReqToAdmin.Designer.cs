namespace ClinicManagement
{
    partial class DoctorRegReqToAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnFromDoctorsList = new MetroFramework.Controls.MetroButton();
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
            this.BtnAccept = new MetroFramework.Controls.MetroButton();
            this.BtnReject = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridDoctorsList)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFromDoctorsList
            // 
            this.BtnFromDoctorsList.BackColor = System.Drawing.Color.Blue;
            this.BtnFromDoctorsList.Location = new System.Drawing.Point(265, 29);
            this.BtnFromDoctorsList.Name = "BtnFromDoctorsList";
            this.BtnFromDoctorsList.Size = new System.Drawing.Size(75, 23);
            this.BtnFromDoctorsList.TabIndex = 56;
            this.BtnFromDoctorsList.Text = "Back";
            this.BtnFromDoctorsList.UseCustomBackColor = true;
            this.BtnFromDoctorsList.UseSelectable = true;
            this.BtnFromDoctorsList.Click += new System.EventHandler(this.BtnFromDoctorsList_Click);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDoctorsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDoctorsList.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridDoctorsList.EnableHeadersVisualStyles = false;
            this.GridDoctorsList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridDoctorsList.GridColor = System.Drawing.Color.Blue;
            this.GridDoctorsList.Location = new System.Drawing.Point(11, 63);
            this.GridDoctorsList.Name = "GridDoctorsList";
            this.GridDoctorsList.ReadOnly = true;
            this.GridDoctorsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDoctorsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridDoctorsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridDoctorsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDoctorsList.Size = new System.Drawing.Size(997, 521);
            this.GridDoctorsList.TabIndex = 57;
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
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.Lime;
            this.BtnAccept.Location = new System.Drawing.Point(1014, 63);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 58;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseCustomBackColor = true;
            this.BtnAccept.UseSelectable = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnReject
            // 
            this.BtnReject.BackColor = System.Drawing.Color.Red;
            this.BtnReject.Location = new System.Drawing.Point(1095, 63);
            this.BtnReject.Name = "BtnReject";
            this.BtnReject.Size = new System.Drawing.Size(75, 23);
            this.BtnReject.TabIndex = 59;
            this.BtnReject.Text = "Reject";
            this.BtnReject.UseCustomBackColor = true;
            this.BtnReject.UseSelectable = true;
            this.BtnReject.Click += new System.EventHandler(this.BtnReject_Click);
            // 
            // DoctorRegReqToAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 602);
            this.Controls.Add(this.BtnReject);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.GridDoctorsList);
            this.Controls.Add(this.BtnFromDoctorsList);
            this.Name = "DoctorRegReqToAdmin";
            this.Text = "Doctor\'sRegistrationList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DoctorRegReqToAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDoctorsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnFromDoctorsList;
        private MetroFramework.Controls.MetroGrid GridDoctorsList;
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
        private MetroFramework.Controls.MetroButton BtnAccept;
        private MetroFramework.Controls.MetroButton BtnReject;
    }
}