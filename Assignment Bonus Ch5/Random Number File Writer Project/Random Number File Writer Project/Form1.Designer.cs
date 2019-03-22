namespace Random_Number_File_Writer_Project
{
    partial class Form1
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
            this.GenButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // GenButton
            // 
            this.GenButton.Location = new System.Drawing.Point(70, 144);
            this.GenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(202, 94);
            this.GenButton.TabIndex = 0;
            this.GenButton.Text = "Generate";
            this.GenButton.UseVisualStyleBackColor = true;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(502, 42);
            this.InputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(148, 31);
            this.InputBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many random numbers do you want?";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(450, 144);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(202, 94);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 327);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.GenButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Random Number File Writer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

