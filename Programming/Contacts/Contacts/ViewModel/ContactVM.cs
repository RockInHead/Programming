using System.ComponentModel;

public class ContactVM : INotifyPropertyChanged
{
    private Contact _contact;

    public ContactVM()
    {
        _contact = new Contact();
    }

    public ContactVM(Contact contact)
    {
        _contact = contact;
    }

    public string Name
    {
        get => _contact.Name;
        set
        {
            if (_contact.Name != value)
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    public string PhoneNumber
    {
        get => _contact.PhoneNumber;
        set
        {
            if (_contact.PhoneNumber != value)
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }
    }

    public string Email
    {
        get => _contact.Email;
        set
        {
            if (_contact.Email != value)
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
