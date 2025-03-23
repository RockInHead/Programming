using System.Windows;
using Contacts.ViewModel;

// TODO: неправильный namespace +
namespace Contacts.View
{
    /// <summary>
    /// Главное окно приложения.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Инициализирует главное окно приложения и устанавливает контекст данных.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            // Устанавливает модель представления как DataContext для привязки данных
            DataContext = new MainVM();
        }
    }
}
