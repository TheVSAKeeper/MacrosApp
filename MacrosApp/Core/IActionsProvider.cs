namespace MacrosApp.Core;

public interface IActionsProvider
{
    void Save(IEnumerable<MyAction> actions, string path);
    IEnumerable<MyAction>? Load(string path);
}
