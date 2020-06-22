namespace ClinicManagement
{
    partial class PatientProfile
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
            this.BtnTakeAppointment = new MetroFramework.Controls.MetroButton();
            this.BtnHistory = new MetroFramework.Controls.MetroButton();
            this.BtnProfile = new MetroFramework.Controls.MetroButton();
            this.BtnNotification = new MetroFramework.Controls.MetroButton();
            this.BtnLogOut = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BtnTakeAppointment
            // 
            this.BtnTakeAppointment.BackColor = System.Drawing.Color.Teal;
            this.BtnTakeAppointment.Location = new System.Drawing.Point(561, 246);
            this.BtnTakeAppointment.Name = "BtnTakeAppointment";
            this.BtnTakeAppointment.Size = new System.Drawing.Size(137, 52);
            this.BtnTakeAppointment.TabIndex = 0;
            this.BtnTakeAppointment.Text = "Take Appointment";
            this.BtnTakeAppointment.UseCustomBackColor = true;
            this.BtnTakeAppointment.UseSelectable = true;
            this.BtnTakeAppointment.Click += new System.EventHandler(this.BtnTakeAppointment_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.BackColor = System.Drawing.Color.Teal;
            this.BtnHistory.Location = new System.Drawing.Point(561, 162);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(137, 52);
            this.BtnHistory.TabIndex = 1;
            this.BtnHistory.Text = "History";
            this.BtnHistory.UseCustomBackColor = true;
            this.BtnHistory.UseSelectable = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.BackColor = System.Drawing.Color.Teal;
            this.BtnProfile.Location = new System.Drawing.Point(561, 74);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(137, 53);
            this.BtnProfile.TabIndex = 2;
            this.BtnProfile.Text = "Profile";
            this.BtnProfile.UseCustomBackColor = true;
            this.BtnProfile.UseSelectable = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // BtnNotification
            // 
            this.BtnNotification.BackColor = System.Drawing.Color.Teal;
            this.BtnNotification.Location = new System.Drawing.Point(561, 350);
            this.BtnNotification.Name = "BtnNotification";
            this.BtnNotification.Size = new System.Drawing.Size(137, 54);
            this.BtnNotification.TabIndex = 4;
            this.BtnNotification.Text = "Notification";
            this.BtnNotification.UseCustomBackColor = true;
            this.BtnNotification.UseSelectable = true;
            this.BtnNotification.Click += new System.EventHandler(this.BtnNotification_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Red;
            this.BtnLogOut.Location = new System.Drawing.Point(1170, 18);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(75, 39);
            this.BtnLogOut.TabIndex = 5;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseCustomBackColor = true;
            this.BtnLogOut.UseSelectable = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // PatientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 614);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnNotification);
            this.Controls.Add(this.BtnProfile);
            this.Controls.Add(this.BtnHistory);
            this.Controls.Add(this.BtnTakeAppointment);
            this.Name = "PatientProfile";
            this.Text = "PatientProfile";
            this.Load += new System.EventHandler(this.PatientProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnTakeAppointment;
        private MetroFramework.Controls.MetroButton BtnHistory;
        private MetroFramework.Controls.MetroButton BtnProfile;
        private MetroFramework.Controls.MetroButton BtnNotification;
        private MetroFramework.Controls.MetroButton BtnLogOut;
    }
}