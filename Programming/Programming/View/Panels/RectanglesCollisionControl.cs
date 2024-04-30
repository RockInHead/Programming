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
    /// <summary>
    /// Осуществляет динамическое отображение пересечений прмоугольников на канве.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        //Поля
        private List<Rectangle> _canvaRectangles = new List<Rectangle>();
        private Rectangle _currentCanvaRectangle;
        private List<string> CanvaRectanglesListBoxItems = new List<string>();

        private List<Panel> _rectanglesPanels = new List<Panel>();
        /// <summary>
        /// Осуществялет рандомную генерацию 5 прямоугольников с выводом их на канву.
        /// </summary>
        public void CanvaRectangleInitiaziation()
        {
            for (int i = 0; i < 5; i++)
            {
                //Ограничил до 200, но можно и больше
                //int length = _random.Next(10,200);
                //int widtht = _random.Next(10,200);
                //_canvaRectangles.Add(new Rectangle(length, widtht, ""));

                _canvaRectangles.Add(RectangleFactory.Randomize());
                CanvaRectanglesListBoxItems.Add($"{i + 1})L={_canvaRectangles[i].Length};W={_canvaRectangles[i].Width};X={_canvaRectangles[i].Center.CoordinateX};Y={_canvaRectangles[i].Center.CoordinateY}");

                Panel InitPanel = new Panel();
                InitPanel.Location = new Point((int)_canvaRectangles[i].Center.CoordinateX - _canvaRectangles[i].Width / 2, (int)_canvaRectangles[i].Center.CoordinateY - _canvaRectangles[i].Length / 2);
                InitPanel.Height = _canvaRectangles[i].Length;
                InitPanel.Width = _canvaRectangles[i].Width;
                InitPanel.BackColor = System.Drawing.Color.LightGreen;
                RectanglesPanel.Controls.Add(InitPanel);
                _rectanglesPanels.Add(InitPanel);
            }
            foreach (string el in CanvaRectanglesListBoxItems)
            {
                CanvaRectanglesListBox.Items.Add(el);
            }
            FindCollision();
        }
        public RectanglesCollisionControl()
        {
            InitializeComponent();

            CanvaRectangleInitiaziation();
        }
        /// <summary>
        /// Осуществляет проверку пересечений всех существующих прямоугольников на канве. При пересечении окрашивает, пересекающиеся прямоугольники в красный цвет, иначе зеленый.
        /// </summary>
        private void FindCollision()
        {
            foreach (var panel in _rectanglesPanels)
            {
                panel.BackColor = System.Drawing.Color.LightGreen;
            }

            for (int i = 0; i < _canvaRectangles.Count; i++)
            {
                for (int j = 0; j < _canvaRectangles.Count; j++)
                {
                    if (!(_canvaRectangles[i] == _canvaRectangles[j]) && CollisionManager.isCollision(_canvaRectangles[i], _canvaRectangles[j]))
                    {
                        _rectanglesPanels[i].BackColor = System.Drawing.Color.Red;

                        _rectanglesPanels[j].BackColor = System.Drawing.Color.Red;
                    }

                }
            }
        }
        /// <summary>
        /// Считает номер для конретного объекта на ЛистБоксе.
        /// </summary>
        /// <returns>Номер объекта</returns>
        private int GiveRectangleOrder()
        {
            int RectangleOrder;
            if (CanvaRectanglesListBoxItems.Count != 0)
            {

                RectangleOrder = Convert.ToInt16(CanvaRectanglesListBoxItems[CanvaRectanglesListBoxItems.Count - 1].Substring(0, 2).Trim(')')) + 1;
            }
            else
            {
                RectangleOrder = 1;
            }
            return RectangleOrder;
        }
        /// <summary>
        /// Осуществляет добавление нового прямоугольника с рандомными полями и выводом его на канву. Так же добавляет его в массив прямоугольников.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            //int length = _random.Next(10,200);
            //int widtht = _random.Next(10,200);

            Rectangle NewRectangle = RectangleFactory.Randomize();


            _canvaRectangles.Add(NewRectangle);
            CanvaRectanglesListBoxItems.Add($"{GiveRectangleOrder()})L={NewRectangle.Length};W={NewRectangle.Width};X={NewRectangle.Center.CoordinateX};Y={NewRectangle.Center.CoordinateY}");
            CanvaRectanglesListBox.Items.Add(CanvaRectanglesListBoxItems[CanvaRectanglesListBoxItems.Count - 1]);
            CanvaRectanglesListBox.SelectedIndex = CanvaRectanglesListBox.Items.Count - 1;

            Panel NewPanel = new Panel();
            NewPanel.Location = new Point((int)NewRectangle.Center.CoordinateX - NewRectangle.Width / 2, (int)NewRectangle.Center.CoordinateY - NewRectangle.Length / 2);
            NewPanel.Height = NewRectangle.Length;
            NewPanel.Width = NewRectangle.Width;
            NewPanel.BackColor = System.Drawing.Color.LightGreen;

            _rectanglesPanels.Add(NewPanel);
            RectanglesPanel.Controls.Add(NewPanel);

            CanvaLengthTextBox.BackColor = System.Drawing.Color.White;
            CanvaWidthTextBox.BackColor = System.Drawing.Color.White;

            FindCollision();
        }
        /// <summary>
        /// Осуществляет удаление прямоугольника по выбранному индексу. Так же удаляет его с канвы и массива прямоугольников.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CanvaRectanglesListBox.SelectedIndex;

            if (selectedIndex == -1) return;

            _canvaRectangles.RemoveAt(selectedIndex);
            CanvaRectanglesListBoxItems.RemoveAt(selectedIndex);
            CanvaRectanglesListBox.Items.RemoveAt(selectedIndex);

            CanvaRectanglesListBox.SelectedIndex = CanvaRectanglesListBox.Items.Count - 1;

            _rectanglesPanels.RemoveAt(selectedIndex);
            RectanglesPanel.Controls.RemoveAt(selectedIndex);

            FindCollision();
        }
        /// <summary>
        /// Обновляет информацию о полях выбранного прямоугольника в ТексБоксах.
        /// </summary>
        private void UpdateRectangleInfo()
        {

            int selectedIndex = CanvaRectanglesListBox.SelectedIndex;
            if (selectedIndex == -1) return;

            _currentCanvaRectangle = _canvaRectangles[selectedIndex];

            CanvaLengthTextBox.Text = _currentCanvaRectangle.Length.ToString();
            CanvaWidthTextBox.Text = _currentCanvaRectangle.Width.ToString();

            CanvaIdTextBox.Text = (_currentCanvaRectangle.Id-5).ToString();

        }
        /// <summary>
        /// Очищает все ТекстБоксы ,если не созданно ни одного прямоугольника.
        /// </summary>
        private void ClearRectangleInfo()
        {
            if (CanvaRectanglesListBox.Items.Count == 0)
            {
                CanvaLengthTextBox.Text = "";
                CanvaLengthTextBox.ReadOnly = true;

                CanvaWidthTextBox.Text = "";
                CanvaWidthTextBox.ReadOnly = true;

                CanvaXCoordinateTextBox.Text = "";
                CanvaYCoordinateTextBox.Text = "";

                CanvaIdTextBox.Text = "";
            }
            else
            {
                CanvaLengthTextBox.ReadOnly = false;
                CanvaWidthTextBox.ReadOnly = false;
            }
        }
        /// <summary>
        /// Вызывает 2 метода при изменении индекса в ЛистБоксе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CanvaRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearRectangleInfo();
            UpdateRectangleInfo();
        }
        /// <summary>
        /// Осуществляет изменениия поля Length у конкретного объекта. Так же динамически изменяет его на канве с проверкой пересечений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CanvaLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = CanvaRectanglesListBox.SelectedIndex;
            try
            {
                if (CanvaRectanglesListBox.Items.Count != 0)
                {

                    CanvaLengthTextBox.BackColor = System.Drawing.Color.White;
                    int length = int.Parse(CanvaLengthTextBox.Text);
                    _currentCanvaRectangle.Length = length;
                    CanvaXCoordinateTextBox.Text = _currentCanvaRectangle.Center.CoordinateX.ToString();

                    double X = _currentCanvaRectangle.Center.CoordinateX;
                    double Y = _currentCanvaRectangle.Center.CoordinateY;

                    CanvaRectanglesListBoxItems[selectedIndex] = CanvaRectanglesListBoxItems[selectedIndex].Substring(0, CanvaRectanglesListBoxItems[selectedIndex].IndexOf('L')) + ($"L={_currentCanvaRectangle.Length};W={_currentCanvaRectangle.Width};X={X};Y={Y}");
                    CanvaRectanglesListBox.Items[selectedIndex] = CanvaRectanglesListBoxItems[selectedIndex];

                    _rectanglesPanels[selectedIndex].Location = new Point((int)_currentCanvaRectangle.Center.CoordinateX - _currentCanvaRectangle.Width / 2, (int)_currentCanvaRectangle.Center.CoordinateY - _currentCanvaRectangle.Length / 2);
                    _rectanglesPanels[selectedIndex].Height = _currentCanvaRectangle.Length;

                    FindCollision();
                  
                }
            }
            catch (Exception)
            {
                CanvaLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Осуществляет изменениия поля Width у конкретного объекта. Так же динамически изменяет его на канве с проверкой пересечений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CanvaWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex = CanvaRectanglesListBox.SelectedIndex;
            try
            {
                if (CanvaRectanglesListBox.Items.Count != 0)
                {

                    CanvaWidthTextBox.BackColor = System.Drawing.Color.White;

                    int width = int.Parse(CanvaWidthTextBox.Text);
                    _currentCanvaRectangle.Width = width;
                    CanvaYCoordinateTextBox.Text = _currentCanvaRectangle.Center.CoordinateY.ToString();

                    CanvaRectanglesListBoxItems[selectedIndex] = CanvaRectanglesListBoxItems[selectedIndex].Substring(0, CanvaRectanglesListBoxItems[selectedIndex].IndexOf('L')) + ($"L={_currentCanvaRectangle.Length};W={_currentCanvaRectangle.Width};X={_currentCanvaRectangle.Center.CoordinateX};Y={_currentCanvaRectangle.Center.CoordinateY}");
                    CanvaRectanglesListBox.Items[selectedIndex] = CanvaRectanglesListBoxItems[selectedIndex];

                    _rectanglesPanels[selectedIndex].Width = width;

                    _rectanglesPanels[selectedIndex].Location = new Point((int)_currentCanvaRectangle.Center.CoordinateX - _currentCanvaRectangle.Width / 2, (int)_currentCanvaRectangle.Center.CoordinateY - _currentCanvaRectangle.Length / 2);
                    _rectanglesPanels[selectedIndex].Width = _currentCanvaRectangle.Width;
                    FindCollision();
                }
            }
            catch (Exception)
            {
                CanvaWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

    }
}
