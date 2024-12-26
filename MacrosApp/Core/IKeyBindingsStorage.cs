namespace MacrosApp.Core;

public interface IKeyBindingsStorage
{
    string FileFormat { get; }
    void Save(IReadOnlyDictionary<ControlKey, Keys> keyBindings);
    IReadOnlyDictionary<ControlKey, Keys> Load();
}
