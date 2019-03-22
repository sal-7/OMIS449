namespace fatCalories
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
            this.label3 = new System.Windows.Forms.Label();
            this.totalCalories = new System.Windows.Forms.TextBox();
            this.numberFatGrams = new System.Windows.Forms.TextBox();
            this.lowFatCheckbox = new System.Windows.Forms.CheckBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Calories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of fat grams:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(607, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fat Percentage Calculator";
            // 
            // totalCalories
            // 
            this.totalCalories.Location = new System.Drawing.Point(475, 208);
            this.totalCalories.Name = "totalCalories";
            this.totalCalories.Size = new System.Drawing.Size(248, 31);
            this.totalCalories.TabIndex = 3;
            // 
            // numberFatGrams
            // 
            this.numberFatGrams.Location = new System.Drawing.Point(475, 308);
            this.numberFatGrams.Name = "numberFatGrams";
            this.numberFatGrams.Size = new System.Drawing.Size(248, 31);
            this.numberFatGrams.TabIndex = 4;
            // 
            // lowFatCheckbox
            // 
            this.lowFatCheckbox.AutoSize = true;
            this.lowFatCheckbox.Location = new System.Drawing.Point(475, 398);
            this.lowFatCheckbox.Name = "lowFatCheckbox";
            this.lowFatCheckbox.Size = new System.Drawing.Size(271, 29);
            this.lowFatCheckbox.TabIndex = 5;
            this.lowFatCheckbox.Text = "show low fat food or not";
            this.lowFatCheckbox.UseVisualStyleBackColor = true;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.Location = new System.Drawing.Point(167, 666);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 31);
            this.resultLbl.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 796);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.lowFatCheckbox);
            this.Controls.Add(this.numberFatGrams);
            this.Controls.Add(this.totalCalories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Fat Percentage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalCalories;
        private System.Windows.Forms.TextBox numberFatGrams;
        private System.Windows.Forms.CheckBox lowFatCheckbox;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

