namespace EmailProject
{
    partial class MoreDetails
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.displayNameLabel = new System.Windows.Forms.Label();
            this.displayEmailLabel = new System.Windows.Forms.Label();
            this.displayPhoneLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(37, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "First Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(171, 34);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(58, 13);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Last Name";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(320, 34);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone Number";
            // 
            // displayNameLabel
            // 
            this.displayNameLabel.AutoSize = true;
            this.displayNameLabel.Location = new System.Drawing.Point(37, 105);
            this.displayNameLabel.Name = "displayNameLabel";
            this.displayNameLabel.Size = new System.Drawing.Size(35, 13);
            this.displayNameLabel.TabIndex = 3;
            this.displayNameLabel.Text = "label4";
            // 
            // displayEmailLabel
            // 
            this.displayEmailLabel.AutoSize = true;
            this.displayEmailLabel.Location = new System.Drawing.Point(171, 105);
            this.displayEmailLabel.Name = "displayEmailLabel";
            this.displayEmailLabel.Size = new System.Drawing.Size(35, 13);
            this.displayEmailLabel.TabIndex = 4;
            this.displayEmailLabel.Text = "label5";
            // 
            // displayPhoneLabel
            // 
            this.displayPhoneLabel.AutoSize = true;
            this.displayPhoneLabel.Location = new System.Drawing.Point(320, 105);
            this.displayPhoneLabel.Name = "displayPhoneLabel";
            this.displayPhoneLabel.Size = new System.Drawing.Size(35, 13);
            this.displayPhoneLabel.TabIndex = 5;
            this.displayPhoneLabel.Text = "label6";
            // 
            // MoreDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 220);
            this.Controls.Add(this.displayPhoneLabel);
            this.Controls.Add(this.displayEmailLabel);
            this.Controls.Add(this.displayNameLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "MoreDetails";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        public System.Windows.Forms.Label displayNameLabel;
        public System.Windows.Forms.Label displayEmailLabel;
        public System.Windows.Forms.Label displayPhoneLabel;
    }
}