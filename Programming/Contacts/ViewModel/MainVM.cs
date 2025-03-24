using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contacts.Model;

// TODO: имя solution не участвует в namespace, он формируется по физическим папкам.
namespace Contacts.ViewModel
{
    /// <summary>
    /// Основная модель представления для управления контактами и их сохранением/загрузкой.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Выбранный контакт для редактирования.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyContactCommand))]
        private Contact _selectedContact;

        /// <summary>
        /// Значение, указывающее, находятся ли поля доступными только для чтения.
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsAddOrEditMode))]
        [NotifyCanExecuteChangedFor(nameof(AddContactCommand))]
        [NotifyCanExecuteChangedFor(nameof(EditContactCommand))]
        [NotifyCanExecuteChangedFor(nameof(RemoveContactCommand))]
        private bool _isReadOnlyMode = true;

        /// <summary>
        /// Возвращает или задает контакт до редактирования.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyContactCommand))]
        private Contact _originalContact;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>(ContactSerializer.LoadContacts());
        }

        /// <summary>
        /// Список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Возвращает значение, указывающее, редактируется ли контакт.
        /// </summary>
        public bool IsAddOrEditMode => !IsReadOnlyMode;

        /// <summary>
        /// Вызывается при изменении выбранного контакта.
        /// Клонирует текущий контакт для возможности отмены изменений,
        /// уведомляет об изменении состояния выбора контакта,
        /// обновляет состояния команд.
        /// </summary>
        /// <param name="value">Новый выбранный контакт</param>
        partial void OnSelectedContactChanged(Contact value)
        {
            OriginalContact = value?.Clone() as Contact;
            OnPropertyChanged(nameof(IsContactSelected));

            if (value != null)
            {
                // TODO: поставь точку останова на ApplyContactCommand.NotifyCanExecuteChanged();
                // попереключайся между двумя контактами и нажми на одном из них edit. у тебя будет куча вызовов все еще.
                // ниже, где ты пытаешься отписываться я объяснил, почему так происходит.
                value.PropertyChanged += (s, e) =>
                {
                    ApplyContactCommand.NotifyCanExecuteChanged();
                };
            }
        }

        /// <summary>
        /// Вызывается перед изменением выбранного контакта.
        /// Если редактирование активно, восстанавливает оригинальные значения
        /// полей текущего контакт и переключает в режим только для чтения.
        /// </summary>
        /// <param name="value">Новый контакт, который будет выбран</param>
        /// <remarks>
        /// Срабатывает только при активном режиме редактирования (IsReadOnlyMode = false)
        /// и наличии текущего выбранного контакта.
        /// </remarks>
        partial void OnSelectedContactChanging(Contact value)
        {
            if (_selectedContact != null)
            {
                // TODO: когда ты используешь лямбда выражение ты создаешь анонимный метод.
                // Т.е. при каждом срабатывании этого метода ты сначала создаешь новый метод,
                // затем пытаешься отписать его от события PropertyChanged.
                // Но отписки не произойдет, т.к. этот метод только что создан и не был подписан на это событие.
                var a = (int parameter) =>
                {
                    var b = $"c {parameter}";
                    return b;
                };
                // Видишь код выше - мы создаем новый метод и нам возвращается ссылка на него.
                // И она каждый раз новая.
                // Ты не можешь отписать анонимный метод, если у тебя нет на него ссылки.
                // Создай полноценный именованный метод и подписывай/отписывай его.
                _selectedContact.PropertyChanged -= (s, e) =>
                {
                    ApplyContactCommand.NotifyCanExecuteChanged();
                }; 
            }

            if (!IsReadOnlyMode && _selectedContact != null)
            {
                _selectedContact.Name = OriginalContact.Name;
                _selectedContact.PhoneNumber = OriginalContact.PhoneNumber;
                _selectedContact.Email = OriginalContact.Email;
                IsReadOnlyMode = true;
            }
        }

        /// <summary>
        /// Проверяет, выбран ли контакт.
        /// </summary>
        public bool IsContactSelected => _selectedContact != null;

        /// <summary>
        /// Редактирует выбранный контакт.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        [RelayCommand(CanExecute = nameof(CanEditContact))]
        public void EditContact(object parameter)
        {
            OriginalContact = (Contact)SelectedContact.Clone();
            IsReadOnlyMode = false;
        }

        /// <summary>
        /// Удаляет выбранный контакт.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        [RelayCommand(CanExecute = nameof(CanRemoveContact))]
        public void RemoveContact(object parameter)
        {
            int index = Contacts.IndexOf(SelectedContact);
            Contacts.Remove(SelectedContact);

            if (Contacts.Any())
            {
                SelectedContact = index < Contacts.Count ? Contacts[index] : Contacts.Last();
            }
            else
            {
                SelectedContact = null;
            }

            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Добавляет новый контакт.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        [RelayCommand(CanExecute = nameof(CanAddContact))]
        public void AddContact(object parameter)
        {
            SelectedContact = new Contact();
            IsReadOnlyMode = false;
        }

        /// <summary>
        /// Применяет изменения к выбранному контакту.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        [RelayCommand(CanExecute = nameof(CanApplyContact))]
        public void ApplyContact(object parameter)
        {
            if (!Contacts.Contains(SelectedContact))
            {
                Contacts.Add(SelectedContact);
            }

            IsReadOnlyMode = true;
            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Проверяет, можно ли добавить контакт.
        /// </summary>
        /// <param name="parameter">Параметр команды. TODO: Не исправлено. здесь и ниже, откуда комментарий на несуществующий параметр? убрать </param>
        /// <returns>Возвращает <c>true</c>, если контакт можно добавить; иначе <c>false</c>.</returns>
        private bool CanAddContact() => !IsAddOrEditMode;

        /// <summary>
        /// Проверяет, можно ли редактировать выбранный контакт.
        /// </summary>
        /// <param name="parameter">Параметр команды. TODO: Не исправлено</param>
        /// <returns>Возвращает <c>true</c>, если контакт можно редактировать; иначе <c>false</c>.</returns>
        private bool CanEditContact() => IsContactSelected && !IsAddOrEditMode;

        /// <summary>
        /// Проверяет, можно ли удалить выбранный контакт.
        /// </summary>
        /// <param name="parameter">Параметр команды.TODO: Не исправлено</param>
        /// <returns>Возвращает <c>true</c>, если контакт можно удалить; иначе <c>false</c>.</returns>
        private bool CanRemoveContact() => IsContactSelected && !IsAddOrEditMode;

        /// <summary>
        /// Проверяет, можно ли применить изменения для выбранного контакта.
        /// </summary>
        /// <param name="parameter">Параметр команды.TODO: Не исправлено</param>
        /// <returns>Возвращает <c>true</c>, если изменения можно применить; иначе <c>false</c>.</returns>
        private bool CanApplyContact() => IsAddOrEditMode && !HasValidationErrors;

        /// <summary>
        /// Определяет, есть ли ошибки валидации у выбранного контакта.
        /// </summary>
        /// <returns>
        /// Возвращает <c>true</c>, если у выбранного контакта есть ошибки валидации
        /// в полях "Name", "PhoneNumber" или "Email"; иначе <c>false</c>.
        /// </returns>
        private bool HasValidationErrors => SelectedContact != null &&
                                           (!string.IsNullOrEmpty(SelectedContact[nameof(SelectedContact.Name)]) || // TODO: внешние круглые в которые обернут nameof лишние, удалить, здесь и ниже.+
                                            !string.IsNullOrEmpty(SelectedContact[nameof(SelectedContact.PhoneNumber)]) || // TODO:+
                                            !string.IsNullOrEmpty(SelectedContact[nameof(SelectedContact.Email)])); // TODO:+
    }
}