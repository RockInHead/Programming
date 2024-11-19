namespace Events_OOP
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactTab1 = new Events_OOP.View.Tabs.ContactTab();
            this.SuspendLayout();
            // 
            // contactTab1
            // 
            this.contactTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactTab1.Location = new System.Drawing.Point(0, 0);
            this.contactTab1.Name = "contactTab1";
            this.contactTab1.Size = new System.Drawing.Size(374, 398);
            this.contactTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 398);
            this.Controls.Add(this.contactTab1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private View.Tabs.ContactTab contactTab1;
    }
}

