using System;
using System.Drawing;
using System.Reflection;
namespace Programming
{
    public partial class MainForm : Form
    {
        //Поля прямоугольника
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;
        private string[] RectangleListBoxItems = new string[5];
        private string[] RectangleColor = new string[6] { "Black", "White", "Orange", "Purple", "Green", "Blue" };

        //Генерация рандомных полей в прямоугольник
        Random _random = new Random();
        public void Rectangle()
        {
            for (int i = 0; i < 5; i++)
            {
                //Ограничил до 200, но можно и больше
                int length = _random.Next(200);
                int widtht = _random.Next(200);
                _rectangles[i] = new Rectangle(length, widtht, RectangleColor[i]);
                RectangleListBoxItems[i] = ($"Rectangle{i + 1}");
            }
            RectanglesListBox.Items.AddRange(RectangleListBoxItems);
        }
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int MaxWidth = rectangles[0].Width;
            int MaxWidthIndex = 0;
            for(int i = 0; i < 5; i++)
            {
                if (rectangles[i].Width > MaxWidth)
                {
                    MaxWidth = rectangles[i].Width;
                    MaxWidthIndex = i;
                }
            }
            return MaxWidthIndex;
           
        }
        public MainForm()
        {
            InitializeComponent();

            object[] SeasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(SeasonValues);

            //Вызов рандомной генерации полей прямоугольника
            Rectangle();

           
        }

        //2 ЛАБА
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            IntTextBox.Clear();
            switch (EnumsListBox.SelectedIndex)
            {
                case 0:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Color)).Cast<object>().ToArray());
                    break;
                case 1:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(EducationForm)).Cast<object>().ToArray());
                    break;
                case 2:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Genre)).Cast<object>().ToArray());
                    break;
                case 3:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Manufactures)).Cast<object>().ToArray());
                    break;
                case 4:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
                    break;
                case 5:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Weekday)).Cast<object>().ToArray());
                    break;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ValuesListBox.SelectedIndex == -1) return;
            IntTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string ParsingText = ParsingTextBox.Text;
            Weekday ParsedDay;

            if (!int.TryParse(ParsingText, out _) && Enum.TryParse<Weekday>(ParsingText, true, out ParsedDay))
            {
                int WeekdayOrder = (int)ParsedDay;
                ParsedValueLabel.Text = $"Это день недели ({ParsedDay} = {WeekdayOrder})";
            }
            else
            {
                ParsedValueLabel.Text = "Нет такого дня недели!!!!";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                SeasonComboBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            SeasonComboBox.BackColor = System.Drawing.Color.White;
            switch (SeasonComboBox.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    SetBackColor(GroupBoxSeasonHandle.BackColor = ColorTranslator.FromHtml("#e29c45"));
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    SetBackColor(GroupBoxSeasonHandle.BackColor = ColorTranslator.FromHtml("#559c45"));
                    break;
            }

        }
        private void SetBackColor(System.Drawing.Color color)
        {
            EnumerationsGroupBox.BackColor = color;
            WeekdayParsingGroupBox.BackColor = color;
            SeasonComboBox.BackColor = color;
            this.BackColor = color;
        }

        //2 ЛАБА


        //3 ЛАБА
        private void tabPage2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           int RectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
           RectanglesListBox.SelectedIndex = RectangleMaxWidthIndex;
        
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void RectanglesGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (_currentRectangle == null) return;

            try
            {
                LengthTextBox.BackColor = System.Drawing.Color.White;
                int length = int.Parse(LengthTextBox.Text);
                _currentRectangle.Length = length;
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
    }

}
