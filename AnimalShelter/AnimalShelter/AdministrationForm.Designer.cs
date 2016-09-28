namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBadHabits = new System.Windows.Forms.Label();
            this.lblWalkDate = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBadHabits = new System.Windows.Forms.TextBox();
            this.nudDayBirthday = new System.Windows.Forms.NumericUpDown();
            this.nudMonthBirthday = new System.Windows.Forms.NumericUpDown();
            this.nudYearBirthday = new System.Windows.Forms.NumericUpDown();
            this.nudChipNumber = new System.Windows.Forms.NumericUpDown();
            this.nudWalkYear = new System.Windows.Forms.NumericUpDown();
            this.nudWalkDay = new System.Windows.Forms.NumericUpDown();
            this.nudWalkMonth = new System.Windows.Forms.NumericUpDown();
            this.nudFindAnimal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFindAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(12, 12);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(139, 10);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(73, 292);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chip number";
            // 
            // lblBadHabits
            // 
            this.lblBadHabits.AutoSize = true;
            this.lblBadHabits.Location = new System.Drawing.Point(9, 123);
            this.lblBadHabits.Name = "lblBadHabits";
            this.lblBadHabits.Size = new System.Drawing.Size(57, 13);
            this.lblBadHabits.TabIndex = 6;
            this.lblBadHabits.Text = "Bad habits";
            this.lblBadHabits.Visible = false;
            // 
            // lblWalkDate
            // 
            this.lblWalkDate.AutoSize = true;
            this.lblWalkDate.Location = new System.Drawing.Point(9, 123);
            this.lblWalkDate.Name = "lblWalkDate";
            this.lblWalkDate.Size = new System.Drawing.Size(76, 13);
            this.lblWalkDate.TabIndex = 7;
            this.lblWalkDate.Text = "Last walk date";
            this.lblWalkDate.Visible = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(103, 44);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(129, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbBadHabits
            // 
            this.tbBadHabits.Location = new System.Drawing.Point(103, 120);
            this.tbBadHabits.Name = "tbBadHabits";
            this.tbBadHabits.Size = new System.Drawing.Size(129, 20);
            this.tbBadHabits.TabIndex = 9;
            this.tbBadHabits.Visible = false;
            // 
            // nudDayBirthday
            // 
            this.nudDayBirthday.Location = new System.Drawing.Point(103, 68);
            this.nudDayBirthday.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDayBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDayBirthday.Name = "nudDayBirthday";
            this.nudDayBirthday.Size = new System.Drawing.Size(34, 20);
            this.nudDayBirthday.TabIndex = 10;
            this.nudDayBirthday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMonthBirthday
            // 
            this.nudMonthBirthday.Location = new System.Drawing.Point(143, 68);
            this.nudMonthBirthday.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonthBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonthBirthday.Name = "nudMonthBirthday";
            this.nudMonthBirthday.Size = new System.Drawing.Size(34, 20);
            this.nudMonthBirthday.TabIndex = 11;
            this.nudMonthBirthday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYearBirthday
            // 
            this.nudYearBirthday.Location = new System.Drawing.Point(183, 68);
            this.nudYearBirthday.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudYearBirthday.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nudYearBirthday.Name = "nudYearBirthday";
            this.nudYearBirthday.Size = new System.Drawing.Size(49, 20);
            this.nudYearBirthday.TabIndex = 12;
            this.nudYearBirthday.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // nudChipNumber
            // 
            this.nudChipNumber.Enabled = false;
            this.nudChipNumber.Location = new System.Drawing.Point(103, 94);
            this.nudChipNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudChipNumber.Name = "nudChipNumber";
            this.nudChipNumber.Size = new System.Drawing.Size(129, 20);
            this.nudChipNumber.TabIndex = 13;
            // 
            // nudWalkYear
            // 
            this.nudWalkYear.Location = new System.Drawing.Point(183, 121);
            this.nudWalkYear.Maximum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.nudWalkYear.Minimum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.nudWalkYear.Name = "nudWalkYear";
            this.nudWalkYear.Size = new System.Drawing.Size(49, 20);
            this.nudWalkYear.TabIndex = 14;
            this.nudWalkYear.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.nudWalkYear.Visible = false;
            // 
            // nudWalkDay
            // 
            this.nudWalkDay.Location = new System.Drawing.Point(103, 120);
            this.nudWalkDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudWalkDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWalkDay.Name = "nudWalkDay";
            this.nudWalkDay.Size = new System.Drawing.Size(34, 20);
            this.nudWalkDay.TabIndex = 15;
            this.nudWalkDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWalkDay.Visible = false;
            // 
            // nudWalkMonth
            // 
            this.nudWalkMonth.Location = new System.Drawing.Point(143, 120);
            this.nudWalkMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudWalkMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWalkMonth.Name = "nudWalkMonth";
            this.nudWalkMonth.Size = new System.Drawing.Size(34, 20);
            this.nudWalkMonth.TabIndex = 16;
            this.nudWalkMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWalkMonth.Visible = false;
            // 
            // nudFindAnimal
            // 
            this.nudFindAnimal.Location = new System.Drawing.Point(12, 295);
            this.nudFindAnimal.Name = "nudFindAnimal";
            this.nudFindAnimal.Size = new System.Drawing.Size(55, 20);
            this.nudFindAnimal.TabIndex = 17;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 327);
            this.Controls.Add(this.nudFindAnimal);
            this.Controls.Add(this.nudWalkMonth);
            this.Controls.Add(this.nudWalkDay);
            this.Controls.Add(this.nudWalkYear);
            this.Controls.Add(this.nudChipNumber);
            this.Controls.Add(this.nudYearBirthday);
            this.Controls.Add(this.nudMonthBirthday);
            this.Controls.Add(this.nudDayBirthday);
            this.Controls.Add(this.tbBadHabits);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblWalkDate);
            this.Controls.Add(this.lblBadHabits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFindAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBadHabits;
        private System.Windows.Forms.Label lblWalkDate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBadHabits;
        private System.Windows.Forms.NumericUpDown nudDayBirthday;
        private System.Windows.Forms.NumericUpDown nudMonthBirthday;
        private System.Windows.Forms.NumericUpDown nudYearBirthday;
        private System.Windows.Forms.NumericUpDown nudChipNumber;
        private System.Windows.Forms.NumericUpDown nudWalkYear;
        private System.Windows.Forms.NumericUpDown nudWalkDay;
        private System.Windows.Forms.NumericUpDown nudWalkMonth;
        private System.Windows.Forms.NumericUpDown nudFindAnimal;
    }
}

