using System.IO;
using Newtonsoft.Json;

/// <summary>
/// Предоставляет методы для сериализации и десериализации списка контактов в формате JSON.
/// </summary>
public static class ContactSerializer
{
    /// <summary>
    /// Путь к файлу, в который сохраняются контакты.
    /// </summary>
    private static readonly string _filePath;

    /// <summary>
    /// Статический конструктор для инициализации пути к файлу.
    /// </summary>
    static ContactSerializer()
    {
        var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var contactsFolder = Path.Combine(appDataPath, "Contacts");
        Directory.CreateDirectory(contactsFolder);
        _filePath = Path.Combine(contactsFolder, "contacts.json");
    }

    /// <summary>
    /// Сохраняет список контактов в файл в формате JSON.
    /// </summary>
    /// <param name="contacts">Список контактов для сохранения.</param>
    public static void SaveContacts(IEnumerable<Contact> contacts)
    {
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
        if (File.Exists(_filePath))
        {
            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Contact>>(json);
        }

        return new List<Contact>();
    }
}
