namespace TicketReservationSystem
{
    partial class Form2
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
            totalAmountTextBox = new TextBox();
            payButton = new Button();
            cancelButton = new Button();
            BookingConfirmationTextBox = new TextBox();
            BookingConfirmationLabel = new Label();
            SuspendLayout();
            // 
            // totalAmountTextBox
            // 
            totalAmountTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmountTextBox.Location = new Point(40, 331);
            totalAmountTextBox.Name = "totalAmountTextBox";
            totalAmountTextBox.ReadOnly = true;
            totalAmountTextBox.Size = new Size(216, 27);
            totalAmountTextBox.TabIndex = 1;
            // 
            // payButton
            // 
            payButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payButton.Location = new Point(265, 365);
            payButton.Name = "payButton";
            payButton.Size = new Size(107, 55);
            payButton.TabIndex = 2;
            payButton.Text = "Pay";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(415, 365);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(107, 55);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // BookingConfirmationTextBox
            // 
            BookingConfirmationTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookingConfirmationTextBox.Location = new Point(40, 70);
            BookingConfirmationTextBox.Multiline = true;
            BookingConfirmationTextBox.Name = "BookingConfirmationTextBox";
            BookingConfirmationTextBox.ReadOnly = true;
            BookingConfirmationTextBox.Size = new Size(728, 245);
            BookingConfirmationTextBox.TabIndex = 4;
            // 
            // BookingConfirmationLabel
            // 
            BookingConfirmationLabel.AutoSize = true;
            BookingConfirmationLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookingConfirmationLabel.Location = new Point(31, 29);
            BookingConfirmationLabel.Name = "BookingConfirmationLabel";
            BookingConfirmationLabel.Size = new Size(318, 38);
            BookingConfirmationLabel.TabIndex = 5;
            BookingConfirmationLabel.Text = "Booking Confirmation:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BookingConfirmationLabel);
            Controls.Add(BookingConfirmationTextBox);
            Controls.Add(cancelButton);
            Controls.Add(payButton);
            Controls.Add(totalAmountTextBox);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox totalAmountTextBox;
        private Button payButton;
        private Button cancelButton;
        private TextBox BookingConfirmationTextBox;
        private Label BookingConfirmationLabel;
    }
}