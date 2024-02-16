using System.Reflection;
namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            IntTextBox.Clear();
            switch (EnumsListBox.SelectedIndex)
            {
                case 0:                   
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Color)).Cast<object>().ToArray());
                    break;
                case 1:                   
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(EducationForm)).Cast<object>().ToArray());
                    break;
                case 2:                   
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Genre)).Cast<object>().ToArray());
                    break;
                case 3:                
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Manufactures)).Cast<object>().ToArray());
                    break;
                case 4:                    
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
                    break;
                case 5: 
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Weekday)).Cast<object>().ToArray());
                    break;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text=ValuesListBox.SelectedIndex.ToString();
        }
    }
}
