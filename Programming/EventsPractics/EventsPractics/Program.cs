using EventsPractics.Model;

namespace EventsPractics
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Contact Contact = new Contact();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Contact = Contact;
            MainWindow secondaryForm = new MainWindow();
            MainWindow secondaryForm2 = new MainWindow();
            secondaryForm.Text = "Secondary Form";
            secondaryForm.Contact = Contact;
            secondaryForm.Show();
            secondaryForm2.Text = "Secondary Form";
            secondaryForm2.Contact = Contact;
            secondaryForm2.Show();
            Application.Run(mainWindow);
        }
    }
}