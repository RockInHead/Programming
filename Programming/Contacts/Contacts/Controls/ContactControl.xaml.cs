using System.Windows.Controls;
using System.Windows.Input;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml.
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ContactControl"/>.
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события предварительного ввода текста в TextBox.
        /// Разрешает ввод только цифр, знаков.
        /// </summary>
        /// <param name="sender">Элемент, вызвавший событие.</param>
        /// <param name="e">Аргументы события, содержащие вводимый текст.</param>
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string pattern = @"^[\d\+\-\(\)]*$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, pattern))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Обработчик события нажатия клавиш в TextBox.
        /// Запрещает ввод пробелов.
        /// </summary>
        /// <param name="sender">Элемент, вызвавший событие.</param>
        /// <param name="e">Аргументы события, содержащие информацию о нажатой клавише.</param>
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Обработчик команды выполнения (Executed) в TextBox.
        /// Запрещает вставку данных из буфера обмена.
        /// </summary>
        /// <param name="sender">Элемент, вызвавший событие.</param>
        /// <param name="e">Аргументы события, содержащие информацию о команде.</param>
        private void TextBox_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }
    }
}
