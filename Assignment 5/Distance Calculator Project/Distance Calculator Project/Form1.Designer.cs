namespace Distance_Calculator_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mphInput = new System.Windows.Forms.TextBox();
            this.hoursInput = new System.Windows.Forms.TextBox();
            this.hoursLB = new System.Windows.Forms.ListBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle speed in MPH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours Traveled:";
            // 
            // mphInput
            // 
            this.mphInput.Location = new System.Drawing.Point(356, 79);
            this.mphInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mphInput.Name = "mphInput";
            this.mphInput.Size = new System.Drawing.Size(196, 31);
            this.mphInput.TabIndex = 2;
            // 
            // hoursInput
            // 
            this.hoursInput.Location = new System.Drawing.Point(356, 165);
            this.hoursInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(196, 31);
            this.hoursInput.TabIndex = 3;
            // 
            // hoursLB
            // 
            this.hoursLB.FormattingEnabled = true;
            this.hoursLB.ItemHeight = 25;
            this.hoursLB.Location = new System.Drawing.Point(170, 262);
            this.hoursLB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hoursLB.Name = "hoursLB";
            this.hoursLB.Size = new System.Drawing.Size(426, 179);
            this.hoursLB.TabIndex = 4;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(78, 492);
            this.calcButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(186, 90);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(510, 492);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(186, 90);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.hoursLB);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.mphInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Distance Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mphInput;
        private System.Windows.Forms.TextBox hoursInput;
        private System.Windows.Forms.ListBox hoursLB;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
    }
}

