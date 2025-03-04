using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

/// <summary>
/// Основная модель представления для управления контактами и их сохранением/загрузкой.
/// </summary>
public class MainVM : INotifyPropertyChanged
{
    /// <summary>
    /// Объект текущего контакта.
    /// </summary>
    private Contact _currentContact;

    private ContactVM _selectedContact;

    private bool _isEditing;

    /// <summary>
    /// Значение, указывающее, редактируется ли контакт.
    /// </summary>
    private bool _isEditingContact;

    /// <summary>
    /// Значение, указывающее, находится ли приложение в режиме редактирования.
    /// </summary>
    private bool _isReadOnlyMode = true;

    public ICommand AddCommand { get; }
    public ICommand EditCommand { get; }
    public ICommand RemoveCommand { get; }
    public ICommand ApplyCommand { get; }

    /// <summary>
    /// Инициализирует новый экземпляр <see cref="MainVM"/>.
    /// </summary>
    public MainVM()
    {
        _currentContact = new Contact();

        /*SaveCommand = new SaveCommand(() => CurrentContact);
        LoadCommand = new LoadCommand(loadedContact => UpdateContact(loadedContact));*/

        Contacts = new ObservableCollection<ContactVM>
        {
            /*new ContactVM(new Contact("Илья Шутов", "8-800-555-35-35", "tusurthechampion36.gmail")),*/
            new ContactVM(new Contact("Алексей Иванов", "8-999-123-45-67", "alex@example.com")),
        };

        AddCommand = new RelayCommand(AddContact, CanAddContact);
        EditCommand = new RelayCommand(EditContact, CanEditContact);
        RemoveCommand = new RelayCommand(RemoveContact, CanRemoveContact);
        ApplyCommand = new RelayCommand(ApplyContact, CanApplyContact);
    }

    /// <summary>
    /// Получает или задает значение, указывающее, редактируется ли контакт.
    /// </summary>
    public bool IsEditingContact
    {
        get => _isEditingContact;
        set
        {
            _isEditingContact = value;
            OnPropertyChanged(nameof(IsEditingContact));
        }
    }

    /// <summary>
    /// Редактирует выбранный контакт.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    public void EditContact(object parameter)
    {
        IsApplyButtonVisible = true;
        IsReadOnlyMode = false;
        IsEditingContact = true;
    }

    /// <summary>
    /// Удаляет выбранный контакт.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    public void RemoveContact(object parameter)
    {
        if (SelectedContact != null)
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
            /*ContactSerializer.SaveContacts(Contacts);*/
        }
    }

    public void AddContact(object parameter)
    {
        SelectedContact = new ContactVM();
        IsApplyButtonVisible = true;
        
        IsReadOnlyMode = false;
        /*IsAddingNewContact = true;*/
    }

    /// <summary>
    /// Получает или задает значение, указывающее, находится ли приложение в режиме редактирования.
    /// </summary>
    public bool IsReadOnlyMode
    {
        get => _isReadOnlyMode;
        set
        {
            _isReadOnlyMode = value;
            OnPropertyChanged(nameof(IsReadOnlyMode));
        }
    }
    public void ApplyContact(object parameter)
    {
        if (SelectedContact != null)
        {
            if (!Contacts.Contains(SelectedContact))
            {
                Contacts.Add(SelectedContact);
            }
            IsApplyButtonVisible = false;
            /*ContactSerializer.SaveContacts(Contacts);*/
            IsApplyButtonVisible = false;
            IsReadOnlyMode = true;
            /*IsAddingNewContact = false;*/
            IsEditingContact = false;
        }
    }
    public bool IsContactSelected => _selectedContact != null;
    private bool CanAddContact(object parameter) => !IsApplyButtonVisible;

    private bool CanEditContact(object parameter) => IsContactSelected && !IsApplyButtonVisible;

    private bool CanRemoveContact(object parameter) => IsContactSelected && !IsApplyButtonVisible;
    private bool CanApplyContact(object parameter) => IsApplyButtonVisible;
    /*public bool IsReadOnly => !_isEditing;
    public bool CanEdit => SelectedContact != null && !_isEditing;
    public bool CanRemove => SelectedContact != null && !_isEditing;
    public Visibility IsApplyVisible => _isEditing ? Visibility.Visible : Visibility.Collapsed;*/

    private bool _isApplyButtonVisible;
    public bool IsApplyButtonVisible
    {
        get => _isApplyButtonVisible;
        set
        {
            _isApplyButtonVisible = value;
            OnPropertyChanged(nameof(IsApplyButtonVisible));
        }
    }
    public ContactVM SelectedContact
    {
        get => _selectedContact;
        set
        {
            if (_isEditing) CancelEdit();
            _selectedContact = value;
            OnPropertyChanged(nameof(SelectedContact));
            OnPropertyChanged(nameof(IsContactSelected));
            OnPropertyChanged(nameof(IsApplyButtonVisible));
        }
    }
    private void CancelEdit()
    {
        _isEditing = false;
        /*OnPropertyChanged(nameof(IsReadOnly));
        OnPropertyChanged(nameof(IsApplyVisible));*/
    }

/*    private void ApplyChanges()
    {
        if (!Contacts.Contains(SelectedContact))
        {
            Contacts.Add(SelectedContact);
        }
        _isEditing = false;
        *//*SaveContacts();*//*
        OnPropertyChanged(nameof(IsReadOnly));
        OnPropertyChanged(nameof(IsApplyVisible));
        UpdateCommands();
    }*/

   /* // Новый метод для обновления состояния команд
    private void UpdateCommands()
    {
        (AddCommand as RelayCommand)?.RaiseCanExecuteChanged();
        (EditCommand as RelayCommand)?.RaiseCanExecuteChanged();
        (RemoveCommand as RelayCommand)?.RaiseCanExecuteChanged();
        (ApplyCommand as RelayCommand)?.RaiseCanExecuteChanged();
    }*/

    /// <summary>
    /// Событие, уведомляющее об изменениях в свойствах.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<ContactVM> Contacts { get; set; }

    /// <summary>
    /// Возвращает и задает текущий контакт.
    /// </summary>
    public Contact CurrentContact
    {
        get => _currentContact;
        set
        {
            if (_currentContact == value)
            {
                return;
            }

            _currentContact = value;
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(PhoneNumber));
            OnPropertyChanged(nameof(Email));
        }
    }

    /// <summary>
    /// Возвращает и задает текущее имя контакта.
    /// </summary>
    public string Name
    {
        get => _currentContact.Name;
        set
        {
            if (_currentContact.Name == value)
            {
                return;
            }

            _currentContact.Name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    /// <summary>
    /// Возвращает и задает текущий номер телефона контакта.
    /// </summary>
    public string PhoneNumber
    {
        get => _currentContact.PhoneNumber;
        set
        {
            if (_currentContact.PhoneNumber == value)
            {
                return;
            }

            _currentContact.PhoneNumber = value;
            OnPropertyChanged(nameof(PhoneNumber));
        }
    }

    /// <summary>
    /// Возвращает и задает текущую почту контакта.
    /// </summary>
    public string Email
    {
        get => _currentContact.Email;
        set
        {
            if (_currentContact.Email == value)
            {
                return;
            }

            _currentContact.Email = value;
            OnPropertyChanged(nameof(Email));
        }
    }

    /// <summary>
    /// Команда для сохранения контакта.
    /// </summary>
    public SaveCommand SaveCommand { get; }

    /// <summary>
    /// Команда для загрузки контакта.
    /// </summary>
    public LoadCommand LoadCommand { get; }

    /// <summary>
    /// Вызывает событие <see cref="PropertyChanged"/> для обновления интерфейса.
    /// </summary>
    /// <param name="propertyName">Имя измененного свойства.</param>
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <summary>
    /// Обновляет текущий контакт новыми данными.
    /// </summary>
    /// <param name="contact">Загруженный контакт.</param>
    private void UpdateContact(Contact contact)
    {
        if (contact == null)
        {
            return;
        }

        CurrentContact = contact;
    }
}

