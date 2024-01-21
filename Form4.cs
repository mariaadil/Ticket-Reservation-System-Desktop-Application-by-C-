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
    public partial class Form4 : Form
    {
        public bool OkButtonClicked;

        public Form4()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Set the flag to true when the OK button is clicked
            OkButtonClicked = true;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
