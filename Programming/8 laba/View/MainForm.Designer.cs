namespace _8_laba
{
    partial class MainForm
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
            FlightsListBox = new ListBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TypeOfFlightComboBox = new ComboBox();
            FlightTimeNumericUpDown = new NumericUpDown();
            label1 = new Label();
            DepartureDateTimePicker = new DateTimePicker();
            DestinationTextBox = new TextBox();
            DepartureTextBox = new TextBox();
            AddFlightButton = new Button();
            RemoveFlightButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FlightTimeNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // FlightsListBox
            // 
            FlightsListBox.FormattingEnabled = true;
            FlightsListBox.Location = new Point(12, 12);
            FlightsListBox.Name = "FlightsListBox";
            FlightsListBox.Size = new Size(307, 384);
            FlightsListBox.TabIndex = 0;
            FlightsListBox.SelectedIndexChanged += FlightsListBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TypeOfFlightComboBox);
            groupBox1.Controls.Add(FlightTimeNumericUpDown);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DepartureDateTimePicker);
            groupBox1.Controls.Add(DestinationTextBox);
            groupBox1.Controls.Add(DepartureTextBox);
            groupBox1.Location = new Point(325, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 302);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Flight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(9, 237);
            label5.Name = "label5";
            label5.Size = new Size(131, 28);
            label5.TabIndex = 9;
            label5.Text = "Type of flight:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(9, 186);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 8;
            label4.Text = "Flight Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 127);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 7;
            label3.Text = "Departure Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 6;
            label2.Text = "Destination:";
            // 
            // TypeOfFlightComboBox
            // 
            TypeOfFlightComboBox.FormattingEnabled = true;
            TypeOfFlightComboBox.Location = new Point(177, 241);
            TypeOfFlightComboBox.Name = "TypeOfFlightComboBox";
            TypeOfFlightComboBox.Size = new Size(186, 28);
            TypeOfFlightComboBox.TabIndex = 5;
            // 
            // FlightTimeNumericUpDown
            // 
            FlightTimeNumericUpDown.Location = new Point(177, 186);
            FlightTimeNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            FlightTimeNumericUpDown.Name = "FlightTimeNumericUpDown";
            FlightTimeNumericUpDown.Size = new Size(186, 27);
            FlightTimeNumericUpDown.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 3;
            label1.Text = "Departure:";
            // 
            // DepartureDateTimePicker
            // 
            DepartureDateTimePicker.DropDownAlign = LeftRightAlignment.Right;
            DepartureDateTimePicker.Location = new Point(177, 129);
            DepartureDateTimePicker.MinDate = new DateTime(2024, 4, 30, 13, 52, 13, 0);
            DepartureDateTimePicker.Name = "DepartureDateTimePicker";
            DepartureDateTimePicker.Size = new Size(186, 27);
            DepartureDateTimePicker.TabIndex = 2;
            DepartureDateTimePicker.Value = new DateTime(2024, 4, 30, 13, 52, 13, 0);
            DepartureDateTimePicker.ValueChanged += DepartureDateTimePicker_ValueChanged;
            // 
            // DestinationTextBox
            // 
            DestinationTextBox.Location = new Point(177, 80);
            DestinationTextBox.MaxLength = 100;
            DestinationTextBox.Name = "DestinationTextBox";
            DestinationTextBox.Size = new Size(186, 27);
            DestinationTextBox.TabIndex = 1;
            DestinationTextBox.TextChanged += DestinationTextBox_TextChanged;
            // 
            // DepartureTextBox
            // 
            DepartureTextBox.Location = new Point(177, 37);
            DepartureTextBox.MaxLength = 100;
            DepartureTextBox.Name = "DepartureTextBox";
            DepartureTextBox.Size = new Size(186, 27);
            DepartureTextBox.TabIndex = 0;
            DepartureTextBox.TextChanged += DepartureTextBox_TextChanged;
            // 
            // AddFlightButton
            // 
            AddFlightButton.Location = new Point(12, 418);
            AddFlightButton.Name = "AddFlightButton";
            AddFlightButton.Size = new Size(94, 29);
            AddFlightButton.TabIndex = 2;
            AddFlightButton.Text = "Добавить";
            AddFlightButton.UseVisualStyleBackColor = true;
            // 
            // RemoveFlightButton
            // 
            RemoveFlightButton.Location = new Point(137, 418);
            RemoveFlightButton.Name = "RemoveFlightButton";
            RemoveFlightButton.Size = new Size(94, 29);
            RemoveFlightButton.TabIndex = 3;
            RemoveFlightButton.Text = "Удалить";
            RemoveFlightButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 469);
            Controls.Add(RemoveFlightButton);
            Controls.Add(AddFlightButton);
            Controls.Add(groupBox1);
            Controls.Add(FlightsListBox);
            Name = "MainForm";
            Text = "Air Travels";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FlightTimeNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox FlightsListBox;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker DepartureDateTimePicker;
        private TextBox DestinationTextBox;
        private TextBox DepartureTextBox;
        private NumericUpDown FlightTimeNumericUpDown;
        private Label label2;
        private ComboBox TypeOfFlightComboBox;
        private Button AddFlightButton;
        private Button RemoveFlightButton;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
