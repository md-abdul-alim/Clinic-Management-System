namespace ClinicManagement
{
    partial class AdminProfile
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
            this.BtnDoctorList = new MetroFramework.Controls.MetroButton();
            this.BtnPatientList = new MetroFramework.Controls.MetroButton();
            this.BtnClinicList = new MetroFramework.Controls.MetroButton();
            this.BtnRegistrationClinic = new MetroFramework.Controls.MetroButton();
            this.BtnDoctorsRequest = new MetroFramework.Controls.MetroButton();
            this.BtnLogOut = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BtnDoctorList
            // 
            this.BtnDoctorList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnDoctorList.Location = new System.Drawing.Point(82, 91);
            this.BtnDoctorList.Name = "BtnDoctorList";
            this.BtnDoctorList.Size = new System.Drawing.Size(103, 57);
            this.BtnDoctorList.TabIndex = 0;
            this.BtnDoctorList.Text = "Doctor List";
            this.BtnDoctorList.UseCustomBackColor = true;
            this.BtnDoctorList.UseSelectable = true;
            this.BtnDoctorList.Click += new System.EventHandler(this.BtnDoctorList_Click);
            // 
            // BtnPatientList
            // 
            this.BtnPatientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnPatientList.Location = new System.Drawing.Point(563, 91);
            this.BtnPatientList.Name = "BtnPatientList";
            this.BtnPatientList.Size = new System.Drawing.Size(102, 57);
            this.BtnPatientList.TabIndex = 1;
            this.BtnPatientList.Text = "Patient List";
            this.BtnPatientList.UseCustomBackColor = true;
            this.BtnPatientList.UseSelectable = true;
            this.BtnPatientList.Click += new System.EventHandler(this.BtnPatientList_Click);
            // 
            // BtnClinicList
            // 
            this.BtnClinicList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnClinicList.Location = new System.Drawing.Point(1050, 91);
            this.BtnClinicList.Name = "BtnClinicList";
            this.BtnClinicList.Size = new System.Drawing.Size(107, 57);
            this.BtnClinicList.TabIndex = 2;
            this.BtnClinicList.Text = "Clinic List";
            this.BtnClinicList.UseCustomBackColor = true;
            this.BtnClinicList.UseSelectable = true;
            this.BtnClinicList.Click += new System.EventHandler(this.BtnClinicList_Click);
            // 
            // BtnRegistrationClinic
            // 
            this.BtnRegistrationClinic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnRegistrationClinic.Location = new System.Drawing.Point(82, 216);
            this.BtnRegistrationClinic.Name = "BtnRegistrationClinic";
            this.BtnRegistrationClinic.Size = new System.Drawing.Size(103, 60);
            this.BtnRegistrationClinic.TabIndex = 3;
            this.BtnRegistrationClinic.Text = "Clinic Registration";
            this.BtnRegistrationClinic.UseCustomBackColor = true;
            this.BtnRegistrationClinic.UseSelectable = true;
            this.BtnRegistrationClinic.Click += new System.EventHandler(this.BtnRegistrationClinic_Click);
            // 
            // BtnDoctorsRequest
            // 
            this.BtnDoctorsRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnDoctorsRequest.Location = new System.Drawing.Point(563, 216);
            this.BtnDoctorsRequest.Name = "BtnDoctorsRequest";
            this.BtnDoctorsRequest.Size = new System.Drawing.Size(103, 60);
            this.BtnDoctorsRequest.TabIndex = 6;
            this.BtnDoctorsRequest.Text = "Doctor\'s Request";
            this.BtnDoctorsRequest.UseCustomBackColor = true;
            this.BtnDoctorsRequest.UseSelectable = true;
            this.BtnDoctorsRequest.Click += new System.EventHandler(this.BtnDoctorsRequest_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Red;
            this.BtnLogOut.Location = new System.Drawing.Point(1136, 30);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(75, 23);
            this.BtnLogOut.TabIndex = 7;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseCustomBackColor = true;
            this.BtnLogOut.UseSelectable = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.metroButton1.Location = new System.Drawing.Point(1050, 216);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(107, 60);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "History List";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 603);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnDoctorsRequest);
            this.Controls.Add(this.BtnRegistrationClinic);
            this.Controls.Add(this.BtnClinicList);
            this.Controls.Add(this.BtnPatientList);
            this.Controls.Add(this.BtnDoctorList);
            this.Name = "AdminProfile";
            this.Text = "AdminHomepage";
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnDoctorList;
        private MetroFramework.Controls.MetroButton BtnPatientList;
        private MetroFramework.Controls.MetroButton BtnClinicList;
        private MetroFramework.Controls.MetroButton BtnRegistrationClinic;
        private MetroFramework.Controls.MetroButton BtnDoctorsRequest;
        private MetroFramework.Controls.MetroButton BtnLogOut;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}