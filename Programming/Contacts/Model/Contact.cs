using System.ComponentModel;
using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;

// TODO: тоже, что и с другими namespace
namespace Contacts.Model
{
    /// <summary>
    /// Класс контакта пользователя, хранящий имя, номер телефон и почту контакта.
    /// </summary>
    public partial class Contact : ObservableObject, IDataErrorInfo, ICloneable
    {
        /// <summary>
        /// Максимальное количество символов для текстового блока.
        /// </summary>
        private const int MaxTextBoxSymbols = 100;

        /// <summary>
        /// Максимальное количество символов для номера телефона.
        /// </summary>
        private const int MaxPhoneNumberTextBoxSymbols = 11;

        /// <summary>
        /// Поле, хранящее имя контакта.
        /// </summary>
        [ObservableProperty]
        private string _name;

        /// <summary>
        /// Поле, хранящее почту контакта.
        /// /// </summary>
        [ObservableProperty]
        private string _email;

        /// <summary>
        /// Поле, хранящее телефонный номер контакта.
        /// /// </summary>
        [ObservableProperty]
        private string _phoneNumber;

        /// <summary>
        /// Конструктор класса Contact.
        /// Инициализирует поля значениями по умолчанию.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Конструктор Contact c параметрами.
        /// Инициализирует новый класс с указанными значениями.
        /// </summary>
        /// <param name="name">Имя контакта</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="email">Почта контакта</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <inheritdoc cref="IDataErrorInfo.Error"/>
        public string Error => "";

        /// <summary>
        /// Создает копию текущего объекта Contact.
        /// </summary>
        /// <returns>Новый объект Contact с такими же значениями свойств.</returns>
        public object Clone() => new Contact(Name, PhoneNumber, Email);

        /// <summary>
        /// Индексатор для валидации свойств контакта.
        /// Возвращает сообщение об ошибке, если данные некорректны.
        /// </summary>
        /// <param name="columnName">Имя свойства, для которого требуется валидация.</param>
        /// <returns>Сообщение об ошибке или null, если ошибок нет.</returns>
        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Name):
                        {
                            if (string.IsNullOrWhiteSpace(Name) || Name.Length > MaxTextBoxSymbols)
                            {
                                return "Имя должно содержать хотя бы 2 символа и не более 100";
                            }

                            break;
                        }

                    case nameof(PhoneNumber):
                        {
                            if (string.IsNullOrWhiteSpace(PhoneNumber)
                                            || PhoneNumber.Length > MaxPhoneNumberTextBoxSymbols
                                            || !Regex.IsMatch(PhoneNumber, @"^[\d+\-()\s]+$"))
                            {
                                return "Номер телефона может содержать только цифры и символы '+()-'.";
                            }

                            break;
                        }

                    case nameof(Email):
                        {
                            if (string.IsNullOrWhiteSpace(Email)
                               || Email.Length > MaxTextBoxSymbols
                               || !Email.Contains('@'))
                            {
                                return "Почта должна содержать символ '@'.";
                            }

                            break;
                        }
                }

                return "";
            }
        }
    }
}

