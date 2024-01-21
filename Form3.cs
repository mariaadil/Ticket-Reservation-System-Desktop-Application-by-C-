using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservationSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
        private void Pay_Click(object sender, EventArgs e)
        {
            // Example: Validate that the card number is a valid number
            if (string.IsNullOrWhiteSpace(CardNumberTextBox.Text) || !IsNumericLong(CardNumberTextBox.Text) || CardNumberTextBox.Text.Length != 16)
            {
                MessageBox.Show("Please enter a valid 16-digit card number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Example: Validate that the expiry date is in a valid format
            if (string.IsNullOrWhiteSpace(expiryDate.Text) || !IsValidExpiryDate(expiryDate.Text))
            {
                MessageBox.Show("Please enter a valid expiry date (MM/YY).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Example: Validate that the CVV is a valid number with a specific length
            if (string.IsNullOrWhiteSpace(cvvTextBox.Text) || !IsNumeric(cvvTextBox.Text) || cvvTextBox.Text.Length != 3)
            {
                MessageBox.Show("Please enter a valid 3-digit CVV.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }
        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }
        private bool IsNumericLong(string value)
        {
            return long.TryParse(value, out _);
        }

        private bool IsValidExpiryDate(string value)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^(0[1-9]|1[0-2])\/\d{2}$"))
            {
                return false;
            }

            // Extract month and year from the input
            string[] dateParts = value.Split('/');
            int month = int.Parse(dateParts[0]);
            int year = int.Parse(dateParts[1]) + 2000; // Assuming years are in the range 00-99

            // Calculate the maximum allowed year (5 years from the current year)
            int maxAllowedYear = DateTime.Now.Year + 5;

            // Check if the year is within the allowed range
            if (year < DateTime.Now.Year || (year == DateTime.Now.Year && month < DateTime.Now.Month))
            {
                return false;
            }

            return year <= maxAllowedYear;
        }
    }
}
