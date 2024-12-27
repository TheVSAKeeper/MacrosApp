using MacrosApp.Gui;

namespace MacrosApp.Core;

public abstract record MyAction
{
    public double Delay { get; init; }
    public int Count { get; init; }

    // TODO: Подумать над логированием
    public abstract void Perform(double beforeActionDelay = 1, double beforePerformDelay = 0, Action<string>? log = null);

    // TODO: Происходит смешивание бизнес логики с логикой отображения
    public void FillHistoryElement(MacrosHistoryElemControl item)
    {
        item.Count = Count;
        item.Delay = Delay;
        item.Tag = this;

        FillHistoryElementInner(item);
    }

    public MyAction Update(MacrosHistoryElemControl historyElemControl)
    {
        return UpdateInner(historyElemControl) with
        {
            Count = historyElemControl.Count,
            Delay = historyElemControl.Delay,
        };
    }

    // Альтернативный вариант - виртуальный метод с вызовом базового в дочерних
    protected abstract void FillHistoryElementInner(MacrosHistoryElemControl item);
    protected abstract MyAction UpdateInner(MacrosHistoryElemControl historyElemControl);
}
