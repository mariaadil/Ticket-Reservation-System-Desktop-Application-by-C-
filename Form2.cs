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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Form2(string confirmationData, double totalCost)
        {
            InitializeComponent();

            // Set the text in BookingConfirmationTextBox
            BookingConfirmationTextBox.Text = confirmationData;

            // Set the text in totalAmountTextBox
            totalAmountTextBox.Text = totalCost.ToString("C");
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            // Create an instance of Form3
            Form3 form3 = new Form3();

            // Show Form3
            form3.Show();

            // Close Form2
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
