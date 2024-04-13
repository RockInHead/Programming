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
    public partial class FilmsPropertiesControl : UserControl
    {
        //Поля фильма
        private Film[] _films = new Film[6];
        private Film _currentFilm;
        private string[] FilmListBoxItems = new string[6];
        private string[] FilmName = new string[6] { "Титаник", "Аватар", "Чужой", "Терминатор", "Пила", "Джентельмены" };
        private string[] FilmGenre = Enum.GetValues(typeof(Genre)).Cast<Genre>().Select(x => x.ToString()).ToArray();

        Random _random = new Random();
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
            for (int i = 0; i < 6; i++)
            {
                if (films[i].Rating > MaxRating)
                {
                    MaxRating = films[i].Rating;
                    MaxRatingIndex = i;
                }
            }
            return MaxRatingIndex;

        }
        public FilmsPropertiesControl()
        {
            InitializeComponent();

            FilmInizialition();
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
    }
}
