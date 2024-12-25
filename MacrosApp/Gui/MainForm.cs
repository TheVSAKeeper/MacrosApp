using MacrosApp.Core;

namespace MacrosApp.Gui;

internal partial class MainForm : Form
{
    private readonly UserActivityHook _actHook = new();

    private readonly Dictionary<ControlKey, Keys> _keyBindings;
    private readonly IKeyBindingsStorage _keyBindingsStorage;

    private int _lastMouseX;
    private int _lastMouseY;

    private bool _isStartMacros;
    private bool _isBreak;
    private DateTime _startDate;

    private List<MyAction> _myActions = [];

    public MainForm()
    {
        InitializeComponent();

        _keyBindingsStorage = new JsonKeyBindingsStorage("keybindings.json");
        _keyBindings = _keyBindingsStorage.Load().ToDictionary();

        if (_keyBindings.Count == 0)
        {
            _keyBindings = new Dictionary<ControlKey, Keys>
            {
                [ControlKey.StartMacros] = Keys.Q,
                [ControlKey.StopMacros] = Keys.W,
                [ControlKey.ExecuteScript] = Keys.E,
                [ControlKey.BreakAction] = Keys.S,
            };

            _keyBindingsStorage.Save(_keyBindings);
        }

        Load += OnFormLoad;
        FormClosing += OnFormClosing;
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        Load -= OnFormLoad;
        FormClosing -= OnFormClosing;
    }

    private void MouseMoved(object? sender, MouseEventArgs e)
    {
        labelMousePosition.Text = $"x={e.X}  y={e.Y} wheel={e.Delta}";

        if (e.Clicks > 0)
        {
            LogWrite("MouseButton", e.Button.ToString());

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

    private void OnKeyDown(object? sender, KeyEventArgs e)
    {
        LogWrite("KeyDown", e.KeyData.ToString());
    }

    private void OnKeyPress(object? sender, KeyPressEventArgs e)
    {
        LogWrite("KeyPress", e.KeyChar.ToString());
    }

    private void OnKeyUp(object? sender, KeyEventArgs e)
    {
        LogWrite("KeyUp", e.KeyData.ToString());

        foreach (KeyValuePair<ControlKey, Keys> action in _keyBindings.Where(action => e.KeyCode == action.Value))
        {
            ExecuteAction(action.Key);
            e.Handled = true;
            return;
        }

        if (_isStartMacros)
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
    }

    private void ButtonStartClick(object sender, EventArgs e)
    {
        _actHook.Start();
    }

    private void ButtonStopClick(object sender, EventArgs e)
    {
        _actHook.Stop();
    }

    private void OnFormLoad(object? sender, EventArgs e)
    {
        _actHook.OnMouseActivity += MouseMoved;
        _actHook.KeyDown += OnKeyDown;
        _actHook.KeyPress += OnKeyPress;
        _actHook.KeyUp += OnKeyUp;
    }

    private void OnFormClosing(object? sender, FormClosingEventArgs e)
    {
        _actHook.OnMouseActivity -= MouseMoved;
        _actHook.KeyDown -= OnKeyDown;
        _actHook.KeyPress -= OnKeyPress;
        _actHook.KeyUp -= OnKeyUp;

        _actHook.Stop();
    }

    private void ExecuteAction(ControlKey action)
    {
        switch (action)
        {
            case ControlKey.StartMacros:
                _isStartMacros = true;
                uiMacrosHistoryControl.ClearActions();
                _startDate = DateTime.Now;
                _isBreak = true;
                break;

            case ControlKey.StopMacros:
                _isStartMacros = false;
                _isBreak = true;
                break;

            case ControlKey.ExecuteScript:
                _myActions = uiMacrosHistoryControl.GetActions();
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

            case ControlKey.BreakAction:
                _isBreak = true;
                break;

            default:
                throw new NotImplementedException($"Действие {action} не реализовано.");
        }
    }

    private void GoScriptTwoStepWithShift()
    {
        int step1Count = Convert.ToInt32(uiStep1CountTextBox.Text);
        int step2Count = Convert.ToInt32(uiStep2CountTextBox.Text);
        int shift = Convert.ToInt32(uiStep1ShiftCountTextBox.Text);
        int shift2 = Convert.ToInt32(uiStep2ShiftCountTextBox.Text);
        int delay = Convert.ToInt32(uiDelayTextBox.Text);
        int every = Convert.ToInt32(uiShiftEveryTextBox.Text);
        int mouseMoveClickDelay = Convert.ToInt32(mouseMoveClickDelayTextBox.Text);

        for (int iStep1 = 0; iStep1 < step1Count; iStep1++)
        {
            for (int iStep2 = 0; iStep2 < step2Count; iStep2++)
            {
                for (int iAction = 0; iAction < _myActions.Count; iAction++)
                {
                    if (_isBreak)
                    {
                        // TODO: return; ?
                        break;
                    }

                    switch (_myActions[iAction])
                    {
                        case MouseAction myAction:

                            if ((iAction + 1) % every == 0)
                            {
                                myAction = myAction with
                                {
                                    X = myAction.X + iStep2 * shift + iStep1 * shift,
                                    Y = myAction.Y + iStep2 * shift2 * -1 + iStep1 * shift2,
                                };
                            }

                            myAction.Perform(mouseMoveClickDelay, delay, LogWrite);
                            break;

                        case KeyboardAction myAction:
                            myAction.Perform(delay, log: LogWrite);
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
        int step;

        if (uiDerevoRadioButton.Checked)
        {
            step = 64;
        }
        else if (uiKuricaCustomRadioButton.Checked)
        {
            step = Convert.ToInt32(uiKuricaKormShiftTextBox.Text);
        }
        else
        {
            step = 32;
        }

        for (int iStep1 = 0; iStep1 < step1Count; iStep1++)
        {
            for (int iStep2 = 0; iStep2 < step2Count; iStep2++)
            {
                if (_isBreak)
                {
                    // TODO: return; ?
                    break;
                }

                MouseAction action = new()
                {
                    X = x + iStep2 * step + iStep1 * step,
                    Y = y + iStep2 * step / 2 * -1 + iStep1 * step / 2,
                    Button = MouseButtons.Left,
                    Delay = 100,
                };

                action.Perform(beforePerformDelay: mouseMoveClickDelay);
            }
        }
    }

    private void GoScript()
    {
        int stepCount = Convert.ToInt32(uiClassicStepCount.Text);
        int mouseMoveClickDelay = Convert.ToInt32(mouseMoveClickDelayTextBox.Text);
        int delay = Convert.ToInt32(uiDelayTextBox.Text);

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

                    myAction.Perform(delay, mouseMoveClickDelay, LogWrite);
                }
            }
        }
    }

    private void LogWrite(string message)
    {
        textBox.AppendText(message + Environment.NewLine);
        textBox.SelectionStart = textBox.Text.Length;
    }

    private void LogWrite(string caption, string message)
    {
        LogWrite(caption.PadRight(12) + " - " + message + Environment.NewLine);
    }
}
