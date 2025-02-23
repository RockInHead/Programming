using System.IO;
using Newtonsoft.Json;

/// <summary>
/// Статический класс для сериализации и десериализации контактов в JSON-файл.
/// </summary>
static public class ContactSerializer
{
    /// <summary>
    /// Полный путь к файлу, в котором хранятся контакты.
    /// </summary>
    static private string _filePath;

    /// <summary>
    /// Устанавливает путь к файлу по умолчанию и создаёт каталог, если он отсутствует.
    /// </summary>
    static public void CreateDirectory()
    {
        _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts", "contacts.json");
        string directory = Path.GetDirectoryName(_filePath);

        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
    }

    /// <summary>
    /// Сериализует контакт и сохраняет его в файл.
    /// </summary>
    /// <param name="contact">Объект контакта для сохранения.</param>
    static public void SaveContact(Contact contact)
    {
        if (contact == null)
        {
            throw new ArgumentNullException(nameof(contact), "Контакт не может быть null.");
        }

        string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
        File.WriteAllText(_filePath, json);
    }

    /// <summary>
    /// Загружает контакт из файла.
    /// </summary>
    /// <returns>Объект <see cref="Contact"/>, если файл существует, иначе null.</returns>
    static public Contact LoadContact()
    {
        if (!File.Exists(_filePath))
        {
            return null;
        }

        string json = File.ReadAllText(_filePath);
        return JsonConvert.DeserializeObject<Contact>(json);
    }
}


