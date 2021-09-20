namespace EmailPlanner
{
    partial class PlanForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstLetterDateLabel = new System.Windows.Forms.Label();
            this.firstLetterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.secondLetterDateLabel = new System.Windows.Forms.Label();
            this.thirdLetterDateLabel = new System.Windows.Forms.Label();
            this.fourthLetterDateLabel = new System.Windows.Forms.Label();
            this.secondLetterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.thirdLetterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fourthLetterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(41, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(122, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Ім’я (кличний відмінок)";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(181, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(235, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(181, 61);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(235, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(41, 68);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // firstLetterDateLabel
            // 
            this.firstLetterDateLabel.AutoSize = true;
            this.firstLetterDateLabel.Location = new System.Drawing.Point(41, 113);
            this.firstLetterDateLabel.Name = "firstLetterDateLabel";
            this.firstLetterDateLabel.Size = new System.Drawing.Size(111, 13);
            this.firstLetterDateLabel.TabIndex = 4;
            this.firstLetterDateLabel.Text = "Дата першого листа";
            // 
            // firstLetterDateTimePicker
            // 
            this.firstLetterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.firstLetterDateTimePicker.Location = new System.Drawing.Point(181, 107);
            this.firstLetterDateTimePicker.Name = "firstLetterDateTimePicker";
            this.firstLetterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.firstLetterDateTimePicker.TabIndex = 5;
            this.firstLetterDateTimePicker.ValueChanged += new System.EventHandler(this.firstLetterDateTimePicker_ValueChanged);
            // 
            // secondLetterDateLabel
            // 
            this.secondLetterDateLabel.AutoSize = true;
            this.secondLetterDateLabel.Location = new System.Drawing.Point(41, 144);
            this.secondLetterDateLabel.Name = "secondLetterDateLabel";
            this.secondLetterDateLabel.Size = new System.Drawing.Size(107, 13);
            this.secondLetterDateLabel.TabIndex = 6;
            this.secondLetterDateLabel.Text = "Дата другого листа";
            // 
            // thirdLetterDateLabel
            // 
            this.thirdLetterDateLabel.AutoSize = true;
            this.thirdLetterDateLabel.Location = new System.Drawing.Point(41, 175);
            this.thirdLetterDateLabel.Name = "thirdLetterDateLabel";
            this.thirdLetterDateLabel.Size = new System.Drawing.Size(113, 13);
            this.thirdLetterDateLabel.TabIndex = 7;
            this.thirdLetterDateLabel.Text = "Дата третього листа";
            // 
            // fourthLetterDateLabel
            // 
            this.fourthLetterDateLabel.AutoSize = true;
            this.fourthLetterDateLabel.Location = new System.Drawing.Point(41, 207);
            this.fourthLetterDateLabel.Name = "fourthLetterDateLabel";
            this.fourthLetterDateLabel.Size = new System.Drawing.Size(124, 13);
            this.fourthLetterDateLabel.TabIndex = 8;
            this.fourthLetterDateLabel.Text = "Дата четвертого листа";
            // 
            // secondLetterDateTimePicker
            // 
            this.secondLetterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.secondLetterDateTimePicker.Location = new System.Drawing.Point(181, 144);
            this.secondLetterDateTimePicker.Name = "secondLetterDateTimePicker";
            this.secondLetterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.secondLetterDateTimePicker.TabIndex = 9;
            this.secondLetterDateTimePicker.Value = this.firstLetterDateTimePicker.Value.AddDays(7);
            // 
            // thirdLetterDateTimePicker
            // 
            this.thirdLetterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.thirdLetterDateTimePicker.Location = new System.Drawing.Point(181, 175);
            this.thirdLetterDateTimePicker.Name = "thirdLetterDateTimePicker";
            this.thirdLetterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.thirdLetterDateTimePicker.TabIndex = 10;
            this.thirdLetterDateTimePicker.Value = this.firstLetterDateTimePicker.Value.AddDays(14);
            // 
            // fourthLetterDateTimePicker
            // 
            this.fourthLetterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fourthLetterDateTimePicker.Location = new System.Drawing.Point(181, 207);
            this.fourthLetterDateTimePicker.Name = "fourthLetterDateTimePicker";
            this.fourthLetterDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fourthLetterDateTimePicker.TabIndex = 11;
            this.fourthLetterDateTimePicker.Value = this.firstLetterDateTimePicker.Value.AddDays(21);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(217, 241);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(329, 241);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Відміна";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // PlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 276);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fourthLetterDateTimePicker);
            this.Controls.Add(this.thirdLetterDateTimePicker);
            this.Controls.Add(this.secondLetterDateTimePicker);
            this.Controls.Add(this.fourthLetterDateLabel);
            this.Controls.Add(this.thirdLetterDateLabel);
            this.Controls.Add(this.secondLetterDateLabel);
            this.Controls.Add(this.firstLetterDateTimePicker);
            this.Controls.Add(this.firstLetterDateLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "PlanForm";
            this.Text = "PlanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label nameLabel;
        protected internal System.Windows.Forms.TextBox nameTextBox;
        protected internal System.Windows.Forms.TextBox emailTextBox;
        protected internal System.Windows.Forms.Label emailLabel;
        protected internal System.Windows.Forms.Label firstLetterDateLabel;
        protected internal System.Windows.Forms.DateTimePicker firstLetterDateTimePicker;
        protected internal System.Windows.Forms.Label secondLetterDateLabel;
        protected internal System.Windows.Forms.Label thirdLetterDateLabel;
        protected internal System.Windows.Forms.Label fourthLetterDateLabel;
        protected internal System.Windows.Forms.DateTimePicker secondLetterDateTimePicker;
        protected internal System.Windows.Forms.DateTimePicker thirdLetterDateTimePicker;
        protected internal System.Windows.Forms.DateTimePicker fourthLetterDateTimePicker;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}