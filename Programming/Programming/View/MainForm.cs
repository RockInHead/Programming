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
        //Поля фильма
        private Film[] _films = new Film[6];
        private Film _currentFilm;
        private string[] FilmListBoxItems = new string[6];
        private string[] FilmName = new string[6] { "Титаник", "Аватар", "Чужой", "Терминатор", "Пила", "Джентельмены" };
        private string[] FilmGenre = Enum.GetValues(typeof(Genre)).Cast<Genre>().Select(x => x.ToString()).ToArray();
        //Генерация рандомных полей в фильмах
        public void FilmInizialition()
        {
            for (int i = 0; i < 6; i++)
            {
                int durationMinutes = _random.Next(300);
                int releaseYear = _random.Next(1900, 2024);
                double rating = Math.Round(_random.NextDouble() * 10, 2);
                _films[i] = new Film(FilmName[i], durationMinutes, releaseYear, FilmGenre[i], rating);
                FilmListBoxItems[i] = ($"Film{i + 1}");
            }
            FilmsListBox.Items.AddRange(FilmListBoxItems);
        }

        //Метод для поиска индекса фильма с максимальным рейтингом
        private int FindFilmWithMaxRating(Film[] films)
        {
            double MaxRating = films[0].Rating;
            int MaxRatingIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (films[i].Rating > MaxRating)
                {
                    MaxRating = films[i].Rating;
                    MaxRatingIndex = i;
                }
            }
            return MaxRatingIndex;

        }



        //5 лаба 
        private List<Rectangle> _canvaRectangles = new List<Rectangle>();
        private Rectangle _currentCanvaRectangle;
        private List<string> CanvaRectanglesListBoxItems = new List<string>();
        public void CanvaRectangleInitiaziation()
        {
            for (int i = 0; i < 5; i++)
            {
                //Ограничил до 200, но можно и больше
                int length = _random.Next(200);
                int widtht = _random.Next(200);
                _canvaRectangles.Add(new Rectangle(length, widtht, ""));
                CanvaRectanglesListBoxItems.Add($"{i + 1}) L={_canvaRectangles[i].Length};W={_canvaRectangles[i].Width};X={_canvaRectangles[i].Center.CoordinateX};Y={_canvaRectangles[i].Center.CoordinateX}");
            }
            foreach (string el in CanvaRectanglesListBoxItems)
            {
                CanvaRectanglesListBox.Items.Add(el);
            }
        }


        public MainForm()
        {
            InitializeComponent();

            object[] SeasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(SeasonValues);

            //Вызов рандомной генерации полей прямоугольников
            RectangleInitiaziation();

            //Вызов рандомной генерации полей фильмов
            FilmInizialition();

            CanvaRectangleInitiaziation();

        }

        //2 ЛАБА

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

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int FilmsSelectedIndex = FilmsListBox.SelectedIndex;
            if (FilmsSelectedIndex == -1) return;
            _currentFilm = _films[FilmsSelectedIndex];
            NameTextBox.Text = _currentFilm.Name;
            DurationTextBox.Text = _currentFilm.DurationMinutes.ToString();
            YearTextBox.Text = _currentFilm.ReleaseYear.ToString();
            GenreTextBox.Text = _currentFilm.Genre;
            RatingTextBox.Text = _currentFilm.Rating.ToString();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Name = NameTextBox.Text;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.DurationMinutes = int.Parse(DurationTextBox.Text);
            }
            catch (Exception ex)
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YearTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.ReleaseYear = int.Parse(YearTextBox.Text);
            }
            catch (Exception ex)
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = GenreTextBox.Text;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RatingTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.Rating = double.Parse(RatingTextBox.Text);
            }
            catch (Exception ex)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindMaxRatingButton_Click(object sender, EventArgs e)
        {
            int FilmWithMaxRatingIndex = FindFilmWithMaxRating(_films);
            FilmsListBox.SelectedIndex = FilmWithMaxRatingIndex;
        }
        //3 ЛАБА

        //5 ЛАБА
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            int length = _random.Next(200);
            int widtht = _random.Next(200);
            Rectangle NewRectangle = new Rectangle(length, widtht, "");

            //Вот как было до экспериментов
            /*_canvaRectangles.Add(NewRectangle);
            CanvaRectanglesListBoxItems.Add($"{CanvaRectanglesListBoxItems.Count + 1}) L={NewRectangle.Length};W={NewRectangle.Width};X={NewRectangle.Center.CoordinateX};Y={NewRectangle.Center.CoordinateX}");
            CanvaRectanglesListBox.Items.Add(CanvaRectanglesListBoxItems[CanvaRectanglesListBoxItems.Count - 1]);*/

            //CanvaRectanglesListBox.Items.Add($"{CanvaRectanglesListBox.Items.Count + 1}) L={NewRectangle.Length};W={NewRectangle.Width};X={NewRectangle.Center.CoordinateX};Y={NewRectangle.Center.CoordinateX}");

            int RectangleOrder;
            if (CanvaRectanglesListBoxItems.Count != 0)
            {
                RectangleOrder = Convert.ToInt16(CanvaRectanglesListBoxItems[CanvaRectanglesListBoxItems.Count - 1].Substring(0, 2).Trim(')')) + 1;
            }
            else
            {
                RectangleOrder = 1;
            }
            //int RectangleOrder = CanvaRectanglesListBoxItems.Count + 1;

            _canvaRectangles.Add(NewRectangle);
            CanvaRectanglesListBoxItems.Add($"{RectangleOrder}) L={NewRectangle.Length};W={NewRectangle.Width};X={NewRectangle.Center.CoordinateX};Y={NewRectangle.Center.CoordinateX}");
            CanvaRectanglesListBox.Items.Add(CanvaRectanglesListBoxItems[CanvaRectanglesListBoxItems.Count - 1]);
        } 

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CanvaRectanglesListBox.SelectedIndex;
            if (selectedIndex == -1) return;
            //CanvaRectanglesListBoxItems.RemoveAt(selectedIndex);
            _canvaRectangles.RemoveAt(selectedIndex);
            CanvaRectanglesListBoxItems.RemoveAt(selectedIndex);
            CanvaRectanglesListBox.Items.RemoveAt(selectedIndex);
            CanvaRectanglesListBox.SelectedIndex = CanvaRectanglesListBox.Items.Count - 1;
        }

        private void CanvaRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CanvaRectanglesListBox.SelectedIndex;
            if (selectedIndex == -1) return;
            _currentCanvaRectangle = _canvaRectangles[selectedIndex];
            CanvaLengthTextBox.Text = _currentCanvaRectangle.Length.ToString();
            CanvaWidthTextBox.Text = _currentCanvaRectangle.Width.ToString();
            //ColorTextBox.Text = _currentRectangle.Color;
            CanvaIdTextBox.Text = (_currentCanvaRectangle.Id-5).ToString();
            //CanvaRectanglesListBox.SelectedIndex= CanvaRectanglesListBox.Items.Count-1;
        }

        private void CanvaLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CanvaLengthTextBox.BackColor = System.Drawing.Color.White;
                int length = int.Parse(CanvaLengthTextBox.Text);
                _currentCanvaRectangle.Length = length;
                CanvaXCoordinateTextBox.Text = _currentCanvaRectangle.Center.CoordinateX.ToString();
            }
            catch (Exception)
            {
                CanvaLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void CanvaCoordinateXTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CanvaWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CanvaWidthTextBox.BackColor = System.Drawing.Color.White;
                int width = int.Parse(CanvaWidthTextBox.Text);
                _currentCanvaRectangle.Width = width;
                CanvaYCoordinateTextBox.Text = _currentCanvaRectangle.Center.CoordinateY.ToString();
            }
            catch (Exception)
            {
                CanvaWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

       
        //5 ЛАБА
    }
}

