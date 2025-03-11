using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;

/// <summary>
/// Основная модель представления для управления контактами и их сохранением/загрузкой.
/// </summary>
public class MainVM : INotifyPropertyChanged
{
    /// <summary>
    /// Выбранный контакт для редактирования.
    /// </summary>
    private Contact _selectedContact;

    /// <summary>
    /// Значение, указывающее, находятся ли поля доступными только для чтения.
    /// </summary>
    private bool _isReadOnlyMode = true;

    private Contact _originalContact;

    /// <summary>
    /// Инициализирует новый экземпляр <see cref="MainVM"/>.
    /// </summary>
    public MainVM()
    {
        ContactSerializer.CreateDirectory();
        Contacts = new ObservableCollection<Contact>(ContactSerializer.LoadContacts());
        AddCommand = new RelayCommand(AddContact, CanAddContact);
        EditCommand = new RelayCommand(EditContact, CanEditContact);
        RemoveCommand = new RelayCommand(RemoveContact, CanRemoveContact);
        ApplyCommand = new RelayCommand(ApplyContact, CanApplyContact);
    }

    /// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged"/>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
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
    public ICommand ApplyCommand { get; }

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
    public bool IsReadOnlyMode
    {
        get => _isReadOnlyMode;
        set
        {
            _isReadOnlyMode = value;
            OnPropertyChanged(nameof(IsReadOnlyMode));
            OnPropertyChanged(nameof(IsAddOrEditMode));
        }
    }

    /// <summary>
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
    }

    /// <summary>
    /// Проверяет, выбран ли контакт.
    /// </summary>
    public bool IsContactSelected => _selectedContact != null;

    /// <summary>
    /// Редактирует выбранный контакт.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    public void EditContact(object parameter)
    {
        /*IsReadOnlyMode = false;*/
        _originalContact = (Contact)SelectedContact.Clone();
        IsReadOnlyMode = false;
    }

    /// <summary>
    /// Удаляет выбранный контакт.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
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

    /// <summary>
    /// Вызывает событие PropertyChanged для уведомления об изменении свойства.
    /// </summary>
    /// <param name="propertyName">Имя измененного свойства.</param>
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <summary>
    /// Отменяет редактирование контакта.
    /// </summary>
    private void CancelEdit()
    {
        if (_originalContact != null)
        {
            SelectedContact.Name = _originalContact.Name;
            SelectedContact.PhoneNumber = _originalContact.PhoneNumber;
            SelectedContact.Email = _originalContact.Email;
        }

        IsReadOnlyMode = true;
        OnPropertyChanged(nameof(IsReadOnlyMode));
        OnPropertyChanged(nameof(IsAddOrEditMode));
    }

    /// <summary>
    /// Проверяет, можно ли добавить контакт.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    /// <returns>Возвращает <c>true</c>, если контакт можно добавить; иначе <c>false</c>.</returns>
    private bool CanAddContact(object parameter) => !IsAddOrEditMode;

    /// <summary>
    /// Проверяет, можно ли редактировать выбранный контакт.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    /// <returns>Возвращает <c>true</c>, если контакт можно редактировать; иначе <c>false</c>.</returns>
    private bool CanEditContact(object parameter) => IsContactSelected && !IsAddOrEditMode;

    /// <summary>
    /// Проверяет, можно ли удалить выбранный контакт.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    /// <returns>Возвращает <c>true</c>, если контакт можно удалить; иначе <c>false</c>.</returns>
    private bool CanRemoveContact(object parameter) => IsContactSelected && !IsAddOrEditMode;

    /// <summary>
    /// Проверяет, можно ли применить изменения для выбранного контакта.
    /// </summary>
    /// <param name="parameter">Параметр команды.</param>
    /// <returns>Возвращает <c>true</c>, если изменения можно применить; иначе <c>false</c>.</returns>
    private bool CanApplyContact(object parameter) => IsAddOrEditMode && !HasValidationErrors;

    /// <summary>
    /// Свойство, указывающее, есть ли ошибки валидации.
    /// </summary>
    public bool HasValidationErrors => SelectedContact != null &&
                                       (!string.IsNullOrEmpty(SelectedContact["Name"]) ||
                                        !string.IsNullOrEmpty(SelectedContact["PhoneNumber"]) ||
                                        !string.IsNullOrEmpty(SelectedContact["Email"]));
}