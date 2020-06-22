namespace ClinicManagement
{
    partial class ClinicRegistration
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
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.comThana = new MetroFramework.Controls.MetroComboBox();
            this.comDistrict = new MetroFramework.Controls.MetroComboBox();
            this.comDivission = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnAddclinic = new MetroFramework.Controls.MetroButton();
            this.txtconPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtUserId = new MetroFramework.Controls.MetroTextBox();
            this.btnAdminPage = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(296, 184);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(169, 23);
            this.txtName.TabIndex = 30;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Name";
            this.txtName.WaterMarkColor = System.Drawing.Color.Red;
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comThana
            // 
            this.comThana.FormattingEnabled = true;
            this.comThana.ItemHeight = 23;
            this.comThana.Location = new System.Drawing.Point(554, 355);
            this.comThana.Name = "comThana";
            this.comThana.PromptText = "Thana";
            this.comThana.Size = new System.Drawing.Size(121, 29);
            this.comThana.TabIndex = 29;
            this.comThana.UseSelectable = true;
            // 
            // comDistrict
            // 
            this.comDistrict.FormattingEnabled = true;
            this.comDistrict.ItemHeight = 23;
            this.comDistrict.Location = new System.Drawing.Point(425, 355);
            this.comDistrict.Name = "comDistrict";
            this.comDistrict.PromptText = "District";
            this.comDistrict.Size = new System.Drawing.Size(121, 29);
            this.comDistrict.TabIndex = 28;
            this.comDistrict.UseSelectable = true;
            this.comDistrict.SelectedIndexChanged += new System.EventHandler(this.ComDistrict_SelectedIndexChanged);
            // 
            // comDivission
            // 
            this.comDivission.FormattingEnabled = true;
            this.comDivission.ItemHeight = 23;
            this.comDivission.Location = new System.Drawing.Point(296, 355);
            this.comDivission.Name = "comDivission";
            this.comDivission.PromptText = "Divission";
            this.comDivission.Size = new System.Drawing.Size(121, 29);
            this.comDivission.Style = MetroFramework.MetroColorStyle.Red;
            this.comDivission.TabIndex = 27;
            this.comDivission.UseSelectable = true;
            this.comDivission.UseStyleColors = true;
            this.comDivission.SelectedIndexChanged += new System.EventHandler(this.ComDivission_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(152, 361);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(94, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Clinic Address:";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(152, 188);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Clinic Name:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(152, 142);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "User Id:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // BtnAddclinic
            // 
            this.BtnAddclinic.BackColor = System.Drawing.Color.Blue;
            this.BtnAddclinic.Location = new System.Drawing.Point(399, 487);
            this.BtnAddclinic.Name = "BtnAddclinic";
            this.BtnAddclinic.Size = new System.Drawing.Size(75, 23);
            this.BtnAddclinic.TabIndex = 32;
            this.BtnAddclinic.Text = "Add Clinic";
            this.BtnAddclinic.UseCustomBackColor = true;
            this.BtnAddclinic.UseSelectable = true;
            this.BtnAddclinic.UseStyleColors = true;
            this.BtnAddclinic.Click += new System.EventHandler(this.BtnAddclinic_Click);
            // 
            // txtconPassword
            // 
            // 
            // 
            // 
            this.txtconPassword.CustomButton.Image = null;
            this.txtconPassword.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtconPassword.CustomButton.Name = "";
            this.txtconPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtconPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtconPassword.CustomButton.TabIndex = 1;
            this.txtconPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtconPassword.CustomButton.UseSelectable = true;
            this.txtconPassword.CustomButton.Visible = false;
            this.txtconPassword.Lines = new string[0];
            this.txtconPassword.Location = new System.Drawing.Point(296, 269);
            this.txtconPassword.MaxLength = 32767;
            this.txtconPassword.Name = "txtconPassword";
            this.txtconPassword.PasswordChar = '$';
            this.txtconPassword.PromptText = "Confirm Password";
            this.txtconPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtconPassword.SelectedText = "";
            this.txtconPassword.SelectionLength = 0;
            this.txtconPassword.SelectionStart = 0;
            this.txtconPassword.ShortcutsEnabled = true;
            this.txtconPassword.Size = new System.Drawing.Size(169, 23);
            this.txtconPassword.TabIndex = 43;
            this.txtconPassword.UseSelectable = true;
            this.txtconPassword.WaterMark = "Confirm Password";
            this.txtconPassword.WaterMarkColor = System.Drawing.Color.Red;
            this.txtconPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(296, 228);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '$';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(169, 23);
            this.txtPassword.TabIndex = 42;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.Red;
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(152, 228);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(66, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel9.TabIndex = 41;
            this.metroLabel9.Text = "Password:";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(152, 269);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(118, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.TabIndex = 40;
            this.metroLabel8.Text = "Confirm Password:";
            this.metroLabel8.UseStyleColors = true;
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(296, 312);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PromptText = "01XXXXXXXXX";
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(169, 23);
            this.txtPhone.TabIndex = 45;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMark = "01XXXXXXXXX";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.Red;
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(152, 312);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 44;
            this.metroLabel4.Text = "Phone:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txtUserId
            // 
            this.txtUserId.CausesValidation = false;
            // 
            // 
            // 
            this.txtUserId.CustomButton.Image = null;
            this.txtUserId.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtUserId.CustomButton.Name = "";
            this.txtUserId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserId.CustomButton.TabIndex = 1;
            this.txtUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserId.CustomButton.UseSelectable = true;
            this.txtUserId.CustomButton.Visible = false;
            this.txtUserId.Lines = new string[0];
            this.txtUserId.Location = new System.Drawing.Point(296, 138);
            this.txtUserId.MaxLength = 32767;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PasswordChar = '\0';
            this.txtUserId.PromptText = "User Id";
            this.txtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserId.SelectedText = "";
            this.txtUserId.SelectionLength = 0;
            this.txtUserId.SelectionStart = 0;
            this.txtUserId.ShortcutsEnabled = true;
            this.txtUserId.Size = new System.Drawing.Size(169, 23);
            this.txtUserId.TabIndex = 31;
            this.txtUserId.UseSelectable = true;
            this.txtUserId.WaterMark = "User Id";
            this.txtUserId.WaterMarkColor = System.Drawing.Color.Red;
            this.txtUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAdminPage
            // 
            this.btnAdminPage.BackColor = System.Drawing.Color.Aqua;
            this.btnAdminPage.Location = new System.Drawing.Point(24, 64);
            this.btnAdminPage.Name = "btnAdminPage";
            this.btnAdminPage.Size = new System.Drawing.Size(75, 23);
            this.btnAdminPage.TabIndex = 46;
            this.btnAdminPage.Text = "Back";
            this.btnAdminPage.UseCustomBackColor = true;
            this.btnAdminPage.UseSelectable = true;
            this.btnAdminPage.Click += new System.EventHandler(this.BtnAdminPage_Click);
            // 
            // ClinicRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 556);
            this.Controls.Add(this.btnAdminPage);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtconPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.BtnAddclinic);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.comThana);
            this.Controls.Add(this.comDistrict);
            this.Controls.Add(this.comDivission);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ClinicRegistration";
            this.Text = "ClinicRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroComboBox comThana;
        private MetroFramework.Controls.MetroComboBox comDistrict;
        private MetroFramework.Controls.MetroComboBox comDivission;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnAddclinic;
        private MetroFramework.Controls.MetroTextBox txtconPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtUserId;
        private MetroFramework.Controls.MetroButton btnAdminPage;
    }
}