using System.ComponentModel;

public class MainVM : INotifyPropertyChanged
{
    private Contact _contact = new Contact();

    public Contact Contact {get;set;}
    public string Name
    {
        get
        {
            return _contact.Name;
        }
        set
        {
            _contact.Name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }

    public string PhoneNumber
    {
        get
        {
            return _contact.PhoneNumber;
        }
        set
        {
            _contact.PhoneNumber = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PhoneNumber)));
        }
    }

    public string Email
    {
        get
        {
            return _contact.Email;
        }
        set
        {
            _contact.Email = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;
}

