using System.Windows;
using Contacts.ViewModel;

// TODO: все еще неправильный namespace - он образуется по физическим папкам.
// К тому же проект называется View, но лежит в папке Contacts.
// Переименовать папку на View или проект на Contacts - проект и его папка должны иметь одинаковые имена.
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
