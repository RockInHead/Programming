using System.Collections.ObjectModel;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

/// <summary>
/// Основная модель представления для управления контактами и их сохранением/загрузкой.
/// </summary>
public partial class MainVM : ObservableObject
{
    /// <summary>
    /// Выбранный контакт для редактирования.
    /// </summary>
    [ObservableProperty]
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
    private Contact _originalContact;

    /// <summary>
    /// Инициализирует новый экземпляр <see cref="MainVM"/>.
    /// </summary>
    public MainVM()
    {
        ContactSerializer.CreateDirectory();
        Contacts = new ObservableCollection<Contact>(ContactSerializer.LoadContacts());
     /*   AddCommand = new RelayCommand(AddContact, CanAddContact);
        EditCommand = new RelayCommand(EditContact, CanEditContact);
        RemoveCommand = new RelayCommand(RemoveContact, CanRemoveContact);
        ApplyCommand = new RelayCommand(ApplyContact, CanApplyContact);*/
    }

    /*/// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged"/>
    public event PropertyChangedEventHandler PropertyChanged;*/

/*    /// <summary>
    /// Команда для добавления нового контакта.
    /// </summary>
    public ICommand AddCommand { get; }

    /// <summary>
    /// Команда для редактирования выбранного контакта.
    /// </summary>
    public ICommand EditCommand { get; }

    /// <summary>
    /// Команда для удаления выбранного контакта.
    /// </summary>
    public ICommand RemoveCommand { get; }

    /// <summary>
    /// Команда для применения изменений в выбранном контакте.
    /// </summary>
    public ICommand ApplyCommand { get; }*/

    /// <summary>
    /// Список контактов.
    /// </summary>
    public ObservableCollection<Contact> Contacts { get; set; }

    /// <summary>
    /// Возвращает значение, указывающее, редактируется ли контакт.
    /// </summary>
    public bool IsAddOrEditMode => !IsReadOnlyMode;

    /// <summary>
    /// Получает или задает значение, указывающее, находится ли приложение в режиме редактирования.
    /// </summary>
   /* public bool IsReadOnlyMode
    {
        get => _isReadOnlyMode;
        set
        {
            _isReadOnlyMode = value;
            OnPropertyChanged(nameof(IsReadOnlyMode));
            OnPropertyChanged(nameof(IsAddOrEditMode));
        }
    }*/

    /*/// <summary>
    /// Возвращает или задает выбранный контакт.
    /// </summary>
    public Contact SelectedContact
    {
        get => _selectedContact;
        set
        {
            if (_selectedContact != null && !IsReadOnlyMode)
            {
                CancelEdit();
            }

            _selectedContact = value;
            OnPropertyChanged(nameof(IsAddOrEditMode));
            OnPropertyChanged(nameof(SelectedContact));
            OnPropertyChanged(nameof(IsContactSelected));
        }
    }*/

    partial void OnSelectedContactChanged(Contact value)
    {
        OriginalContact = value?.Clone() as Contact;
        OnPropertyChanged(nameof(IsContactSelected));
        UpdateCommandStates();
    }

    partial void OnSelectedContactChanging(Contact value)
    {
        if (!IsReadOnlyMode && _selectedContact != null)
        {
            // Восстанавливаем оригинальные значения для текущего контакта
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
        if (SelectedContact == null)
        {
            return;
        }

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
        SelectedContact = null;
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
        if (parameter is not BindingGroup bindingGroup)
        {
            return;
        }

        bindingGroup.CommitEdit();
        if (SelectedContact == null)
        {
            return;
        }

        if (!Contacts.Contains(SelectedContact))
        {
            Contacts.Add(SelectedContact);
        }

        IsReadOnlyMode = true;
        ContactSerializer.SaveContacts(Contacts);
    }

    /*/// <summary>
    /// Вызывает событие PropertyChanged для уведомления об изменении свойства.
    /// </summary>
    /// <param name="propertyName">Имя измененного свойства.</param>
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }*/

    /// <summary>
    /// Отменяет редактирование контакта.
    /// </summary>
    private void CancelEdit()
    {
        if (OriginalContact != null)
        {
            SelectedContact.Name = OriginalContact.Name;
            SelectedContact.PhoneNumber = OriginalContact.PhoneNumber;
            SelectedContact.Email = OriginalContact.Email;
        }

        IsReadOnlyMode = true;
/*        OnPropertyChanged(nameof(IsReadOnlyMode));
        OnPropertyChanged(nameof(IsAddOrEditMode));*/
    }

    /// <summary>
    /// Проверяет, можно ли добавить контакт.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    /// <returns>Возвращает <c>true</c>, если контакт можно добавить; иначе <c>false</c>.</returns>
    private bool CanAddContact() => !IsAddOrEditMode;

    /// <summary>
    /// Проверяет, можно ли редактировать выбранный контакт.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    /// <returns>Возвращает <c>true</c>, если контакт можно редактировать; иначе <c>false</c>.</returns>
    private bool CanEditContact() => IsContactSelected && !IsAddOrEditMode;

    /// <summary>
    /// Проверяет, можно ли удалить выбранный контакт.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    /// <returns>Возвращает <c>true</c>, если контакт можно удалить; иначе <c>false</c>.</returns>
    private bool CanRemoveContact() => IsContactSelected && !IsAddOrEditMode;

    /// <summary>
    /// Проверяет, можно ли применить изменения для выбранного контакта.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
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
                                       (!string.IsNullOrEmpty(SelectedContact["Name"]) ||
                                        !string.IsNullOrEmpty(SelectedContact["PhoneNumber"]) ||
                                        !string.IsNullOrEmpty(SelectedContact["Email"]));

    private void UpdateCommandStates()
    {
        // Добавьте подписку на изменение свойств контакта
        if (SelectedContact != null)
        {
            SelectedContact.PropertyChanged += (s, e) =>
            {
                ApplyContactCommand.NotifyCanExecuteChanged();
            };
        }

        AddContactCommand.NotifyCanExecuteChanged();
        EditContactCommand.NotifyCanExecuteChanged();
        RemoveContactCommand.NotifyCanExecuteChanged();
        ApplyContactCommand.NotifyCanExecuteChanged();
    }
}