using System.Xml.Linq;

public class Discipline
{
    //����
    private string _name;
    private int _hoursInGeneral;
    private int _assessment;
    private string _teacherSurname;
    //�������� � ������������
    public string Name { get; set; }
    public int HoursInGeneral
    {
        get
        {
            return _hoursInGeneral;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("���� ������������!");
            }
            _hoursInGeneral = value;
        }
    }
    public int Assessment
    {
        get
        {
            return _assessment;
        }
        set
        {
            if(value<2 | value > 5)
            {
                throw new ArgumentException("������ �� 2 �� 5!");
            }
            _assessment = value;
        }
    }
    public string TeacherSurname { get; set; }
    
    //�����������
    public Discipline()
    {
        Name = "None";
        HoursInGeneral = 0;
        Assessment = 0;
        TeacherSurname = "None";
    }
    public Discipline(string name, int hoursInGeneral, int assessment,string teacherSurname)
    {
        Name = name;
        HoursInGeneral = hoursInGeneral;
        Assessment = assessment;
        TeacherSurname = teacherSurname;
    }
}