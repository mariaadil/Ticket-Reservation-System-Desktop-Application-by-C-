using System.Data.SqlClient;
namespace TicketReservationSystem
{
    public partial class Form1 : Form
    {
        private int tripID = 1000; // Initialize tripID
        double baseCost = 0;
        private int accommodationCost = 0, culturalWorkshopCost = 0;
        private double totalCost = 0;
        private int selectedNumberOfPeople = 1;

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Laptop House\Desktop\Fatima Shehzadi\TicketReservationSystem\Customers.mdf"";Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            culturalWorkshopcheckBox.Enabled = false;
            guidedCityTourcheckBox.Enabled = false;
            museumVisitscheckBox.Enabled = false;

            InitializeTextBoxEvents();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void selectDestination_Click(object sender, EventArgs e)
        {

        }

        private void selectCountryDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear previous items in the destination ComboBox
            selectDestinationComboBox.Items.Clear();

            // Get the selected country
            string selectedCountry = selectCountryDropDown.SelectedItem.ToString();

            // Populate the destination ComboBox based on the selected country
            switch (selectedCountry)
            {
                case "Thailand":
                    selectDestinationComboBox.Items.AddRange(new object[] { "The Grand Palace", "King Power Mahanakhon Sky Walk" });
                    destinationInfo.Clear();
                    packageTripInfo.Clear();
                    break;
                case "Malaysia":
                    selectDestinationComboBox.Items.AddRange(new object[] { "Petronas Twin Towers", "Langkawi" });
                    destinationInfo.Clear();
                    packageTripInfo.Clear();
                    break;
                case "Egypt":
                    selectDestinationComboBox.Items.AddRange(new object[] { "Luxor", "Giza and Sphinx" });
                    destinationInfo.Clear();
                    packageTripInfo.Clear();
                    break;
                case "Saudi Arabia":
                    selectDestinationComboBox.Items.AddRange(new object[] { "Hegra", "Al-Ula" });
                    destinationInfo.Clear();
                    packageTripInfo.Clear();
                    break;

                default:
                    destinationInfo.Clear();
                    packageTripInfo.Clear();
                    break;
            }
        }

        private void selectDestinationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Increment tripID when a different destination is selected
            tripID++;

            // Display tripID in tripIDTextBox
            tripIDTextBox.Text = "Trip ID: " + tripID;

            string selectedDestination = selectDestinationComboBox.SelectedItem?.ToString();

            // Clear previous text in the destinationInfo TextBox
            destinationInfo.Clear();

            // Call the method to set the background image
            SetBackgroundImage(selectedDestination);

            switch (selectedDestination)
            {
                case "The Grand Palace":
                    DisplayDestinationInfo("The Grand Palace", "9:00 AM - 5:00 PM", "Na Phra Lan Rd, Phra Borom Maha Ratchwang, Phra Nakhon, Bangkok 10200, Thailand", "+66 2 623 5500", "Beautiful historic site. Highly recommended!");
                    baseCost = 15;
                    baseCostTextBox.Text = "Base Cost: " + baseCost;
                    break;
                case "King Power Mahanakhon Sky Walk":
                    DisplayDestinationInfo("King Power Mahanakhon Skywalk", "10:00 AM - 12:00 PM", "114 Narathiwas Rd, Khwaeng Silom, Khet Bang Rak, Krung Thep Maha Nakhon 10500, Thailand", "+66 2 677 8721", "Amazing views of Bangkok, A must-visit spot");
                    baseCost = 68;
                    baseCostTextBox.Text = "Base Cost: " + baseCost;
                    break;
                case "Petronas Twin Towers":
                    DisplayDestinationInfo("Petronas Twin Towers", "9:00 AM - 21:00 PM", "Petronas Twin Tower, Lower Ground (Concourse) Level, Kuala Lumpur City Centre, 50088 Kuala Lumpur, Malaysia", "+603 2331 8080", "An important symbol of Malaysia, it was the tallest structure in the world with the height of 652m");
                    baseCost = 11.37;
                    baseCostTextBox.Text = "Base Cost: " + baseCost;
                    break;
                case "Langkawi":
                    DisplayDestinationInfo("Langkawi", "9:00 AM", "Langkawi Island Malaysia", "+1 (702) 648-5837", "Fun half day - you will enjoy the experience! Pick up from the hotel and visited 3 different islands to Langkawi");
                    baseCost = 10.37;
                    baseCostTextBox.Text = "Base Cost: " + baseCost;
                    break;
                case "Luxor":
                    DisplayDestinationInfo("Luxor", "6:00 AM - 22:00 PM", "Luxor City, Luxor, Luxor Governorate 1362501, Egypt", "+1 (702) 648-5873", "It's a great experience, the guide named Susi, very nice person, and gave me a lot of advice and information about the temples. Everything is perfect.");
                    baseCost = 25.65;
                    baseCostTextBox.Text = "Base Cost: " + baseCost;
                    break;
                case "Giza and Sphinx":
                    DisplayDestinationInfo("Giza and Sphinx", "8:00 AM - 17:00 PM", "Al Giza Desert, Giza Governorate", "+20-2-25908931", "We then went to Abu al-Hol to see the Great Sphinx in all its glory and splendor. It was erected to guard the tombs and ward off enemies of the Pharaohs and tomb raiders.");
                    baseCost = 38;
                    baseCostTextBox.Text = "Base Cost: " + baseCost;
                    break;
                case "Hegra":
                    DisplayDestinationInfo("Hegra", "09:00 AM - 05:00 PM", "Al Madinah Region, Al-Hijaz, Saudi Arabia", "+66 2 623 5500", "Nature is gorgeous and the richness of the remains of the ancient civilization are so special!!");
                    baseCost = 380;
                    baseCostTextBox.Text = "Base Cost: " + baseCost;
                    break;
                case "Al-Ula":
                    DisplayDestinationInfo("Al-Ula", "16:30 - 1:00 AM", "375, AlUla 43562, Saudi Arabia", "+966 9200 25003", "Al Ula is the old city. The city combines the grand natural rocks and very nice scenery. There are many places that you can visit while you are here. Madain Saleh, elephant rocks, hot air balloons, and others. You must come here and get a new atmosphere");
                    baseCost = 10;
                    baseCostTextBox.Text = "Base Cost: " + baseCost;
                    break;
                default:
                    baseCost = 0;
                    baseCostTextBox.Text = "Base Cost: " + baseCost;
                    break;
            }

        }

        private void SetBackgroundImage(string destination)
        {
            try
            {
                // Check if the destination is not selected (null or empty)
                if (string.IsNullOrEmpty(destination))
                {
                    // Set the default background image
                    this.BackgroundImage = Image.FromFile("pics\\bg2.jpg");
                }
                else
                {
                    // Set the background image based on the selected destination
                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"pics\\{destination}.jpg");
                    this.BackgroundImage = Image.FromFile(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image for destination '{destination}': {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // Helper method to display destination information in the destinationInfo TextBox
        private void DisplayDestinationInfo(string name, string openingTime, string address, string phoneNumber, string reviews)
        {
            destinationInfo.AppendText($"Name: {name}\r\n");
            destinationInfo.AppendText($"Opening Time: {openingTime}\r\n");
            destinationInfo.AppendText($"Address: {address}\r\n");
            destinationInfo.AppendText($"Phone Number: {phoneNumber}\r\n");
            destinationInfo.AppendText($"Reviews: {reviews}\r\n");

            if (packageTripRadioButton.Checked)
            {
                packageTripInfo.AppendText("Package Name: Easy Package \r\nIncluded Activities: Guided City Tour, Museum Visit\r\n");
                packageTripInfo.AppendText($"Name: {name}\r\n");
                packageTripInfo.AppendText($"Opening Time: {openingTime}\r\n");
                packageTripInfo.AppendText($"Address: {address}\r\n");
                packageTripInfo.AppendText($"Phone Number: {phoneNumber}\r\n");
            }
        }

        private void DisplayDestinationInfo(string name, string openingTime, string address, string phoneNumber)
        {
            packageTripInfo.AppendText($"Name: {name}\r\n");
            packageTripInfo.AppendText($"Opening Time: {openingTime}\r\n");
            packageTripInfo.AppendText($"Address: {address}\r\n");
            packageTripInfo.AppendText($"Phone Number: {phoneNumber}\r\n");
        }

        private void packageTripInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void destinationInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void culturalWorkShopTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void culturalWorkshopcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the culturalWorkshopcheckBox is checked
            if (culturalWorkshopcheckBox.Checked)
            {
                // Set the text for the culturalWorkShopTextBox when checked
                culturalWorkShopTextBox.Text = "Cultural Workshop Cost: $20";
                culturalWorkshopCost = 20;
            }
            else
            {
                // Set a different text when unchecked
                culturalWorkShopTextBox.Text = "Cultural Workshop Cost: $0";
                culturalWorkshopCost = 0;
            }
        }

        private void customTripRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the customTripRadioButton is checked
            if (customTripRadioButton.Checked)
            {
                // Enable the checkboxes for custom trip options
                culturalWorkshopcheckBox.Enabled = true;
                guidedCityTourcheckBox.Enabled = true;
                museumVisitscheckBox.Enabled = true;
            }
            else
            {
                // If customTripRadioButton is not checked, disable the checkboxes
                culturalWorkshopcheckBox.Enabled = false;
                guidedCityTourcheckBox.Enabled = false;
                museumVisitscheckBox.Enabled = false;

                // Uncheck the checkboxes
                culturalWorkshopcheckBox.Checked = false;
                guidedCityTourcheckBox.Checked = false;
                museumVisitscheckBox.Checked = false;

            }
        }

        private void guidedCityTourcheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void museumVisitscheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void packageTripRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (packageTripRadioButton.Checked)
            {
                // Set package trip information in packageTripInfo TextBox
                packageTripInfo.AppendText("Package Name: Easy Package \r\nIncluded Activities: Guided City Tour, Museum Visit\r\n");

                // Set destination details based on the selected destination
                string selectedDestination = selectDestinationComboBox.SelectedItem?.ToString();
                switch (selectedDestination)
                {
                    case "The Grand Palace":
                        DisplayDestinationInfo("The Grand Palace", "9:00 AM - 5:00 PM", "Na Phra Lan Rd, Phra Borom Maha Ratchwang, Phra Nakhon, Bangkok 10200, Thailand", "+66 2 623 5500");
                        break;
                    case "King Power Mahanakhon Sky Walk":
                        DisplayDestinationInfo("King Power Mahanakhon Skywalk", "10:00 AM - 12:00 PM", "114 Narathiwas Rd, Khwaeng Silom, Khet Bang Rak, Krung Thep Maha Nakhon 10500, Thailand", "+66 2 677 8721");
                        break;
                    case "Petronas Twin Towers":
                        DisplayDestinationInfo("Petronas Twin Towers", "9:00 AM - 21:00 PM", "Petronas Twin Tower, Lower Ground (Concourse) Level, Kuala Lumpur City Centre, 50088 Kuala Lumpur, Malaysia", "+603 2331 8080");
                        break;
                    case "Langkawi":
                        DisplayDestinationInfo("Langkawi", "9:00 AM", "Langkawi Island Malaysia", "+1 (702) 648-5837");
                        break;
                    case "Luxor":
                        DisplayDestinationInfo("Luxor", "6:00 AM - 22:00 PM", "Luxor City, Luxor, Luxor Governorate 1362501, Egypt", "+1 (702) 648-5873");
                        break;
                    case "Giza and Sphinx":
                        DisplayDestinationInfo("Giza and Sphinx", "8:00 AM - 17:00 PM", "Al Giza Desert, Giza Governorate", "+20-2-25908931");
                        break;
                    case "Hegra":
                        DisplayDestinationInfo("Hegra", "09:00 AM - 05:00 PM", "Al Madinah Region, Al-Hijaz, Saudi Arabia", "+66 2 623 5500");
                        break;
                    case "Al-Ula":
                        DisplayDestinationInfo("Al-Ula", "16:30 - 1:00 AM", "375, AlUla 43562, Saudi Arabia", "+966 9200 25003");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                // Clear the packageTripInfo TextBox if packageTripRadioButton is not checked
                packageTripInfo.Clear();
            }
        }

        private void tripIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void accommodationsCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void accommodationscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the accommodationscheckBox is checked
            if (accommodationscheckBox.Checked)
            {
                // Set the text for the accommodationsCostTextBox when checked
                accommodationsCostTextBox.Text = "Accommodations Cost: $500";
                accommodationCost = 500;
            }
            else
            {
                // Set a different text when unchecked
                accommodationsCostTextBox.Text = "Accommodations Cost: $0";
                accommodationCost = 0;
            }
        }

        private void baseCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookTripButton_Click(object sender, EventArgs e)
        {
            // Check if a country is selected
            if (selectCountryDropDown.SelectedItem == null)
            {
                MessageBox.Show("Please select a country first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if a destination is selected
            if (selectDestinationComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a destination first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if first name is entered
            if (string.IsNullOrWhiteSpace(firstName.Text) || firstName.Text == firstName.Tag.ToString())
            {
                MessageBox.Show("Please enter your first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further processing
            }

            // Check if last name is entered
            if (string.IsNullOrWhiteSpace(lastName.Text) || lastName.Text == lastName.Tag.ToString())
            {
                MessageBox.Show("Please enter your last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further processing
            }

            // Check if nationality is entered
            if (string.IsNullOrWhiteSpace(nationality.Text) || nationality.Text == nationality.Tag.ToString())
            {
                MessageBox.Show("Please enter your nationality.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further processing
            }

            if (string.IsNullOrWhiteSpace(contactNumber.Text) || contactNumber.Text == contactNumber.Tag.ToString() || contactNumber.Text.Length != 11 || !contactNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 11-digit contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further processing
            }

            // Check if either custom or package trip is selected
            if (!customTripRadioButton.Checked && !packageTripRadioButton.Checked)
            {
                MessageBox.Show("Please select either Custom Trip or Package Trip.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further processing
            }

            // If custom trip is selected, check if at least one checkbox is selected
            if (customTripRadioButton.Checked && !culturalWorkshopcheckBox.Checked && !guidedCityTourcheckBox.Checked && !museumVisitscheckBox.Checked)
            {
                MessageBox.Show("Please select at least one option for a custom trip.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further processing
            }

            // Check if a trip time is selected (either day or night)
            if (!dayTripRadioButton.Checked && !nightTripRadioButton.Checked)
            {
                MessageBox.Show("Please select a trip time (Day or Night).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further processing
            }

            totalCost = (baseCost + accommodationCost + culturalWorkshopCost) * selectedNumberOfPeople;

            /*Con.Open();
            string query = "INSERT INTO CustomersTable (FirstName, LastName, Nationality, ContactNumber, Destination, TripType, SessionTime, TotalCost) " +
               "VALUES (@FirstName, @LastName, @Nationality, @ContactNumber, @Destination, @TripType, @SessionTime, @TotalCost)";

            SqlCommand cmd = new SqlCommand(query, Con);

            // Set parameter values
            cmd.Parameters.AddWithValue("@FirstName", firstName.Text);
            cmd.Parameters.AddWithValue("@LastName", lastName.Text);
            cmd.Parameters.AddWithValue("@Nationality", nationality.Text);
            cmd.Parameters.AddWithValue("@ContactNumber", contactNumber.Text);
            cmd.Parameters.AddWithValue("@Destination", selectDestinationComboBox.SelectedItem?.ToString());
            cmd.Parameters.AddWithValue("@TripType", customTripRadioButton.Checked ? "Custom Trip" : "Package Trip");
            cmd.Parameters.AddWithValue("@SessionTime", dayTripRadioButton.Checked ? "Day" : "Night");
            cmd.Parameters.AddWithValue("@TotalCost", totalCost);

            cmd.ExecuteNonQuery();

            Con.Close();*/

            // Retrieve data for the confirmation form
            //  Retrieve data for the confirmation form
            string confirmationData = $"Name: {firstName.Text} {lastName.Text}" + Environment.NewLine + Environment.NewLine +
            $"Nationality: {nationality.Text}" + Environment.NewLine + Environment.NewLine + $"Contact Number: {contactNumber.Text}" + Environment.NewLine +
            Environment.NewLine + $"Destination: {selectDestinationComboBox.SelectedItem}" + Environment.NewLine + Environment.NewLine + $"Trip Type: {(customTripRadioButton.Checked ?
            "Custom Trip" : "Package Trip")}" + Environment.NewLine + Environment.NewLine + $"Session Time: {(dayTripRadioButton.Checked ? "Day" : "Night")}";

            // Create an instance of Form2 and pass data
            Form2 form2 = new Form2(confirmationData, totalCost);
            form2.Show();
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void nationality_TextChanged(object sender, EventArgs e)
        {
        }

        private void contactNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Clear default text and set color to black when the user starts typing
            if (textBox.Text == "First Name" || textBox.Text == "Last Name" || textBox.Text == "Nationality" || textBox.Text == "Contact Number")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Check if the text is empty and set it back to the default text
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = Color.Gray;
                if (textBox.Tag != null)
                {
                    textBox.Text = textBox.Tag.ToString();
                }
            }
        }


        // Attach event handlers to the text boxes
        private void InitializeTextBoxEvents()
        {
            firstName.Enter += TextBox_Enter;
            firstName.Leave += TextBox_Leave;
            firstName.Tag = "First Name";

            lastName.Enter += TextBox_Enter;
            lastName.Leave += TextBox_Leave;
            lastName.Tag = "Last Name";

            nationality.Enter += TextBox_Enter;
            nationality.Leave += TextBox_Leave;
            nationality.Tag = "Nationality";

            contactNumber.Enter += TextBox_Enter;
            contactNumber.Leave += TextBox_Leave;
            contactNumber.Tag = "Contact Number";
        }

        private void dayTripRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nightTripRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            selectedNumberOfPeople = (int)numericUpDown1.Value;
        }

        private void selectCountry_Click(object sender, EventArgs e)
        {

        }
    }
}
