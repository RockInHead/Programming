namespace EventsPractics
{
    partial class MainWindow
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
            CloseButton = new Button();
            ContactControlPanel = new Panel();
            AddressTextBox = new TextBox();
            PhoneNumberTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            AddressLabel = new Label();
            PhoneNumberLabel = new Label();
            FullNameLabel = new Label();
            ContactControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseButton.Location = new Point(236, 222);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 29);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ContactControlPanel
            // 
            ContactControlPanel.Controls.Add(CloseButton);
            ContactControlPanel.Controls.Add(AddressTextBox);
            ContactControlPanel.Controls.Add(PhoneNumberTextBox);
            ContactControlPanel.Controls.Add(FullNameTextBox);
            ContactControlPanel.Controls.Add(AddressLabel);
            ContactControlPanel.Controls.Add(PhoneNumberLabel);
            ContactControlPanel.Controls.Add(FullNameLabel);
            ContactControlPanel.Dock = DockStyle.Fill;
            ContactControlPanel.Location = new Point(0, 0);
            ContactControlPanel.Name = "ContactControlPanel";
            ContactControlPanel.Size = new Size(342, 263);
            ContactControlPanel.TabIndex = 1;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressTextBox.Location = new Point(12, 156);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(318, 27);
            AddressTextBox.TabIndex = 5;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PhoneNumberTextBox.Location = new Point(12, 96);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(318, 27);
            PhoneNumberTextBox.TabIndex = 4;
            PhoneNumberTextBox.TextChanged += PhoneNumberTextBox_TextChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(12, 36);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(318, 27);
            FullNameTextBox.TabIndex = 3;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(12, 133);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(65, 20);
            AddressLabel.TabIndex = 2;
            AddressLabel.Text = "Address:";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(12, 73);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(111, 20);
            PhoneNumberLabel.TabIndex = 1;
            PhoneNumberLabel.Text = "Phone Number:";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(12, 13);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(79, 20);
            FullNameLabel.TabIndex = 0;
            FullNameLabel.Text = "Full Name:";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 263);
            Controls.Add(ContactControlPanel);
            Name = "MainWindow";
            Text = "MainWindow";
            FormClosing += MainWindow_FormClosing;
            ContactControlPanel.ResumeLayout(false);
            ContactControlPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private Panel ContactControlPanel;
        private TextBox AddressTextBox;
        private TextBox PhoneNumberTextBox;
        private TextBox FullNameTextBox;
        private Label AddressLabel;
        private Label PhoneNumberLabel;
        private Label FullNameLabel;
    }
}
