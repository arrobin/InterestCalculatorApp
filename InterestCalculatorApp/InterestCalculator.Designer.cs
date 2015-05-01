namespace InterestCalculatorApp
{
    partial class InterestCalculator
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
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.calculateInterestButton = new System.Windows.Forms.Button();
            this.showInterestTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time (in year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(96, 56);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(129, 20);
            this.timeTextBox.TabIndex = 3;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(96, 99);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(129, 20);
            this.balanceTextBox.TabIndex = 3;
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Items.AddRange(new object[] {
            "BRAC",
            "DBBL",
            "HSBC"});
            this.bankNameComboBox.Location = new System.Drawing.Point(96, 19);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.bankNameComboBox.TabIndex = 4;
            // 
            // calculateInterestButton
            // 
            this.calculateInterestButton.Location = new System.Drawing.Point(50, 150);
            this.calculateInterestButton.Name = "calculateInterestButton";
            this.calculateInterestButton.Size = new System.Drawing.Size(145, 24);
            this.calculateInterestButton.TabIndex = 5;
            this.calculateInterestButton.Text = "Calculate Interest";
            this.calculateInterestButton.UseVisualStyleBackColor = true;
            this.calculateInterestButton.Click += new System.EventHandler(this.calculateInterestButton_Click);
            // 
            // showInterestTextBox
            // 
            this.showInterestTextBox.Location = new System.Drawing.Point(96, 189);
            this.showInterestTextBox.Name = "showInterestTextBox";
            this.showInterestTextBox.ReadOnly = true;
            this.showInterestTextBox.Size = new System.Drawing.Size(129, 20);
            this.showInterestTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Interest =";
            // 
            // InterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 240);
            this.Controls.Add(this.calculateInterestButton);
            this.Controls.Add(this.bankNameComboBox);
            this.Controls.Add(this.showInterestTextBox);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InterestCalculator";
            this.Text = "InterestCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.Button calculateInterestButton;
        private System.Windows.Forms.TextBox showInterestTextBox;
        private System.Windows.Forms.Label label4;
    }
}

