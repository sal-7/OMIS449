namespace Addition_Tutor_Project
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.ansInput = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.genButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "=";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(468, 102);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(83, 44);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "???";
            // 
            // ansInput
            // 
            this.ansInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansInput.Location = new System.Drawing.Point(704, 92);
            this.ansInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ansInput.Name = "ansInput";
            this.ansInput.Size = new System.Drawing.Size(196, 51);
            this.ansInput.TabIndex = 4;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(228, 102);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(83, 44);
            this.lblNum1.TabIndex = 5;
            this.lblNum1.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "+";
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(396, 200);
            this.checkButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(296, 88);
            this.checkButton.TabIndex = 7;
            this.checkButton.Text = "Check Answer";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(740, 200);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(296, 88);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // genButton
            // 
            this.genButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genButton.Location = new System.Drawing.Point(46, 200);
            this.genButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(296, 88);
            this.genButton.TabIndex = 9;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 312);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.ansInput);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox ansInput;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button genButton;
    }
}

