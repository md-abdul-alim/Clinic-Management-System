namespace ClinicManagement
{
    partial class AdminClinicList
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
            this.GrdClinicList = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.BtnBackAdminPage = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCcount = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GrdClinicList)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdClinicList
            // 
            this.GrdClinicList.AllowUserToAddRows = false;
            this.GrdClinicList.AllowUserToDeleteRows = false;
            this.GrdClinicList.AllowUserToResizeRows = false;
            this.GrdClinicList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdClinicList.BackgroundColor = System.Drawing.Color.Gray;
            this.GrdClinicList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdClinicList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdClinicList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdClinicList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GrdClinicList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdClinicList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userid,
            this.username,
            this.phone,
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
            this.GrdClinicList.DefaultCellStyle = dataGridViewCellStyle8;
            this.GrdClinicList.EnableHeadersVisualStyles = false;
            this.GrdClinicList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdClinicList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdClinicList.Location = new System.Drawing.Point(9, 63);
            this.GrdClinicList.Name = "GrdClinicList";
            this.GrdClinicList.ReadOnly = true;
            this.GrdClinicList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdClinicList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GrdClinicList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdClinicList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdClinicList.Size = new System.Drawing.Size(863, 439);
            this.GrdClinicList.TabIndex = 102;
            this.GrdClinicList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPatientList_CellDoubleClick);
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
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
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
            this.btnDelete.Location = new System.Drawing.Point(1066, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 108;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnBackAdminPage
            // 
            this.BtnBackAdminPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnBackAdminPage.Location = new System.Drawing.Point(195, 34);
            this.BtnBackAdminPage.Name = "BtnBackAdminPage";
            this.BtnBackAdminPage.Size = new System.Drawing.Size(75, 23);
            this.BtnBackAdminPage.TabIndex = 109;
            this.BtnBackAdminPage.Text = "Back";
            this.BtnBackAdminPage.UseCustomBackColor = true;
            this.BtnBackAdminPage.UseSelectable = true;
            this.BtnBackAdminPage.Click += new System.EventHandler(this.BtnBackAdminPage_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel1.Location = new System.Drawing.Point(977, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 110;
            this.metroLabel1.Text = "Total Clinic";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txtCcount
            // 
            this.txtCcount.AutoSize = true;
            this.txtCcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCcount.Enabled = false;
            this.txtCcount.Location = new System.Drawing.Point(977, 99);
            this.txtCcount.Name = "txtCcount";
            this.txtCcount.Size = new System.Drawing.Size(0, 0);
            this.txtCcount.Style = MetroFramework.MetroColorStyle.Black;
            this.txtCcount.TabIndex = 111;
            // 
            // AdminClinicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 556);
            this.Controls.Add(this.txtCcount);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnBackAdminPage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.GrdClinicList);
            this.Name = "AdminClinicList";
            this.Text = "AdminClinicList";
            this.Load += new System.EventHandler(this.AdminClinicList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdClinicList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid GrdClinicList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn divission;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn thana;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton BtnBackAdminPage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel txtCcount;
    }
}