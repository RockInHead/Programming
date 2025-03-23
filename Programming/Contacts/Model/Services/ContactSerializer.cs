using Newtonsoft.Json;
using Contacts.Model;

/// <summary>
/// Предоставляет методы для сериализации и десериализации списка контактов в формате JSON.
/// </summary>
public static class ContactSerializer
{
    /// <summary>
    /// Путь к файлу, в который сохраняются контакты.
    /// </summary>
    private static string _filePath;

    /// <summary>
    /// Устанавливает путь к файлу по умолчанию и создаёт каталог, если он отсутствует.
    /// </summary>
    public static void CreateDirectory()
    {
        _filePath = Path.Combine(Environment.GetFolderPath
                                (Environment.SpecialFolder.MyDocuments),
                                "Contacts",
                                "contacts.json");
        var directory = Path.GetDirectoryName(_filePath);
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
    }

    /// <summary>
    /// Сохраняет список контактов в файл в формате JSON.
    /// </summary>
    /// <param name="contacts">Список контактов для сохранения.</param>
    public static void SaveContacts(IEnumerable<Contact> contacts)
    {
        if (contacts == null)
        {
            throw new ArgumentNullException(nameof(contacts), "Контакт не может быть null.");
        }

        CreateDirectory();
        var json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
        File.WriteAllText(_filePath, json);
    }

    /// <summary>
    /// Загружает список контактов из файла JSON.
    /// </summary>
    /// <returns>
    /// Возвращает список контактов, если файл существует и успешно десериализован.
    /// В противном случае возвращает пустой список.
    /// </returns>
    public static List<Contact> LoadContacts()
    {
        if (!File.Exists(_filePath))
        {
            CreateDirectory();
        }

        var json = File.ReadAllText(_filePath);
        return JsonConvert.DeserializeObject<List<Contact>>(json);
    }
}
