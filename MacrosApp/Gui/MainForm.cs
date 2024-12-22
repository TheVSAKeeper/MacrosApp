using MacrosApp.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MacrosApp.Gui;

internal partial class MainForm : Form
{
    private const int MOUSEEVENTF_LEFTDOWN = 0x02;
    private const int MOUSEEVENTF_LEFTUP = 0x04;
    private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
    private const int MOUSEEVENTF_RIGHTUP = 0x10;

    private const uint WM_KEYDOWN = 0x0100;

    private UserActivityHook _actHook;
    private int _lastMouseX;
    private int _lastMouseY;

    private bool _isStartMacros;
    private bool _isBreak;
    private DateTime _startDate;

    private List<MyAction> _myActions = [];

    public MainForm()
    {
        InitializeComponent();
    }

    private void MouseMoved(object? sender, MouseEventArgs e)
    {
        labelMousePosition.Text = $"x={e.X}  y={e.Y} wheel={e.Delta}";

        if (e.Clicks > 0)
        {
            LogWrite("MouseButton 	- " + e.Button);

            if (_isStartMacros)
            {
                MouseAction myAction = new()
                {
                    X = e.X,
                    Y = e.Y,
                    Button = e.Button,
                    Delay = (DateTime.Now - _startDate).TotalMilliseconds,
                    Count = 1,
                };

                uiMacrosHistoryControl.AddAction(myAction);
                _startDate = DateTime.Now;
            }
        }

        _lastMouseX = e.X;
        _lastMouseY = e.Y;
    }

    private void MyKeyDown(object? sender, KeyEventArgs e)
    {
        LogWrite("KeyDown 	- " + e.KeyData);
    }

    private void MyKeyPress(object? sender, KeyPressEventArgs e)
    {
        LogWrite("KeyPress 	- " + e.KeyChar);
    }

    private void MyKeyUp(object? sender, KeyEventArgs e)
    {
        LogWrite("KeyUp 		- " + e.KeyData);

        if (_isStartMacros && e.KeyCode != Keys.W)
        {
            KeyboardAction myAction = new()
            {
                Key = e.KeyCode,
                KeyValue = e.KeyValue,
                Delay = (DateTime.Now - _startDate).TotalMilliseconds,
                Count = 1,
            };

            uiMacrosHistoryControl.AddAction(myAction);
            _startDate = DateTime.Now;
        }

        switch (e.KeyCode)
        {
            case Keys.Q:
                e.Handled = true;
                _isStartMacros = true;
                uiMacrosHistoryControl.ClearActions();
                _startDate = DateTime.Now;
                _isBreak = true;
                break;

            case Keys.W:
                e.Handled = true;
                _isStartMacros = false;
                _isBreak = true;
                break;

            case Keys.E:
                _myActions = uiMacrosHistoryControl.GetActions();

                e.Handled = true;
                _isBreak = false;

                if (uiKuricaKormRadioButton.Checked
                    || uiDerevoRadioButton.Checked
                    || uiKuricaCustomRadioButton.Checked)
                {
                    Thread th = new(GoScriptKormKuricam);
                    th.Start();
                }
                else if (twoStepWithShiftRadioButton.Checked)
                {
                    Thread th = new(GoScriptTwoStepWithShift);
                    th.Start();
                }
                else if (uiClassicRadioButton.Checked)
                {
                    Thread th = new(GoScript);
                    th.Start();
                }
                else
                {
                    throw new NotImplementedException();
                }

                break;

            case Keys.S:
                e.Handled = true;
                _isBreak = true;
                break;
        }
    }

    private void ButtonStartClick(object sender, EventArgs e)
    {
        _actHook.Start();
    }

    private void ButtonStopClick(object sender, EventArgs e)
    {
        _actHook.Stop();
    }

    private void MainFormLoad(object sender, EventArgs e)
    {
        _actHook = new UserActivityHook();

        _actHook.OnMouseActivity += MouseMoved;
        _actHook.KeyDown += MyKeyDown;
        _actHook.KeyPress += MyKeyPress;
        _actHook.KeyUp += MyKeyUp;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        _actHook.OnMouseActivity -= MouseMoved;
        _actHook.KeyDown -= MyKeyDown;
        _actHook.KeyPress -= MyKeyPress;
        _actHook.KeyUp -= MyKeyUp;

        _actHook.Stop();
    }

    [LibraryImport("user32.dll")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    private static partial void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

    [LibraryImport("user32.dll")]
    private static partial IntPtr GetForegroundWindow();

    [LibraryImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static partial bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

    private void GoScriptTwoStepWithShift()
    {
        int step1Count = Convert.ToInt32(uiStep1CountTextBox.Text);
        int step2Count = Convert.ToInt32(uiStep2CountTextBox.Text);
        int shift = Convert.ToInt32(uiStep1ShiftCountTextBox.Text);
        int shift2 = Convert.ToInt32(uiStep2ShiftCountTextBox.Text);
        double delay = Convert.ToDouble(uiDelayTextBox.Text);
        double every = Convert.ToDouble(uiShiftEveryTextBox.Text);
        int mouseMoveClickDelay = Convert.ToInt32(mouseMoveClickDelayTextBox.Text);

        for (int iStep1 = 0; iStep1 < step1Count; iStep1++)
        {
            for (int iStep2 = 0; iStep2 < step2Count; iStep2++)
            {
                for (int iAction = 0; iAction < _myActions.Count; iAction++)
                {
                    if (_isBreak)
                    {
                        break;
                    }

                    MyAction myAction2 = _myActions[iAction];

                    switch (myAction2)
                    {
                        case MouseAction myAction:
                            int x = myAction.X;
                            int y = myAction.Y;

                            if ((iAction + 1) % every == 0)
                            {
                                x = x + iStep2 * shift + iStep1 * shift;
                                y = y + iStep2 * shift2 * -1 + iStep1 * shift2;
                            }

                            GoScriptMouseClick(myAction.Delay, myAction.Button, x, y, mouseMoveClickDelay, delay);
                            break;

                        case KeyboardAction myAction:
                            KeyboardCLick(delay, myAction);
                            break;
                    }
                }
            }
        }
    }

    private void GoScriptKormKuricam()
    {
        int step1Count = Convert.ToInt32(uiKuricaKormStep1CountTextBox.Text);
        int step2Count = Convert.ToInt32(uiKuricaKormStep2CountTextBox.Text);
        int mouseMoveClickDelay = Convert.ToInt32(mouseMoveClickDelayTextBox.Text);
        int x = _lastMouseX;
        int y = _lastMouseY;
        int step = 32;

        if (uiDerevoRadioButton.Checked)
        {
            step = 64;
        }
        else if (uiKuricaCustomRadioButton.Checked)
        {
            step = Convert.ToInt32(uiKuricaKormShiftTextBox.Text);
        }

        for (int iStep1 = 0; iStep1 < step1Count; iStep1++)
        {
            for (int iStep2 = 0; iStep2 < step2Count; iStep2++)
            {
                if (_isBreak)
                {
                    break;
                }

                int x1 = x + iStep2 * step + iStep1 * step;
                int y1 = y + iStep2 * step / 2 * -1 + iStep1 * step / 2;
                GoScriptMouseClick(100, MouseButtons.Left, x1, y1, mouseMoveClickDelay);
            }
        }
    }

    private void GoScript()
    {
        int stepCount = Convert.ToInt32(uiClassicStepCount.Text);
        int mouseMoveClickDelay = Convert.ToInt32(mouseMoveClickDelayTextBox.Text);
        double delay = Convert.ToDouble(uiDelayTextBox.Text);

        for (int i = 0; i < stepCount; i++)
        {
            foreach (MyAction myAction in _myActions)
            {
                for (int actionPiuPiu = 0; actionPiuPiu < myAction.Count; actionPiuPiu++)
                {
                    if (_isBreak)
                    {
                        break;
                    }

                    switch (myAction)
                    {
                        case MouseAction mouseAction:
                            int x = mouseAction.X;
                            int y = mouseAction.Y;

                            GoScriptMouseClick(mouseAction.Delay, mouseAction.Button, x, y, mouseMoveClickDelay, delay);
                            break;

                        case KeyboardAction keyboardAction:
                            KeyboardCLick(delay, keyboardAction);
                            break;
                    }
                }
            }
        }
    }

    private void KeyboardCLick(double delay, KeyboardAction myAction)
    {
        Thread.Sleep((int)(myAction.Delay * delay));
        IntPtr handle = GetForegroundWindow();
        LogWrite(handle.ToString());
        PostMessage(handle, WM_KEYDOWN, myAction.KeyValue, 0);
    }

    private void GoScriptMouseClick(double myActionWait, MouseButtons myActionButton, int x, int y, int mouseMoveClickDelay, double delay = 1)
    {
        Thread.Sleep((int)(myActionWait * delay));

        LogWrite("script MouseClick -> " + x + " - " + y);

        Cursor.Position = new Point(x, y);
        Thread.Sleep(mouseMoveClickDelay);

        switch (myActionButton)
        {
            case MouseButtons.Left:
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                break;

            case MouseButtons.Right:
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                break;
        }
    }

    private void LogWrite(string txt)
    {
        textBox.AppendText(txt + Environment.NewLine);
        textBox.SelectionStart = textBox.Text.Length;
    }
}
