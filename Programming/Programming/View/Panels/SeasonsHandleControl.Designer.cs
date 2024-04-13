namespace Programming.View.Panels
{
    partial class SeasonsHandleControl
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
            GroupBoxSeasonHandle = new GroupBox();
            SeasonComboBox = new ComboBox();
            SeasonButton = new Button();
            label5 = new Label();
            GroupBoxSeasonHandle.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxSeasonHandle
            // 
            GroupBoxSeasonHandle.Controls.Add(SeasonComboBox);
            GroupBoxSeasonHandle.Controls.Add(SeasonButton);
            GroupBoxSeasonHandle.Controls.Add(label5);
            GroupBoxSeasonHandle.Location = new Point(3, 3);
            GroupBoxSeasonHandle.Name = "GroupBoxSeasonHandle";
            GroupBoxSeasonHandle.Size = new Size(363, 180);
            GroupBoxSeasonHandle.TabIndex = 6;
            GroupBoxSeasonHandle.TabStop = false;
            GroupBoxSeasonHandle.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(6, 57);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(222, 28);
            SeasonComboBox.TabIndex = 2;
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(240, 55);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(107, 29);
            SeasonButton.TabIndex = 1;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 34);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 0;
            label5.Text = "Choose season: ";
            // 
            // SeasonsHandleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupBoxSeasonHandle);
            Name = "SeasonsHandleControl";
            Size = new Size(375, 190);
            GroupBoxSeasonHandle.ResumeLayout(false);
            GroupBoxSeasonHandle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxSeasonHandle;
        private ComboBox SeasonComboBox;
        private Button SeasonButton;
        private Label label5;
    }
}
