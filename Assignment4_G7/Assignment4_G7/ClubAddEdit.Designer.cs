namespace TNurislamova_301025614_A4
{
    partial class ClubEditForm
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
            this.labelClubNumber = new System.Windows.Forms.Label();
            this.textBoxClubNumber = new System.Windows.Forms.TextBox();
            this.labelClubName = new System.Windows.Forms.Label();
            this.textBoxClubName = new System.Windows.Forms.TextBox();
            this.groupBoxClubAddress = new System.Windows.Forms.GroupBox();
            this.textBoxClubPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxClubProvince = new System.Windows.Forms.TextBox();
            this.textBoxClubMunicipality = new System.Windows.Forms.TextBox();
            this.textBoxClubDeliveryAddress = new System.Windows.Forms.TextBox();
            this.labelClubPostalCode = new System.Windows.Forms.Label();
            this.labelClubProvince = new System.Windows.Forms.Label();
            this.labelClubMunicipality = new System.Windows.Forms.Label();
            this.labelClubDeliveryAddress = new System.Windows.Forms.Label();
            this.textBoxClubPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelClubPhoneNumber = new System.Windows.Forms.Label();
            this.buttonSaveClub = new System.Windows.Forms.Button();
            this.buttonCancelClub = new System.Windows.Forms.Button();
            this.groupBoxClubAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClubNumber
            // 
            this.labelClubNumber.AutoSize = true;
            this.labelClubNumber.Location = new System.Drawing.Point(10, 42);
            this.labelClubNumber.Name = "labelClubNumber";
            this.labelClubNumber.Size = new System.Drawing.Size(38, 13);
            this.labelClubNumber.TabIndex = 0;
            this.labelClubNumber.Text = "Club #";
            // 
            // textBoxClubNumber
            // 
            this.textBoxClubNumber.Enabled = false;
            this.textBoxClubNumber.Location = new System.Drawing.Point(143, 39);
            this.textBoxClubNumber.Name = "textBoxClubNumber";
            this.textBoxClubNumber.Size = new System.Drawing.Size(181, 20);
            this.textBoxClubNumber.TabIndex = 1;
            this.textBoxClubNumber.TextChanged += new System.EventHandler(this.textBoxClubNumber_TextChanged);
            // 
            // labelClubName
            // 
            this.labelClubName.AutoSize = true;
            this.labelClubName.Location = new System.Drawing.Point(10, 83);
            this.labelClubName.Name = "labelClubName";
            this.labelClubName.Size = new System.Drawing.Size(59, 13);
            this.labelClubName.TabIndex = 2;
            this.labelClubName.Text = "Club Name";
            // 
            // textBoxClubName
            // 
            this.textBoxClubName.Location = new System.Drawing.Point(144, 82);
            this.textBoxClubName.Name = "textBoxClubName";
            this.textBoxClubName.Size = new System.Drawing.Size(179, 20);
            this.textBoxClubName.TabIndex = 3;
            // 
            // groupBoxClubAddress
            // 
            this.groupBoxClubAddress.Controls.Add(this.textBoxClubPostalCode);
            this.groupBoxClubAddress.Controls.Add(this.textBoxClubProvince);
            this.groupBoxClubAddress.Controls.Add(this.textBoxClubMunicipality);
            this.groupBoxClubAddress.Controls.Add(this.textBoxClubDeliveryAddress);
            this.groupBoxClubAddress.Controls.Add(this.labelClubPostalCode);
            this.groupBoxClubAddress.Controls.Add(this.labelClubProvince);
            this.groupBoxClubAddress.Controls.Add(this.labelClubMunicipality);
            this.groupBoxClubAddress.Controls.Add(this.labelClubDeliveryAddress);
            this.groupBoxClubAddress.Location = new System.Drawing.Point(13, 142);
            this.groupBoxClubAddress.Name = "groupBoxClubAddress";
            this.groupBoxClubAddress.Size = new System.Drawing.Size(317, 168);
            this.groupBoxClubAddress.TabIndex = 4;
            this.groupBoxClubAddress.TabStop = false;
            this.groupBoxClubAddress.Text = "Address";
            // 
            // textBoxClubPostalCode
            // 
            this.textBoxClubPostalCode.Location = new System.Drawing.Point(132, 118);
            this.textBoxClubPostalCode.Name = "textBoxClubPostalCode";
            this.textBoxClubPostalCode.Size = new System.Drawing.Size(179, 20);
            this.textBoxClubPostalCode.TabIndex = 7;
            // 
            // textBoxClubProvince
            // 
            this.textBoxClubProvince.Location = new System.Drawing.Point(132, 87);
            this.textBoxClubProvince.Name = "textBoxClubProvince";
            this.textBoxClubProvince.Size = new System.Drawing.Size(179, 20);
            this.textBoxClubProvince.TabIndex = 6;
            // 
            // textBoxClubMunicipality
            // 
            this.textBoxClubMunicipality.Location = new System.Drawing.Point(132, 56);
            this.textBoxClubMunicipality.Name = "textBoxClubMunicipality";
            this.textBoxClubMunicipality.Size = new System.Drawing.Size(179, 20);
            this.textBoxClubMunicipality.TabIndex = 5;
            // 
            // textBoxClubDeliveryAddress
            // 
            this.textBoxClubDeliveryAddress.Location = new System.Drawing.Point(132, 24);
            this.textBoxClubDeliveryAddress.Name = "textBoxClubDeliveryAddress";
            this.textBoxClubDeliveryAddress.Size = new System.Drawing.Size(179, 20);
            this.textBoxClubDeliveryAddress.TabIndex = 4;
            // 
            // labelClubPostalCode
            // 
            this.labelClubPostalCode.AutoSize = true;
            this.labelClubPostalCode.Location = new System.Drawing.Point(7, 125);
            this.labelClubPostalCode.Name = "labelClubPostalCode";
            this.labelClubPostalCode.Size = new System.Drawing.Size(64, 13);
            this.labelClubPostalCode.TabIndex = 3;
            this.labelClubPostalCode.Text = "Postal Code";
            // 
            // labelClubProvince
            // 
            this.labelClubProvince.AutoSize = true;
            this.labelClubProvince.Location = new System.Drawing.Point(7, 94);
            this.labelClubProvince.Name = "labelClubProvince";
            this.labelClubProvince.Size = new System.Drawing.Size(49, 13);
            this.labelClubProvince.TabIndex = 2;
            this.labelClubProvince.Text = "Province";
            // 
            // labelClubMunicipality
            // 
            this.labelClubMunicipality.AutoSize = true;
            this.labelClubMunicipality.Location = new System.Drawing.Point(7, 63);
            this.labelClubMunicipality.Name = "labelClubMunicipality";
            this.labelClubMunicipality.Size = new System.Drawing.Size(62, 13);
            this.labelClubMunicipality.TabIndex = 1;
            this.labelClubMunicipality.Text = "Municipality";
            // 
            // labelClubDeliveryAddress
            // 
            this.labelClubDeliveryAddress.AutoSize = true;
            this.labelClubDeliveryAddress.Location = new System.Drawing.Point(7, 30);
            this.labelClubDeliveryAddress.Name = "labelClubDeliveryAddress";
            this.labelClubDeliveryAddress.Size = new System.Drawing.Size(86, 13);
            this.labelClubDeliveryAddress.TabIndex = 0;
            this.labelClubDeliveryAddress.Text = "Delivery Address";
            // 
            // textBoxClubPhoneNumber
            // 
            this.textBoxClubPhoneNumber.Location = new System.Drawing.Point(144, 339);
            this.textBoxClubPhoneNumber.MaxLength = 10;
            this.textBoxClubPhoneNumber.Name = "textBoxClubPhoneNumber";
            this.textBoxClubPhoneNumber.Size = new System.Drawing.Size(179, 20);
            this.textBoxClubPhoneNumber.TabIndex = 6;
            this.textBoxClubPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxClubPhoneNumber_Validating);
            // 
            // labelClubPhoneNumber
            // 
            this.labelClubPhoneNumber.AutoSize = true;
            this.labelClubPhoneNumber.Location = new System.Drawing.Point(10, 340);
            this.labelClubPhoneNumber.Name = "labelClubPhoneNumber";
            this.labelClubPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelClubPhoneNumber.TabIndex = 5;
            this.labelClubPhoneNumber.Text = "Phone Number";
            // 
            // buttonSaveClub
            // 
            this.buttonSaveClub.Location = new System.Drawing.Point(42, 388);
            this.buttonSaveClub.Name = "buttonSaveClub";
            this.buttonSaveClub.Size = new System.Drawing.Size(102, 31);
            this.buttonSaveClub.TabIndex = 7;
            this.buttonSaveClub.Text = "Save";
            this.buttonSaveClub.UseVisualStyleBackColor = true;
            this.buttonSaveClub.Click += new System.EventHandler(this.buttonSaveClub_Click);
            // 
            // buttonCancelClub
            // 
            this.buttonCancelClub.Location = new System.Drawing.Point(221, 388);
            this.buttonCancelClub.Name = "buttonCancelClub";
            this.buttonCancelClub.Size = new System.Drawing.Size(102, 31);
            this.buttonCancelClub.TabIndex = 8;
            this.buttonCancelClub.Text = "Cancel";
            this.buttonCancelClub.UseVisualStyleBackColor = true;
            this.buttonCancelClub.Click += new System.EventHandler(this.buttonCancelClub_Click);
            // 
            // ClubEditForm
            // 
            this.AcceptButton = this.buttonSaveClub;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.buttonCancelClub);
            this.Controls.Add(this.buttonSaveClub);
            this.Controls.Add(this.textBoxClubPhoneNumber);
            this.Controls.Add(this.labelClubPhoneNumber);
            this.Controls.Add(this.groupBoxClubAddress);
            this.Controls.Add(this.textBoxClubName);
            this.Controls.Add(this.labelClubName);
            this.Controls.Add(this.textBoxClubNumber);
            this.Controls.Add(this.labelClubNumber);
            this.Name = "ClubEditForm";
            this.Text = "Club Add/Edit";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBoxClubAddress.ResumeLayout(false);
            this.groupBoxClubAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClubNumber;
        private System.Windows.Forms.TextBox textBoxClubNumber;
        private System.Windows.Forms.Label labelClubName;
        private System.Windows.Forms.TextBox textBoxClubName;
        private System.Windows.Forms.GroupBox groupBoxClubAddress;
        private System.Windows.Forms.Label labelClubPostalCode;
        private System.Windows.Forms.Label labelClubProvince;
        private System.Windows.Forms.Label labelClubMunicipality;
        private System.Windows.Forms.Label labelClubDeliveryAddress;
        private System.Windows.Forms.TextBox textBoxClubPostalCode;
        private System.Windows.Forms.TextBox textBoxClubProvince;
        private System.Windows.Forms.TextBox textBoxClubMunicipality;
        private System.Windows.Forms.TextBox textBoxClubDeliveryAddress;
        private System.Windows.Forms.TextBox textBoxClubPhoneNumber;
        private System.Windows.Forms.Label labelClubPhoneNumber;
        private System.Windows.Forms.Button buttonSaveClub;
        private System.Windows.Forms.Button buttonCancelClub;
    }
}