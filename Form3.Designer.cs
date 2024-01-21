namespace TicketReservationSystem
{
    partial class Form3
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
            CardNumberTextBox = new TextBox();
            expiryDate = new TextBox();
            cvvTextBox = new TextBox();
            Pay = new Button();
            cardNumberLabel = new Label();
            expiryDateLabel = new Label();
            cvvLabel = new Label();
            SuspendLayout();
            // 
            // CardNumberTextBox
            // 
            CardNumberTextBox.Location = new Point(309, 41);
            CardNumberTextBox.Name = "CardNumberTextBox";
            CardNumberTextBox.Size = new Size(316, 27);
            CardNumberTextBox.TabIndex = 0;
            // 
            // expiryDate
            // 
            expiryDate.Location = new Point(309, 112);
            expiryDate.Name = "expiryDate";
            expiryDate.Size = new Size(316, 27);
            expiryDate.TabIndex = 1;
            // 
            // cvvTextBox
            // 
            cvvTextBox.Location = new Point(309, 197);
            cvvTextBox.Name = "cvvTextBox";
            cvvTextBox.Size = new Size(316, 27);
            cvvTextBox.TabIndex = 2;
            // 
            // Pay
            // 
            Pay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pay.Location = new Point(309, 292);
            Pay.Name = "Pay";
            Pay.Size = new Size(107, 73);
            Pay.TabIndex = 3;
            Pay.Text = "Pay";
            Pay.UseVisualStyleBackColor = true;
            Pay.Click += Pay_Click;
            // 
            // cardNumberLabel
            // 
            cardNumberLabel.AutoSize = true;
            cardNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardNumberLabel.Location = new Point(142, 41);
            cardNumberLabel.Name = "cardNumberLabel";
            cardNumberLabel.Size = new Size(108, 20);
            cardNumberLabel.TabIndex = 4;
            cardNumberLabel.Text = "Card Number:";
            // 
            // expiryDateLabel
            // 
            expiryDateLabel.AutoSize = true;
            expiryDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expiryDateLabel.Location = new Point(142, 115);
            expiryDateLabel.Name = "expiryDateLabel";
            expiryDateLabel.Size = new Size(163, 20);
            expiryDateLabel.TabIndex = 5;
            expiryDateLabel.Text = "Expiry Date (MM/YY):";
            // 
            // cvvLabel
            // 
            cvvLabel.AutoSize = true;
            cvvLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cvvLabel.Location = new Point(142, 197);
            cvvLabel.Name = "cvvLabel";
            cvvLabel.Size = new Size(42, 20);
            cvvLabel.TabIndex = 6;
            cvvLabel.Text = "CVV:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cvvLabel);
            Controls.Add(expiryDateLabel);
            Controls.Add(cardNumberLabel);
            Controls.Add(Pay);
            Controls.Add(cvvTextBox);
            Controls.Add(expiryDate);
            Controls.Add(CardNumberTextBox);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CardNumberTextBox;
        private TextBox expiryDate;
        private TextBox cvvTextBox;
        private Button Pay;
        private Label cardNumberLabel;
        private Label expiryDateLabel;
        private Label cvvLabel;
    }
}