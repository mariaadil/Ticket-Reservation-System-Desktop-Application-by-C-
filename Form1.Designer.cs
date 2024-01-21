namespace TicketReservationSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            selectCountryDropDown = new ComboBox();
            selectDestinationComboBox = new ComboBox();
            firstName = new TextBox();
            lastName = new TextBox();
            nationality = new TextBox();
            contactNumber = new TextBox();
            customTripRadioButton = new RadioButton();
            packageTripRadioButton = new RadioButton();
            dayTripRadioButton = new RadioButton();
            nightTripRadioButton = new RadioButton();
            tripTimeGroupBox = new GroupBox();
            culturalWorkShopTextBox = new TextBox();
            accommodationsCostTextBox = new TextBox();
            baseCostTextBox = new TextBox();
            tripIDTextBox = new TextBox();
            accommodationscheckBox = new CheckBox();
            personsTextBox = new TextBox();
            bookTripButton = new Button();
            selectCountry = new Label();
            selectDestination = new Label();
            numericUpDown1 = new NumericUpDown();
            destinationInfo = new TextBox();
            packageTripInfo = new TextBox();
            guidedCityTourcheckBox = new CheckBox();
            museumVisitscheckBox = new CheckBox();
            culturalWorkshopcheckBox = new CheckBox();
            tripTimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // selectCountryDropDown
            // 
            selectCountryDropDown.BackColor = Color.White;
            selectCountryDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            selectCountryDropDown.FormattingEnabled = true;
            selectCountryDropDown.Items.AddRange(new object[] { "Thailand", "Malaysia", "Egypt", "Saudi Arabia" });
            selectCountryDropDown.Location = new Point(42, 41);
            selectCountryDropDown.Margin = new Padding(4, 4, 4, 4);
            selectCountryDropDown.Name = "selectCountryDropDown";
            selectCountryDropDown.Size = new Size(232, 33);
            selectCountryDropDown.TabIndex = 0;
            selectCountryDropDown.SelectedIndexChanged += selectCountryDropDown_SelectedIndexChanged;
            // 
            // selectDestinationComboBox
            // 
            selectDestinationComboBox.BackColor = Color.White;
            selectDestinationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectDestinationComboBox.FormattingEnabled = true;
            selectDestinationComboBox.Location = new Point(282, 41);
            selectDestinationComboBox.Margin = new Padding(4, 4, 4, 4);
            selectDestinationComboBox.Name = "selectDestinationComboBox";
            selectDestinationComboBox.Size = new Size(392, 33);
            selectDestinationComboBox.TabIndex = 1;
            selectDestinationComboBox.SelectedIndexChanged += selectDestinationComboBox_SelectedIndexChanged;
            // 
            // firstName
            // 
            firstName.BackColor = Color.White;
            firstName.ForeColor = Color.Gray;
            firstName.Location = new Point(42, 415);
            firstName.Margin = new Padding(4, 4, 4, 4);
            firstName.Name = "firstName";
            firstName.Size = new Size(208, 31);
            firstName.TabIndex = 3;
            firstName.Text = "First Name";
            firstName.TextChanged += firstName_TextChanged;
            // 
            // lastName
            // 
            lastName.BackColor = Color.White;
            lastName.ForeColor = Color.Gray;
            lastName.Location = new Point(296, 415);
            lastName.Margin = new Padding(4, 4, 4, 4);
            lastName.Name = "lastName";
            lastName.Size = new Size(228, 31);
            lastName.TabIndex = 4;
            lastName.Text = "Last Name";
            lastName.TextChanged += lastName_TextChanged;
            // 
            // nationality
            // 
            nationality.BackColor = Color.White;
            nationality.ForeColor = Color.Gray;
            nationality.Location = new Point(42, 480);
            nationality.Margin = new Padding(4, 4, 4, 4);
            nationality.Name = "nationality";
            nationality.Size = new Size(208, 31);
            nationality.TabIndex = 5;
            nationality.Text = "Nationality";
            nationality.TextChanged += nationality_TextChanged;
            // 
            // contactNumber
            // 
            contactNumber.BackColor = Color.White;
            contactNumber.ForeColor = Color.Gray;
            contactNumber.Location = new Point(296, 480);
            contactNumber.Margin = new Padding(4, 4, 4, 4);
            contactNumber.Name = "contactNumber";
            contactNumber.Size = new Size(228, 31);
            contactNumber.TabIndex = 6;
            contactNumber.Text = "Contact Number";
            contactNumber.TextChanged += contactNumber_TextChanged;
            // 
            // customTripRadioButton
            // 
            customTripRadioButton.AutoSize = true;
            customTripRadioButton.BackColor = Color.White;
            customTripRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            customTripRadioButton.Location = new Point(42, 549);
            customTripRadioButton.Margin = new Padding(4, 4, 4, 4);
            customTripRadioButton.Name = "customTripRadioButton";
            customTripRadioButton.Size = new Size(139, 29);
            customTripRadioButton.TabIndex = 7;
            customTripRadioButton.TabStop = true;
            customTripRadioButton.Text = "Custom Trip";
            customTripRadioButton.UseVisualStyleBackColor = false;
            customTripRadioButton.CheckedChanged += customTripRadioButton_CheckedChanged;
            // 
            // packageTripRadioButton
            // 
            packageTripRadioButton.AutoSize = true;
            packageTripRadioButton.BackColor = Color.White;
            packageTripRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            packageTripRadioButton.Location = new Point(296, 549);
            packageTripRadioButton.Margin = new Padding(4, 4, 4, 4);
            packageTripRadioButton.Name = "packageTripRadioButton";
            packageTripRadioButton.Size = new Size(146, 29);
            packageTripRadioButton.TabIndex = 8;
            packageTripRadioButton.TabStop = true;
            packageTripRadioButton.Text = "Package Trip";
            packageTripRadioButton.UseVisualStyleBackColor = false;
            packageTripRadioButton.CheckedChanged += packageTripRadioButton_CheckedChanged;
            // 
            // dayTripRadioButton
            // 
            dayTripRadioButton.AutoSize = true;
            dayTripRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dayTripRadioButton.Location = new Point(14, 50);
            dayTripRadioButton.Margin = new Padding(4, 4, 4, 4);
            dayTripRadioButton.Name = "dayTripRadioButton";
            dayTripRadioButton.Size = new Size(108, 29);
            dayTripRadioButton.TabIndex = 10;
            dayTripRadioButton.TabStop = true;
            dayTripRadioButton.Text = "Day Trip";
            dayTripRadioButton.UseVisualStyleBackColor = true;
            dayTripRadioButton.CheckedChanged += dayTripRadioButton_CheckedChanged;
            // 
            // nightTripRadioButton
            // 
            nightTripRadioButton.AutoSize = true;
            nightTripRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nightTripRadioButton.Location = new Point(14, 88);
            nightTripRadioButton.Margin = new Padding(4, 4, 4, 4);
            nightTripRadioButton.Name = "nightTripRadioButton";
            nightTripRadioButton.Size = new Size(123, 29);
            nightTripRadioButton.TabIndex = 11;
            nightTripRadioButton.TabStop = true;
            nightTripRadioButton.Text = "Night Trip";
            nightTripRadioButton.UseVisualStyleBackColor = true;
            nightTripRadioButton.CheckedChanged += nightTripRadioButton_CheckedChanged;
            // 
            // tripTimeGroupBox
            // 
            tripTimeGroupBox.BackColor = Color.White;
            tripTimeGroupBox.Controls.Add(dayTripRadioButton);
            tripTimeGroupBox.Controls.Add(nightTripRadioButton);
            tripTimeGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tripTimeGroupBox.Location = new Point(24, 721);
            tripTimeGroupBox.Margin = new Padding(4, 4, 4, 4);
            tripTimeGroupBox.Name = "tripTimeGroupBox";
            tripTimeGroupBox.Padding = new Padding(4, 4, 4, 4);
            tripTimeGroupBox.Size = new Size(209, 134);
            tripTimeGroupBox.TabIndex = 12;
            tripTimeGroupBox.TabStop = false;
            tripTimeGroupBox.Text = "Trip Time";
            tripTimeGroupBox.Enter += groupBox1_Enter;
            // 
            // culturalWorkShopTextBox
            // 
            culturalWorkShopTextBox.BackColor = Color.White;
            culturalWorkShopTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            culturalWorkShopTextBox.Location = new Point(1022, 375);
            culturalWorkShopTextBox.Margin = new Padding(4, 4, 4, 4);
            culturalWorkShopTextBox.Name = "culturalWorkShopTextBox";
            culturalWorkShopTextBox.ReadOnly = true;
            culturalWorkShopTextBox.Size = new Size(376, 31);
            culturalWorkShopTextBox.TabIndex = 13;
            culturalWorkShopTextBox.Text = "Cultural Workshop Cost: $0";
            culturalWorkShopTextBox.TextChanged += culturalWorkShopTextBox_TextChanged;
            // 
            // accommodationsCostTextBox
            // 
            accommodationsCostTextBox.BackColor = Color.White;
            accommodationsCostTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            accommodationsCostTextBox.Location = new Point(1022, 236);
            accommodationsCostTextBox.Margin = new Padding(4, 4, 4, 4);
            accommodationsCostTextBox.Name = "accommodationsCostTextBox";
            accommodationsCostTextBox.ReadOnly = true;
            accommodationsCostTextBox.Size = new Size(376, 31);
            accommodationsCostTextBox.TabIndex = 14;
            accommodationsCostTextBox.Text = "Accommodations Cost: $0";
            accommodationsCostTextBox.TextChanged += accommodationsCostTextBox_TextChanged;
            // 
            // baseCostTextBox
            // 
            baseCostTextBox.BackColor = Color.White;
            baseCostTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            baseCostTextBox.Location = new Point(1022, 110);
            baseCostTextBox.Margin = new Padding(4, 4, 4, 4);
            baseCostTextBox.Name = "baseCostTextBox";
            baseCostTextBox.ReadOnly = true;
            baseCostTextBox.Size = new Size(376, 31);
            baseCostTextBox.TabIndex = 15;
            baseCostTextBox.Text = "Base Cost:";
            baseCostTextBox.TextChanged += baseCostTextBox_TextChanged;
            // 
            // tripIDTextBox
            // 
            tripIDTextBox.BackColor = Color.White;
            tripIDTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tripIDTextBox.Location = new Point(1022, 41);
            tripIDTextBox.Margin = new Padding(4, 4, 4, 4);
            tripIDTextBox.Name = "tripIDTextBox";
            tripIDTextBox.ReadOnly = true;
            tripIDTextBox.Size = new Size(376, 31);
            tripIDTextBox.TabIndex = 16;
            tripIDTextBox.Text = "Trip ID: 1000";
            tripIDTextBox.TextChanged += tripIDTextBox_TextChanged;
            // 
            // accommodationscheckBox
            // 
            accommodationscheckBox.AutoSize = true;
            accommodationscheckBox.BackColor = Color.White;
            accommodationscheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            accommodationscheckBox.Location = new Point(1022, 178);
            accommodationscheckBox.Margin = new Padding(4, 4, 4, 4);
            accommodationscheckBox.Name = "accommodationscheckBox";
            accommodationscheckBox.Size = new Size(382, 29);
            accommodationscheckBox.TabIndex = 17;
            accommodationscheckBox.Text = "Accommodations: Hotel Room and Meal";
            accommodationscheckBox.UseVisualStyleBackColor = false;
            accommodationscheckBox.CheckedChanged += accommodationscheckBox_CheckedChanged;
            // 
            // personsTextBox
            // 
            personsTextBox.BackColor = Color.White;
            personsTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            personsTextBox.Location = new Point(1151, 301);
            personsTextBox.Margin = new Padding(4, 4, 4, 4);
            personsTextBox.Name = "personsTextBox";
            personsTextBox.ReadOnly = true;
            personsTextBox.Size = new Size(248, 31);
            personsTextBox.TabIndex = 18;
            personsTextBox.Text = "Persons";
            // 
            // bookTripButton
            // 
            bookTripButton.BackColor = Color.White;
            bookTripButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookTripButton.Location = new Point(702, 825);
            bookTripButton.Margin = new Padding(4, 4, 4, 4);
            bookTripButton.Name = "bookTripButton";
            bookTripButton.Size = new Size(144, 82);
            bookTripButton.TabIndex = 20;
            bookTripButton.Text = "Book Trip";
            bookTripButton.UseVisualStyleBackColor = false;
            bookTripButton.Click += bookTripButton_Click;
            // 
            // selectCountry
            // 
            selectCountry.AutoSize = true;
            selectCountry.BackColor = Color.White;
            selectCountry.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            selectCountry.Location = new Point(42, 12);
            selectCountry.Margin = new Padding(4, 0, 4, 0);
            selectCountry.Name = "selectCountry";
            selectCountry.Size = new Size(152, 25);
            selectCountry.TabIndex = 22;
            selectCountry.Text = "SELECT Country:";
            selectCountry.Click += selectCountry_Click;
            // 
            // selectDestination
            // 
            selectDestination.AutoSize = true;
            selectDestination.BackColor = Color.White;
            selectDestination.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            selectDestination.Location = new Point(282, 12);
            selectDestination.Margin = new Padding(4, 0, 4, 0);
            selectDestination.Name = "selectDestination";
            selectDestination.Size = new Size(181, 25);
            selectDestination.TabIndex = 23;
            selectDestination.Text = "SELECT Destination:";
            selectDestination.Click += selectDestination_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.White;
            numericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            numericUpDown1.Location = new Point(1022, 301);
            numericUpDown1.Margin = new Padding(4, 4, 4, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(121, 31);
            numericUpDown1.TabIndex = 24;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // destinationInfo
            // 
            destinationInfo.BackColor = Color.White;
            destinationInfo.Location = new Point(42, 110);
            destinationInfo.Margin = new Padding(4, 4, 4, 4);
            destinationInfo.Multiline = true;
            destinationInfo.Name = "destinationInfo";
            destinationInfo.Size = new Size(632, 268);
            destinationInfo.TabIndex = 25;
            destinationInfo.TextChanged += destinationInfo_TextChanged;
            // 
            // packageTripInfo
            // 
            packageTripInfo.BackColor = Color.White;
            packageTripInfo.Location = new Point(295, 586);
            packageTripInfo.Margin = new Padding(4, 4, 4, 4);
            packageTripInfo.Multiline = true;
            packageTripInfo.Name = "packageTripInfo";
            packageTripInfo.Size = new Size(550, 204);
            packageTripInfo.TabIndex = 26;
            packageTripInfo.TextChanged += packageTripInfo_TextChanged;
            // 
            // guidedCityTourcheckBox
            // 
            guidedCityTourcheckBox.AutoSize = true;
            guidedCityTourcheckBox.BackColor = Color.White;
            guidedCityTourcheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guidedCityTourcheckBox.Location = new Point(42, 586);
            guidedCityTourcheckBox.Margin = new Padding(4, 4, 4, 4);
            guidedCityTourcheckBox.Name = "guidedCityTourcheckBox";
            guidedCityTourcheckBox.Size = new Size(180, 29);
            guidedCityTourcheckBox.TabIndex = 27;
            guidedCityTourcheckBox.Text = "Guided City Tour";
            guidedCityTourcheckBox.UseVisualStyleBackColor = false;
            guidedCityTourcheckBox.CheckedChanged += guidedCityTourcheckBox_CheckedChanged;
            // 
            // museumVisitscheckBox
            // 
            museumVisitscheckBox.AutoSize = true;
            museumVisitscheckBox.BackColor = Color.White;
            museumVisitscheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            museumVisitscheckBox.Location = new Point(42, 624);
            museumVisitscheckBox.Margin = new Padding(4, 4, 4, 4);
            museumVisitscheckBox.Name = "museumVisitscheckBox";
            museumVisitscheckBox.Size = new Size(161, 29);
            museumVisitscheckBox.TabIndex = 28;
            museumVisitscheckBox.Text = "Museum Visits";
            museumVisitscheckBox.UseVisualStyleBackColor = false;
            museumVisitscheckBox.CheckedChanged += museumVisitscheckBox_CheckedChanged;
            // 
            // culturalWorkshopcheckBox
            // 
            culturalWorkshopcheckBox.AutoSize = true;
            culturalWorkshopcheckBox.BackColor = Color.White;
            culturalWorkshopcheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            culturalWorkshopcheckBox.Location = new Point(42, 661);
            culturalWorkshopcheckBox.Margin = new Padding(4, 4, 4, 4);
            culturalWorkshopcheckBox.Name = "culturalWorkshopcheckBox";
            culturalWorkshopcheckBox.Size = new Size(197, 29);
            culturalWorkshopcheckBox.TabIndex = 29;
            culturalWorkshopcheckBox.Text = "Cultural Workshop";
            culturalWorkshopcheckBox.UseVisualStyleBackColor = false;
            culturalWorkshopcheckBox.CheckedChanged += culturalWorkshopcheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1550, 952);
            Controls.Add(culturalWorkshopcheckBox);
            Controls.Add(museumVisitscheckBox);
            Controls.Add(guidedCityTourcheckBox);
            Controls.Add(packageTripInfo);
            Controls.Add(destinationInfo);
            Controls.Add(numericUpDown1);
            Controls.Add(selectDestination);
            Controls.Add(selectCountry);
            Controls.Add(bookTripButton);
            Controls.Add(customTripRadioButton);
            Controls.Add(packageTripRadioButton);
            Controls.Add(personsTextBox);
            Controls.Add(accommodationscheckBox);
            Controls.Add(tripIDTextBox);
            Controls.Add(baseCostTextBox);
            Controls.Add(accommodationsCostTextBox);
            Controls.Add(culturalWorkShopTextBox);
            Controls.Add(tripTimeGroupBox);
            Controls.Add(contactNumber);
            Controls.Add(nationality);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(selectDestinationComboBox);
            Controls.Add(selectCountryDropDown);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tripTimeGroupBox.ResumeLayout(false);
            tripTimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectCountryDropDown;
        private ComboBox selectDestinationComboBox;
        private TextBox firstName;
        private TextBox lastName;
        private TextBox nationality;
        private TextBox contactNumber;
        private RadioButton customTripRadioButton;
        private RadioButton packageTripRadioButton;
        private RadioButton dayTripRadioButton;
        private RadioButton nightTripRadioButton;
        private GroupBox tripTimeGroupBox;
        private TextBox culturalWorkShopTextBox;
        private TextBox accommodationsCostTextBox;
        private TextBox baseCostTextBox;
        private TextBox tripIDTextBox;
        private CheckBox accommodationscheckBox;
        private TextBox personsTextBox;
        private Button bookTripButton;
        private Label selectCountry;
        private Label selectDestination;
        private NumericUpDown numericUpDown1;
        private TextBox destinationInfo;
        private TextBox packageTripInfo;
        private CheckBox guidedCityTourcheckBox;
        private CheckBox museumVisitscheckBox;
        private CheckBox culturalWorkshopcheckBox;
    }
}
