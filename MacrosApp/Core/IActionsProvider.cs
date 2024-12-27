namespace MacrosApp.Core;

public interface IActionsProvider
{
    string FileFormat { get; }
    void Save(IEnumerable<MyAction> actions, string path);
    IEnumerable<MyAction>? Load(string path);
}
