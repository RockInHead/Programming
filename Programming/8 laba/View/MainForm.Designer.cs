﻿namespace _8_laba
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
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            AddFlightButton = new Button();
            RemoveFlightButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 384);
            listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(246, 12);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(177, 241);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 28);
            comboBox1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(177, 186);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(186, 27);
            numericUpDown1.TabIndex = 4;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(177, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(186, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 0;
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
            ClientSize = new Size(679, 469);
            Controls.Add(RemoveFlightButton);
            Controls.Add(AddFlightButton);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Name = "MainForm";
            Text = "Air Travels";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private ComboBox comboBox1;
        private Button AddFlightButton;
        private Button RemoveFlightButton;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}