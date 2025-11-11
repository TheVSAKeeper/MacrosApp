using MacrosApp.Gui;
using System.Runtime.InteropServices;

namespace MacrosApp.Core;

public partial record KeyboardAction : MyAction
{
    public Keys Key { get; init; }
    public int KeyValue { get; init; }

    public override void Perform(double beforeActionDelay = 1, double beforePerformDelay = 0, Action<string>? log = null)
    {
        Thread.Sleep((int)(Delay * beforeActionDelay));

        SendKeys.SendWait(((char)KeyValue).ToString());
    }

    protected override MyAction UpdateInner(MacrosHistoryElemControl historyElemControl)
    {
        return this with
        {
            KeyValue = int.Parse(historyElemControl.Button),
        };
    }

    protected override void FillHistoryElementInner(MacrosHistoryElemControl item)
    {
        item.Button = KeyValue.ToString();
    }
}
