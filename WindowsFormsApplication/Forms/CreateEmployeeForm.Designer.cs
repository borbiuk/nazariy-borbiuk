namespace WindowsFormsApplication.Forms
{
    partial class CreateEmployeeForm
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
            this.CreateEmployeeButton = new System.Windows.Forms.Button();
            this.EmployeeTypeListComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLable = new System.Windows.Forms.Label();
            this.SalaryLable = new System.Windows.Forms.Label();
            this.ExperienceLable = new System.Windows.Forms.Label();
            this.EffectivnesseLable = new System.Windows.Forms.Label();
            this.EmployeeTypeLable = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.ExperienceTextBox = new System.Windows.Forms.TextBox();
            this.EffectivnessTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateEmployeeButton
            // 
            this.CreateEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateEmployeeButton.Location = new System.Drawing.Point(89, 201);
            this.CreateEmployeeButton.Name = "CreateEmployeeButton";
            this.CreateEmployeeButton.Size = new System.Drawing.Size(267, 31);
            this.CreateEmployeeButton.TabIndex = 0;
            this.CreateEmployeeButton.Text = "Create";
            this.CreateEmployeeButton.UseVisualStyleBackColor = true;
            this.CreateEmployeeButton.Click += new System.EventHandler(this.CreateEmployeeButton_Click);
            // 
            // EmployeeTypeListComboBox
            // 
            this.EmployeeTypeListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeTypeListComboBox.FormattingEnabled = true;
            this.EmployeeTypeListComboBox.Location = new System.Drawing.Point(256, 25);
            this.EmployeeTypeListComboBox.Name = "EmployeeTypeListComboBox";
            this.EmployeeTypeListComboBox.Size = new System.Drawing.Size(100, 26);
            this.EmployeeTypeListComboBox.TabIndex = 1;
            this.EmployeeTypeListComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeTypeListComboBox_SelectedIndexChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(86, 57);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(78, 18);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First name";
            // 
            // SecondNameLable
            // 
            this.SecondNameLable.AutoSize = true;
            this.SecondNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNameLable.Location = new System.Drawing.Point(86, 82);
            this.SecondNameLable.Name = "SecondNameLable";
            this.SecondNameLable.Size = new System.Drawing.Size(100, 18);
            this.SecondNameLable.TabIndex = 3;
            this.SecondNameLable.Text = "Second name";
            // 
            // SalaryLable
            // 
            this.SalaryLable.AutoSize = true;
            this.SalaryLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryLable.Location = new System.Drawing.Point(86, 108);
            this.SalaryLable.Name = "SalaryLable";
            this.SalaryLable.Size = new System.Drawing.Size(49, 18);
            this.SalaryLable.TabIndex = 4;
            this.SalaryLable.Text = "Salary";
            // 
            // ExperienceLable
            // 
            this.ExperienceLable.AutoSize = true;
            this.ExperienceLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExperienceLable.Location = new System.Drawing.Point(86, 135);
            this.ExperienceLable.Name = "ExperienceLable";
            this.ExperienceLable.Size = new System.Drawing.Size(81, 18);
            this.ExperienceLable.TabIndex = 5;
            this.ExperienceLable.Text = "Experience";
            // 
            // EffectivnesseLable
            // 
            this.EffectivnesseLable.AutoSize = true;
            this.EffectivnesseLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EffectivnesseLable.Location = new System.Drawing.Point(86, 164);
            this.EffectivnesseLable.Name = "EffectivnesseLable";
            this.EffectivnesseLable.Size = new System.Drawing.Size(137, 18);
            this.EffectivnesseLable.TabIndex = 7;
            this.EffectivnesseLable.Text = "Effectiveness coeff.";
            // 
            // EmployeeTypeLable
            // 
            this.EmployeeTypeLable.AutoSize = true;
            this.EmployeeTypeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeTypeLable.Location = new System.Drawing.Point(86, 28);
            this.EmployeeTypeLable.Name = "EmployeeTypeLable";
            this.EmployeeTypeLable.Size = new System.Drawing.Size(39, 18);
            this.EmployeeTypeLable.TabIndex = 8;
            this.EmployeeTypeLable.Text = "Role";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(256, 58);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 9;
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(256, 83);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondNameTextBox.TabIndex = 10;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(256, 109);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalaryTextBox.TabIndex = 11;
            // 
            // ExperienceTextBox
            // 
            this.ExperienceTextBox.Location = new System.Drawing.Point(256, 136);
            this.ExperienceTextBox.Name = "ExperienceTextBox";
            this.ExperienceTextBox.Size = new System.Drawing.Size(100, 20);
            this.ExperienceTextBox.TabIndex = 12;
            // 
            // EffectivnessTextBox
            // 
            this.EffectivnessTextBox.Location = new System.Drawing.Point(256, 162);
            this.EffectivnessTextBox.Name = "EffectivnessTextBox";
            this.EffectivnessTextBox.Size = new System.Drawing.Size(100, 20);
            this.EffectivnessTextBox.TabIndex = 14;
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.Controls.Add(this.EffectivnessTextBox);
            this.Controls.Add(this.ExperienceTextBox);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.SecondNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.EmployeeTypeLable);
            this.Controls.Add(this.EffectivnesseLable);
            this.Controls.Add(this.ExperienceLable);
            this.Controls.Add(this.SalaryLable);
            this.Controls.Add(this.SecondNameLable);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.EmployeeTypeListComboBox);
            this.Controls.Add(this.CreateEmployeeButton);
            this.Name = "CreateEmployeeForm";
            this.Text = "CreateEmployeeForm";
            this.Load += new System.EventHandler(this.CreateEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateEmployeeButton;
        private System.Windows.Forms.ComboBox EmployeeTypeListComboBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SecondNameLable;
        private System.Windows.Forms.Label SalaryLable;
        private System.Windows.Forms.Label ExperienceLable;
        private System.Windows.Forms.Label EffectivnesseLable;
        private System.Windows.Forms.Label EmployeeTypeLable;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox ExperienceTextBox;
        private System.Windows.Forms.TextBox EffectivnessTextBox;
    }
}