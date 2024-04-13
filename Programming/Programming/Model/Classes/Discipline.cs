using System.Xml.Linq;
/// <summary>
/// ������ ������ � ����������:��������,����� ���-�� �����,������,������� �������.
/// </summary>
public class Discipline
{
    //����
    /// <summary>
    /// �������� ���������� - string.
    /// </summary>
    private string _name;
    /// <summary>
    /// ����� ���-�� ����� �� ���������� - int.
    /// </summary>
    private int _hoursInGeneral;
    /// <summary>
    /// ������ �� ���������� - int.
    /// </summary>
    private int _assessment;
    /// <summary>
    /// ������� ������� �� ��������� - string.
    /// </summary>
    private string _teacherSurname;

    //�������� � ������������
    /// <summary>
    /// ���������� � ������ �������� ����������.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// ���������� � ������ ����� ���-�� ����� �� ����������.������ ���� ������������� ������.
    /// </summary>
    public int HoursInGeneral
    {
        get
        {
            return _hoursInGeneral;
        }
        set
        {
         
            Validator.AssertOnPositiveValue(value);
            _hoursInGeneral = value;
        }
    }
    /// <summary>
    /// ���������� � ������ ������ �� ����������.������ ���� ������������� ������.
    /// </summary>
    public int Assessment
    {
        get
        {
            return _assessment;
        }
        set
        {
            /*if(value<2 | value > 5)
            {
                throw new ArgumentException("������ �� 2 �� 5!");
            }*/
            Validator.AssertOnPositiveValue(value);
            _assessment = value;
        }
    }
    /// <summary>
    /// ���������� � ������ ������� ������� �� ����������.
    /// </summary>
    public string TeacherSurname { get; set; }

    //�����������
    /// <summary>
    /// ������� ������/��������� ��������� ������.���� ����� ������������� �������� �� ���������.
    /// </summary>
    public Discipline()
    {
        Name = "None";
        HoursInGeneral = 0;
        Assessment = 0;
        TeacherSurname = "None";
    }
    /// <summary>
    /// ������� ��������� ������.
    /// </summary>
    /// <param name="name">�������� ����������</param>
    /// <param name="hoursInGeneral">����� ���-�� ����� �� ����������.������ ���� �������������.</param>
    /// <param name="assessment">������.������ ���� �������������.</param>
    /// <param name="teacherSurname">������� ������� �� ����������.</param>
    public Discipline(string name, int hoursInGeneral, int assessment,string teacherSurname)
    {
        Name = name;
        HoursInGeneral = hoursInGeneral;
        Assessment = assessment;
        TeacherSurname = teacherSurname;
    }
}