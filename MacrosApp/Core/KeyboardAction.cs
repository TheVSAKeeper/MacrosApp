using MacrosApp.Gui;
using System.Runtime.InteropServices;

namespace MacrosApp.Core;

public partial record KeyboardAction : MyAction
{
    private const uint WM_KEYDOWN = 0x0100;

    public Keys Key { get; init; }
    public int KeyValue { get; init; }

    public override void Perform(double beforeActionDelay = 1, double beforePerformDelay = 0, Action<string>? log = null)
    {
        Thread.Sleep((int)(Delay * beforeActionDelay));
        IntPtr handle = GetForegroundWindow();

        log?.Invoke(handle.ToString());

        // Thread.Sleep((int)beforePerformDelay);
        PostMessage(handle, WM_KEYDOWN, KeyValue, 0);
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

    [LibraryImport("user32.dll")]
    private static partial IntPtr GetForegroundWindow();

    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
}
