public class Contact
{
    private string _name;
    private int _phoneNumber;
    private string _desription;

    public string Name { get; set; }
    public int PhoneNumber
    {
        get
        {
            return _phoneNumber;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            _phoneNumber = value;
        }
    }
    public string Desription { get; set; }
}