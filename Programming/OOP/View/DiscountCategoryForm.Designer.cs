namespace OOP.View
{
    partial class DiscountCategoryForm
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
            label1 = new Label();
            DiscountCategoryComboBox = new ComboBox();
            label2 = new Label();
            OkButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 0;
            label1.Text = "Percent Discount:";
            // 
            // DiscountCategoryComboBox
            // 
            DiscountCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DiscountCategoryComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DiscountCategoryComboBox.FormattingEnabled = true;
            DiscountCategoryComboBox.Location = new Point(121, 48);
            DiscountCategoryComboBox.Name = "DiscountCategoryComboBox";
            DiscountCategoryComboBox.Size = new Size(388, 36);
            DiscountCategoryComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 2;
            label2.Text = "Category:";
            // 
            // OkButton
            // 
            OkButton.Location = new Point(258, 110);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(125, 45);
            OkButton.TabIndex = 3;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(389, 110);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(110, 45);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // DiscountCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 173);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(label2);
            Controls.Add(DiscountCategoryComboBox);
            Controls.Add(label1);
            MaximumSize = new Size(540, 220);
            Name = "DiscountCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiscountCategory";
            Load += DiscountCategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox DiscountCategoryComboBox;
        private Label label2;
        private Button OkButton;
        private Button CancelButton;
    }
}