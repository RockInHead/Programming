using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectanglesPropertiesControl : UserControl
    {
        //Поля прямоугольника
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;
        private string[] RectangleListBoxItems = new string[5];
        private string[] RectangleColor = new string[6] { "Black", "White", "Orange", "Purple", "Green", "Blue" };

        Random _random = new Random();

        public void RectangleInitiaziation()
        {
            for (int i = 0; i < 5; i++)
            {
                //Ограничил до 200, но можно и больше
                int length = _random.Next(200);
                int widtht = _random.Next(200);
                //Point2D somepoint = new Point2D(length / 2, widtht / 2);
                _rectangles[i] = new Rectangle(length, widtht, RectangleColor[i]);
                RectangleListBoxItems[i] = ($"Rectangle{i + 1}");
            }
            RectanglesListBox.Items.AddRange(RectangleListBoxItems);
        }

        //Метод для поиска индекса прямоугольника с максимальной шириной
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int MaxWidth = rectangles[0].Width;
            int MaxWidthIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].Width > MaxWidth)
                {
                    MaxWidth = rectangles[i].Width;
                    MaxWidthIndex = i;
                }
            }
            return MaxWidthIndex;

        }
        public RectanglesPropertiesControl()
        {
            InitializeComponent();

            RectangleInitiaziation();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //Contact contact = new Contact("DAD", "", 12, "");
            //label14.Text = contact.Surname;
            //Point2D point = new Point2D(10, 20);
            //Rectangle rectangle = new Rectangle(1, 1, "", point);
            // label14.Text = rectangle.Center.CoordinateX.ToString();

            //Point2D point = new Point2D();
            /*point.CoordinateX = 12;
            label14.Text = point.CoordinateX.ToString();*/

            /*Ring ring = new Ring(20,10);
            label14.Text=ring.Area.ToString();*/

            //Rectangle rec = new Rectangle();

            //label14.Text = _currentRectangle.AllRectanglesCount.ToString();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int RectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = RectangleMaxWidthIndex;

        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesListBox.SelectedIndex;
            if (selectedIndex == -1) return;
            _currentRectangle = _rectangles[selectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();

        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {


            try
            {
                LengthTextBox.BackColor = System.Drawing.Color.White;
                int length = int.Parse(LengthTextBox.Text);
                _currentRectangle.Length = length;
                XCoordinateTextBox.Text = _currentRectangle.Center.CoordinateX.ToString();
            }
            catch (Exception)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (_currentRectangle == null) return;

            try
            {
                WidthTextBox.BackColor = System.Drawing.Color.White;
                int width = int.Parse(WidthTextBox.Text);
                _currentRectangle.Width = width;
                YCoordinateTextBox.Text = _currentRectangle.Center.CoordinateY.ToString();

            }
            catch (Exception)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string color = ColorTextBox.Text;
            _currentRectangle.Color = color;

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
