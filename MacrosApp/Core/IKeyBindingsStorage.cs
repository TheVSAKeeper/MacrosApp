namespace MacrosApp.Core;

public interface IKeyBindingsStorage
{
    void Save(IReadOnlyDictionary<ControlKey, Keys> keyBindings);
    IReadOnlyDictionary<ControlKey, Keys> Load();
}
