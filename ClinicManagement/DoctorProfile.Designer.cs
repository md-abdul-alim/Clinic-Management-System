namespace ClinicManagement
{
    partial class DoctorProfile
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
            this.BtnSetSchedule = new MetroFramework.Controls.MetroButton();
            this.BtnProfile = new MetroFramework.Controls.MetroButton();
            this.BtnRequAppo = new MetroFramework.Controls.MetroButton();
            this.BtnPaWaitingList = new MetroFramework.Controls.MetroButton();
            this.BtnPatientsRecords = new MetroFramework.Controls.MetroButton();
            this.BtnLogOut = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BtnSetSchedule
            // 
            this.BtnSetSchedule.BackColor = System.Drawing.Color.Lime;
            this.BtnSetSchedule.Location = new System.Drawing.Point(551, 94);
            this.BtnSetSchedule.Name = "BtnSetSchedule";
            this.BtnSetSchedule.Size = new System.Drawing.Size(133, 51);
            this.BtnSetSchedule.TabIndex = 0;
            this.BtnSetSchedule.Text = "Set Schedule";
            this.BtnSetSchedule.UseCustomBackColor = true;
            this.BtnSetSchedule.UseSelectable = true;
            this.BtnSetSchedule.Click += new System.EventHandler(this.BtnSetSchedule_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.BackColor = System.Drawing.Color.Lime;
            this.BtnProfile.Location = new System.Drawing.Point(87, 94);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(119, 51);
            this.BtnProfile.TabIndex = 1;
            this.BtnProfile.Text = "Profile";
            this.BtnProfile.UseCustomBackColor = true;
            this.BtnProfile.UseSelectable = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // BtnRequAppo
            // 
            this.BtnRequAppo.BackColor = System.Drawing.Color.Lime;
            this.BtnRequAppo.Location = new System.Drawing.Point(932, 94);
            this.BtnRequAppo.Name = "BtnRequAppo";
            this.BtnRequAppo.Size = new System.Drawing.Size(140, 51);
            this.BtnRequAppo.TabIndex = 2;
            this.BtnRequAppo.Text = "Requested Appointment";
            this.BtnRequAppo.UseCustomBackColor = true;
            this.BtnRequAppo.UseSelectable = true;
            this.BtnRequAppo.Click += new System.EventHandler(this.BtnRequAppo_Click);
            // 
            // BtnPaWaitingList
            // 
            this.BtnPaWaitingList.BackColor = System.Drawing.Color.Lime;
            this.BtnPaWaitingList.Location = new System.Drawing.Point(87, 211);
            this.BtnPaWaitingList.Name = "BtnPaWaitingList";
            this.BtnPaWaitingList.Size = new System.Drawing.Size(119, 55);
            this.BtnPaWaitingList.TabIndex = 3;
            this.BtnPaWaitingList.Text = "Patient Waiting List";
            this.BtnPaWaitingList.UseCustomBackColor = true;
            this.BtnPaWaitingList.UseSelectable = true;
            this.BtnPaWaitingList.Click += new System.EventHandler(this.BtnPaWaitingList_Click);
            // 
            // BtnPatientsRecords
            // 
            this.BtnPatientsRecords.BackColor = System.Drawing.Color.Lime;
            this.BtnPatientsRecords.Location = new System.Drawing.Point(551, 211);
            this.BtnPatientsRecords.Name = "BtnPatientsRecords";
            this.BtnPatientsRecords.Size = new System.Drawing.Size(133, 55);
            this.BtnPatientsRecords.TabIndex = 4;
            this.BtnPatientsRecords.Text = "Patients Records";
            this.BtnPatientsRecords.UseCustomBackColor = true;
            this.BtnPatientsRecords.UseSelectable = true;
            this.BtnPatientsRecords.Click += new System.EventHandler(this.BtnPatientsRecords_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Red;
            this.BtnLogOut.Location = new System.Drawing.Point(1082, 12);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(75, 23);
            this.BtnLogOut.TabIndex = 5;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseCustomBackColor = true;
            this.BtnLogOut.UseSelectable = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // DoctorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 604);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnPatientsRecords);
            this.Controls.Add(this.BtnPaWaitingList);
            this.Controls.Add(this.BtnRequAppo);
            this.Controls.Add(this.BtnProfile);
            this.Controls.Add(this.BtnSetSchedule);
            this.Name = "DoctorProfile";
            this.Text = "DoctorProfile";
            this.Load += new System.EventHandler(this.DoctorProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnSetSchedule;
        private MetroFramework.Controls.MetroButton BtnProfile;
        private MetroFramework.Controls.MetroButton BtnRequAppo;
        private MetroFramework.Controls.MetroButton BtnPaWaitingList;
        private MetroFramework.Controls.MetroButton BtnPatientsRecords;
        private MetroFramework.Controls.MetroButton BtnLogOut;
    }
}