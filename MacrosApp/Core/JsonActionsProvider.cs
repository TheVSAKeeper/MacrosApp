using Newtonsoft.Json;

namespace MacrosApp.Core;

public class JsonActionsProvider(JsonSerializerSettings? settings = null) : IActionsProvider
{
    private static readonly JsonSerializerSettings DefaultSettings = new()
    {
        TypeNameHandling = TypeNameHandling.Objects,
    };

    private readonly JsonSerializerSettings _settings = settings ?? DefaultSettings;

    public string FileFormat => "json";

    public void Save(IEnumerable<MyAction> actions, string path)
    {
        string jsonString = JsonConvert.SerializeObject(actions, _settings);
        File.WriteAllText(path, jsonString);
    }

    public IEnumerable<MyAction>? Load(string path)
    {
        string fileText = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<IEnumerable<MyAction>>(fileText, _settings);
    }
}
