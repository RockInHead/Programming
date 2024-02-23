using System;
using System.Drawing;
using System.Reflection;
namespace Programming
{
    public partial class MainForm : Form
    {
        //Поля
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;

        private string[] RectangleListBoxItems = new string[5];
        private string[] RectangleColor = new string[6] { "Black", "White", "Orange", "Purple", "Green", "Blue" };

        Random _random = new Random();
        public void Rectangle()
        {
            for (int i = 0; i < 5; i++)
            {
                int length = _random.Next(200);
                int widtht = _random.Next(200);
                //Rectangle _currentRectangle = new Rectangle(length, widtht, RectangleColor[i]);
                _rectangles[i] = new Rectangle(length, widtht, RectangleColor[i]);
                RectangleListBoxItems[i] = ($"Rectangle{i + 1}");
            }
            RectanglesListBox.Items.AddRange(RectangleListBoxItems);
        }

        //private void TextChangedHandler(int length, int widtht, string color, int index)
        //{
        //    try
        //    {
        //        _currentRectangle.Length = length;
        //        _rectangles[index].Length = _currentRectangle.Length;

        //        _currentRectangle.Width = widtht;
        //        _rectangles[index].Width = _currentRectangle.Width;

        //        _currentRectangle.Color = color;
        //        _rectangles[index].Color = _currentRectangle.Color;
        //    }
        //    catch(Exception)
        //    {
        //        LengthTextBox.BackColor = System.Drawing.Color.LightPink;
        //    }
        //}
        public MainForm()
        {

            InitializeComponent();

            object[] SeasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(SeasonValues);

            Rectangle();

            /*Random _random = new Random();
            Rectangle[] _rectangles = new Rectangle[5];
            string[] RectangleListBoxItems = new string[5];
            string[] RectangleColor = new string[6] { "Black", "White", "Orange", "Purple", "Green", "Blue" };
            for (int i = 0; i < 5; i++)
            {
                int length = _random.Next();
                int widtht = _random.Next();
                Rectangle _currentRectangle = new Rectangle(length, widtht, RectangleColor[i]);
                _rectangles[i] = _currentRectangle;
                RectangleListBoxItems[i] = ($"Rectangle{i + 1}");
            }
            RectanglesListBox.Items.AddRange(RectangleListBoxItems);*/
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
            if (_currentRectangle == null) return;
            
            //try
            //{
                int length = int.Parse(LengthTextBox.Text);
                _currentRectangle.Length = length;
            //}
            //catch (Exception)
            //{
                //LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            //}
            //try
            //{
            //    TextChangedHandler(Convert.ToInt16(LengthTextBox.Text), Convert.ToInt16(WidthTextBox.Text), ColorTextBox.Text, RectanglesListBox.SelectedIndex);
            //}
            //catch(Exception)
            //{
            //    LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            //}
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (LengthTextBox.Text == "" | WidthTextBox.Text == "" | ColorTextBox.Text == "") return;

            //TextChangedHandler(Convert.ToInt16(LengthTextBox.Text), Convert.ToInt16(WidthTextBox.Text), ColorTextBox.Text, RectanglesListBox.SelectedIndex);
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (LengthTextBox.Text == "" | WidthTextBox.Text == "" | ColorTextBox.Text == "") return;

            //TextChangedHandler(Convert.ToInt16(LengthTextBox.Text), Convert.ToInt16(WidthTextBox.Text), ColorTextBox.Text, RectanglesListBox.SelectedIndex);
        }
    }

}
