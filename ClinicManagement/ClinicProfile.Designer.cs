namespace ClinicManagement
{
    partial class ClinicProfile
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
            this.btnLogoutClinic = new MetroFramework.Controls.MetroButton();
            this.btnEditProfile = new MetroFramework.Controls.MetroButton();
            this.BtnTestRequest = new MetroFramework.Controls.MetroButton();
            this.BtnNotification = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLogoutClinic
            // 
            this.btnLogoutClinic.BackColor = System.Drawing.Color.Red;
            this.btnLogoutClinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutClinic.Location = new System.Drawing.Point(976, 25);
            this.btnLogoutClinic.Name = "btnLogoutClinic";
            this.btnLogoutClinic.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutClinic.TabIndex = 1;
            this.btnLogoutClinic.Text = "Log Out";
            this.btnLogoutClinic.UseCustomBackColor = true;
            this.btnLogoutClinic.UseSelectable = true;
            this.btnLogoutClinic.Click += new System.EventHandler(this.BtnLogoutClinic_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Blue;
            this.btnEditProfile.Location = new System.Drawing.Point(100, 76);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(75, 43);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseCustomBackColor = true;
            this.btnEditProfile.UseSelectable = true;
            this.btnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // BtnTestRequest
            // 
            this.BtnTestRequest.BackColor = System.Drawing.Color.Blue;
            this.BtnTestRequest.Location = new System.Drawing.Point(410, 76);
            this.BtnTestRequest.Name = "BtnTestRequest";
            this.BtnTestRequest.Size = new System.Drawing.Size(75, 43);
            this.BtnTestRequest.TabIndex = 3;
            this.BtnTestRequest.Text = "Test Request";
            this.BtnTestRequest.UseCustomBackColor = true;
            this.BtnTestRequest.UseSelectable = true;
            this.BtnTestRequest.Click += new System.EventHandler(this.BtnTestRequest_Click);
            // 
            // BtnNotification
            // 
            this.BtnNotification.BackColor = System.Drawing.Color.Blue;
            this.BtnNotification.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnNotification.Location = new System.Drawing.Point(648, 75);
            this.BtnNotification.Name = "BtnNotification";
            this.BtnNotification.Size = new System.Drawing.Size(75, 44);
            this.BtnNotification.TabIndex = 4;
            this.BtnNotification.Text = "Notification";
            this.BtnNotification.UseCustomBackColor = true;
            this.BtnNotification.UseSelectable = true;
            this.BtnNotification.Click += new System.EventHandler(this.BtnNotification_Click);
            // 
            // ClinicProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 586);
            this.Controls.Add(this.BtnNotification);
            this.Controls.Add(this.BtnTestRequest);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnLogoutClinic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ClinicProfile";
            this.Text = "Clinic Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClinicProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogoutClinic;
        private MetroFramework.Controls.MetroButton btnEditProfile;
        private MetroFramework.Controls.MetroButton BtnTestRequest;
        private MetroFramework.Controls.MetroButton BtnNotification;
    }
}