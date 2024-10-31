namespace OOP.View.Tabs
{
    partial class DiscountsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(55, 28);
            label1.TabIndex = 0;
            label1.Text = "Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(64, 12);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 1;
            label2.Text = "text";
            // 
            // button1
            // 
            button1.Location = new Point(3, 65);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 2;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(127, 65);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 3;
            button2.Text = "Apply";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(254, 65);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 4;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 134);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 5;
            label3.Text = "Общая стоимость:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(201, 134);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 6;
            label4.Text = "text";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 192);
            label5.Name = "label5";
            label5.Size = new Size(331, 28);
            label5.TabIndex = 7;
            label5.Text = "Общая стоимость после скидки:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(340, 192);
            label6.Name = "label6";
            label6.Size = new Size(50, 28);
            label6.TabIndex = 8;
            label6.Text = "text";
            // 
            // DiscountsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DiscountsTab";
            Size = new Size(547, 300);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
