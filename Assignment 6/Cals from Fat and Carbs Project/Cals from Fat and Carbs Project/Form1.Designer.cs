namespace Cals_from_Fat_and_Carbs_Project
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
            this.fatInput = new System.Windows.Forms.TextBox();
            this.carbInput = new System.Windows.Forms.TextBox();
            this.fatOutput = new System.Windows.Forms.TextBox();
            this.carbOutput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fatInput
            // 
            this.fatInput.Location = new System.Drawing.Point(318, 42);
            this.fatInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fatInput.Name = "fatInput";
            this.fatInput.Size = new System.Drawing.Size(148, 31);
            this.fatInput.TabIndex = 0;
            // 
            // carbInput
            // 
            this.carbInput.Location = new System.Drawing.Point(318, 86);
            this.carbInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carbInput.Name = "carbInput";
            this.carbInput.Size = new System.Drawing.Size(148, 31);
            this.carbInput.TabIndex = 1;
            // 
            // fatOutput
            // 
            this.fatOutput.Enabled = false;
            this.fatOutput.Location = new System.Drawing.Point(318, 180);
            this.fatOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fatOutput.Name = "fatOutput";
            this.fatOutput.Size = new System.Drawing.Size(148, 31);
            this.fatOutput.TabIndex = 2;
            // 
            // carbOutput
            // 
            this.carbOutput.Enabled = false;
            this.carbOutput.Location = new System.Drawing.Point(318, 223);
            this.carbOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carbOutput.Name = "carbOutput";
            this.carbOutput.Size = new System.Drawing.Size(148, 31);
            this.carbOutput.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(54, 297);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(152, 58);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(410, 297);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(159, 58);
            this.exitbutton.TabIndex = 5;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter number of Fat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter number of Carbs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Calories from Fat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calories from Carbs:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.carbOutput);
            this.Controls.Add(this.fatOutput);
            this.Controls.Add(this.carbInput);
            this.Controls.Add(this.fatInput);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fatInput;
        private System.Windows.Forms.TextBox carbInput;
        private System.Windows.Forms.TextBox fatOutput;
        private System.Windows.Forms.TextBox carbOutput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

