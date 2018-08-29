namespace Customer_Data
{
    partial class Form2
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerNameData = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblCountryNameData = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblSexData = new System.Windows.Forms.Label();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.lblHobbiesData = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(42, 38);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerNameData
            // 
            this.lblCustomerNameData.AutoSize = true;
            this.lblCustomerNameData.Location = new System.Drawing.Point(134, 38);
            this.lblCustomerNameData.Name = "lblCustomerNameData";
            this.lblCustomerNameData.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerNameData.TabIndex = 1;
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Location = new System.Drawing.Point(42, 81);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(74, 13);
            this.lblCountryName.TabIndex = 2;
            this.lblCountryName.Text = "Country Name";
            // 
            // lblCountryNameData
            // 
            this.lblCountryNameData.AutoSize = true;
            this.lblCountryNameData.Location = new System.Drawing.Point(134, 81);
            this.lblCountryNameData.Name = "lblCountryNameData";
            this.lblCountryNameData.Size = new System.Drawing.Size(0, 13);
            this.lblCountryNameData.TabIndex = 3;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(42, 116);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 13);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "Sex";
            // 
            // lblSexData
            // 
            this.lblSexData.AutoSize = true;
            this.lblSexData.Location = new System.Drawing.Point(134, 116);
            this.lblSexData.Name = "lblSexData";
            this.lblSexData.Size = new System.Drawing.Size(0, 13);
            this.lblSexData.TabIndex = 5;
            this.lblSexData.Click += new System.EventHandler(this.lblSexData_Click);
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(42, 147);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(46, 13);
            this.lblHobbies.TabIndex = 6;
            this.lblHobbies.Text = "Hobbies";
            // 
            // lblHobbiesData
            // 
            this.lblHobbiesData.AutoSize = true;
            this.lblHobbiesData.Location = new System.Drawing.Point(134, 147);
            this.lblHobbiesData.Name = "lblHobbiesData";
            this.lblHobbiesData.Size = new System.Drawing.Size(0, 13);
            this.lblHobbiesData.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(42, 178);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // lblStatusData
            // 
            this.lblStatusData.AutoSize = true;
            this.lblStatusData.Location = new System.Drawing.Point(134, 178);
            this.lblStatusData.Name = "lblStatusData";
            this.lblStatusData.Size = new System.Drawing.Size(0, 13);
            this.lblStatusData.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblStatusData);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHobbiesData);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.lblSexData);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblCountryNameData);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblCustomerNameData);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerNameData;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblCountryNameData;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblSexData;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.Label lblHobbiesData;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusData;
    }
}