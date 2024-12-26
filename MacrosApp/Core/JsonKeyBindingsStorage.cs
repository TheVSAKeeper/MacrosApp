using System.Text.Json;

namespace MacrosApp.Core;

public class JsonKeyBindingsStorage : IKeyBindingsStorage
{
    private readonly JsonSerializerOptions _jsonSerializerOptions = new()
    {
        WriteIndented = true,
    };

    private readonly string _filePath;

    public JsonKeyBindingsStorage(string filePath)
    {
        _filePath = $"{filePath}.{FileFormat}";
    }

    public string FileFormat => "json";

    public void Save(IReadOnlyDictionary<ControlKey, Keys> keyBindings)
    {
        Dictionary<string, string> keyBindingsForSave = keyBindings
            .ToDictionary(x => x.Key.ToString(), x => x.Value.ToString());

        string json = JsonSerializer.Serialize(keyBindingsForSave, _jsonSerializerOptions);
        File.WriteAllText(_filePath, json);
    }

    public IReadOnlyDictionary<ControlKey, Keys> Load()
    {
        if (File.Exists(_filePath) == false)
        {
            return new Dictionary<ControlKey, Keys>();
        }

        string json = File.ReadAllText(_filePath);
        Dictionary<string, string>? keyBindingsFromFile = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

        return keyBindingsFromFile?
                   .ToDictionary(x => Enum.Parse<ControlKey>(x.Key), x => (Keys)Enum.Parse(typeof(Keys), x.Value))
               ?? new Dictionary<ControlKey, Keys>();
    }
}
