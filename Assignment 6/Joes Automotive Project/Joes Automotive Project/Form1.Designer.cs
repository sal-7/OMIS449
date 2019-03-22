namespace Joes_Automotive_Project
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
            this.oilChangeCB = new System.Windows.Forms.CheckBox();
            this.lubeJobCB = new System.Windows.Forms.CheckBox();
            this.inspCB = new System.Windows.Forms.CheckBox();
            this.repMufCB = new System.Windows.Forms.CheckBox();
            this.tireRotCB = new System.Windows.Forms.CheckBox();
            this.radRushCB = new System.Windows.Forms.CheckBox();
            this.transRushCB = new System.Windows.Forms.CheckBox();
            this.partsInput = new System.Windows.Forms.TextBox();
            this.laborInput = new System.Windows.Forms.TextBox();
            this.slOutput = new System.Windows.Forms.TextBox();
            this.partsOutput = new System.Windows.Forms.TextBox();
            this.taxOutput = new System.Windows.Forms.TextBox();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilChangeCB
            // 
            this.oilChangeCB.AutoSize = true;
            this.oilChangeCB.Location = new System.Drawing.Point(28, 33);
            this.oilChangeCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oilChangeCB.Name = "oilChangeCB";
            this.oilChangeCB.Size = new System.Drawing.Size(237, 29);
            this.oilChangeCB.TabIndex = 0;
            this.oilChangeCB.Text = "Oil Change ($26.00)";
            this.oilChangeCB.UseVisualStyleBackColor = true;
            // 
            // lubeJobCB
            // 
            this.lubeJobCB.AutoSize = true;
            this.lubeJobCB.Location = new System.Drawing.Point(28, 75);
            this.lubeJobCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lubeJobCB.Name = "lubeJobCB";
            this.lubeJobCB.Size = new System.Drawing.Size(219, 29);
            this.lubeJobCB.TabIndex = 1;
            this.lubeJobCB.Text = "Lube Job ($18.00)";
            this.lubeJobCB.UseVisualStyleBackColor = true;
            // 
            // inspCB
            // 
            this.inspCB.AutoSize = true;
            this.inspCB.Location = new System.Drawing.Point(62, 179);
            this.inspCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inspCB.Name = "inspCB";
            this.inspCB.Size = new System.Drawing.Size(228, 29);
            this.inspCB.TabIndex = 2;
            this.inspCB.Text = "Inspection ($15.00)";
            this.inspCB.UseVisualStyleBackColor = true;
            // 
            // repMufCB
            // 
            this.repMufCB.AutoSize = true;
            this.repMufCB.Location = new System.Drawing.Point(62, 221);
            this.repMufCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.repMufCB.Name = "repMufCB";
            this.repMufCB.Size = new System.Drawing.Size(293, 29);
            this.repMufCB.TabIndex = 3;
            this.repMufCB.Text = "Replace Muffler ($100.00)";
            this.repMufCB.UseVisualStyleBackColor = true;
            // 
            // tireRotCB
            // 
            this.tireRotCB.AutoSize = true;
            this.tireRotCB.Location = new System.Drawing.Point(62, 265);
            this.tireRotCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tireRotCB.Name = "tireRotCB";
            this.tireRotCB.Size = new System.Drawing.Size(253, 29);
            this.tireRotCB.TabIndex = 4;
            this.tireRotCB.Text = "TIre Rotation ($20.00)";
            this.tireRotCB.UseVisualStyleBackColor = true;
            // 
            // radRushCB
            // 
            this.radRushCB.AutoSize = true;
            this.radRushCB.Location = new System.Drawing.Point(24, 33);
            this.radRushCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRushCB.Name = "radRushCB";
            this.radRushCB.Size = new System.Drawing.Size(270, 29);
            this.radRushCB.TabIndex = 5;
            this.radRushCB.Text = "Radiator Flush ($30.00)";
            this.radRushCB.UseVisualStyleBackColor = true;
            // 
            // transRushCB
            // 
            this.transRushCB.AutoSize = true;
            this.transRushCB.Location = new System.Drawing.Point(24, 71);
            this.transRushCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transRushCB.Name = "transRushCB";
            this.transRushCB.Size = new System.Drawing.Size(317, 29);
            this.transRushCB.TabIndex = 6;
            this.transRushCB.Text = "Transmission Flush ($80.00)";
            this.transRushCB.UseVisualStyleBackColor = true;
            // 
            // partsInput
            // 
            this.partsInput.Location = new System.Drawing.Point(124, 38);
            this.partsInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partsInput.Name = "partsInput";
            this.partsInput.Size = new System.Drawing.Size(90, 31);
            this.partsInput.TabIndex = 7;
            // 
            // laborInput
            // 
            this.laborInput.Location = new System.Drawing.Point(124, 88);
            this.laborInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laborInput.Name = "laborInput";
            this.laborInput.Size = new System.Drawing.Size(90, 31);
            this.laborInput.TabIndex = 8;
            // 
            // slOutput
            // 
            this.slOutput.Enabled = false;
            this.slOutput.Location = new System.Drawing.Point(292, 385);
            this.slOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slOutput.Name = "slOutput";
            this.slOutput.Size = new System.Drawing.Size(148, 31);
            this.slOutput.TabIndex = 9;
            // 
            // partsOutput
            // 
            this.partsOutput.Enabled = false;
            this.partsOutput.Location = new System.Drawing.Point(292, 429);
            this.partsOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partsOutput.Name = "partsOutput";
            this.partsOutput.Size = new System.Drawing.Size(148, 31);
            this.partsOutput.TabIndex = 10;
            // 
            // taxOutput
            // 
            this.taxOutput.Enabled = false;
            this.taxOutput.Location = new System.Drawing.Point(292, 471);
            this.taxOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(148, 31);
            this.taxOutput.TabIndex = 11;
            // 
            // totalOutput
            // 
            this.totalOutput.Enabled = false;
            this.totalOutput.Location = new System.Drawing.Point(292, 515);
            this.totalOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(148, 31);
            this.totalOutput.TabIndex = 12;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(34, 604);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(160, 69);
            this.calcButton.TabIndex = 13;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(482, 602);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 71);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(260, 604);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 71);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Parts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Labor ($):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oilChangeCB);
            this.groupBox1.Controls.Add(this.lubeJobCB);
            this.groupBox1.Location = new System.Drawing.Point(34, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(282, 129);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transRushCB);
            this.groupBox2.Controls.Add(this.radRushCB);
            this.groupBox2.Location = new System.Drawing.Point(346, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(344, 125);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(34, 156);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(320, 156);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.laborInput);
            this.groupBox4.Controls.Add(this.partsInput);
            this.groupBox4.Location = new System.Drawing.Point(386, 156);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(300, 156);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(92, 350);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(380, 221);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tax (on Parts):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Service and Labor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 729);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.partsOutput);
            this.Controls.Add(this.slOutput);
            this.Controls.Add(this.tireRotCB);
            this.Controls.Add(this.repMufCB);
            this.Controls.Add(this.inspCB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox oilChangeCB;
        private System.Windows.Forms.CheckBox lubeJobCB;
        private System.Windows.Forms.CheckBox inspCB;
        private System.Windows.Forms.CheckBox repMufCB;
        private System.Windows.Forms.CheckBox tireRotCB;
        private System.Windows.Forms.CheckBox radRushCB;
        private System.Windows.Forms.CheckBox transRushCB;
        private System.Windows.Forms.TextBox partsInput;
        private System.Windows.Forms.TextBox laborInput;
        private System.Windows.Forms.TextBox slOutput;
        private System.Windows.Forms.TextBox partsOutput;
        private System.Windows.Forms.TextBox taxOutput;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

