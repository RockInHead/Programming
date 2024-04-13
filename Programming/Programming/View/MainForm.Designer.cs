namespace Programming
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
            tabPage2 = new TabPage();
            filmsPropertiesControl1 = new View.Panels.FilmsPropertiesControl();
            rectanglesPropertiesControl1 = new View.Panels.RectanglesPropertiesControl();
            tabPage1 = new TabPage();
            weekdayParsingControl1 = new View.Panels.WeekdayParsingControl();
            enumerationsControl1 = new View.Panels.EnumerationsControl();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            seasonsHandleControl1 = new View.Panels.SeasonsHandleControl();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(filmsPropertiesControl1);
            tabPage2.Controls.Add(rectanglesPropertiesControl1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1024, 582);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Сlasses";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // filmsPropertiesControl1
            // 
            filmsPropertiesControl1.Location = new Point(562, 3);
            filmsPropertiesControl1.Name = "filmsPropertiesControl1";
            filmsPropertiesControl1.Size = new Size(368, 416);
            filmsPropertiesControl1.TabIndex = 4;
            // 
            // rectanglesPropertiesControl1
            // 
            rectanglesPropertiesControl1.Location = new Point(0, 6);
            rectanglesPropertiesControl1.Name = "rectanglesPropertiesControl1";
            rectanglesPropertiesControl1.Size = new Size(560, 402);
            rectanglesPropertiesControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(seasonsHandleControl1);
            tabPage1.Controls.Add(weekdayParsingControl1);
            tabPage1.Controls.Add(enumerationsControl1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1024, 582);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // weekdayParsingControl1
            // 
            weekdayParsingControl1.Location = new Point(0, 339);
            weekdayParsingControl1.Name = "weekdayParsingControl1";
            weekdayParsingControl1.Size = new Size(485, 189);
            weekdayParsingControl1.TabIndex = 7;
            // 
            // enumerationsControl1
            // 
            enumerationsControl1.Location = new Point(-4, 0);
            enumerationsControl1.Name = "enumerationsControl1";
            enumerationsControl1.Size = new Size(853, 342);
            enumerationsControl1.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1032, 615);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(rectanglesCollisionControl1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1024, 582);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rectangles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(1018, 576);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // seasonsHandleControl1
            // 
            seasonsHandleControl1.Location = new Point(491, 348);
            seasonsHandleControl1.Name = "seasonsHandleControl1";
            seasonsHandleControl1.Size = new Size(370, 180);
            seasonsHandleControl1.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 615);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.RectanglesPropertiesControl rectanglesPropertiesControl1;
        private View.Panels.FilmsPropertiesControl filmsPropertiesControl1;
        private View.Panels.EnumerationsControl enumerationsControl1;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonsHandleControl seasonsHandleControl1;
    }
}
