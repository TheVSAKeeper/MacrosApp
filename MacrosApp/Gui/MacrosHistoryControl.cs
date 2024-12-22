using MacrosApp.Core;
using Newtonsoft.Json;

namespace MacrosApp.Gui;

public partial class MacrosHistoryControl : UserControl
{
    private readonly Dictionary<MouseButtons, string> _mouseButtons;
    private int _currentId;

    public MacrosHistoryControl()
    {
        InitializeComponent();

        _mouseButtons = new Dictionary<MouseButtons, string>
        {
            { MouseButtons.Left, "l" },
            { MouseButtons.Right, "r" },
        };
    }

    public void AddAction(MyAction action)
    {
        _currentId++;

        MacrosHistoryElemControl item = new();
        item.Count = action.Count;
        item.Delay = action.Delay;
        item.Tag = _currentId.ToString();
        item.Left = 0;
        item.Top = (_currentId - 1) * item.Height;
        item.TypeText = action.TypeText;

        switch (action)
        {
            case MouseAction mouseAction:
                item.X = mouseAction.X;
                item.Y = mouseAction.Y;
                item.Button = _mouseButtons[mouseAction.Button];
                break;

            case KeyboardAction keyboardAction:
                item.Button = keyboardAction.KeyValue.ToString();
                break;

            default:
                throw new Exception("unrecognized type");
        }

        panel1.Controls.Add(item);
    }

    public void ClearActions()
    {
        panel1.Controls.Clear();
        _currentId = 0;
    }

    public List<MyAction> GetActions()
    {
        MouseAction mouseHint = new();
        List<MyAction> actions = new();

        foreach (Control control in panel1.Controls)
        {
            if (control is not MacrosHistoryElemControl historyElemControl)
            {
                continue;
            }

            MyAction myAction;

            if (historyElemControl.TypeText == mouseHint.TypeText)
            {
                MouseAction action = new()
                {
                    X = historyElemControl.X,
                    Y = historyElemControl.Y,
                    Button = _mouseButtons.Single(x => x.Value == historyElemControl.Button).Key,
                };

                myAction = action;
            }
            else
            {
                KeyboardAction action = new()
                {
                    KeyValue = int.Parse(historyElemControl.Button),
                };

                myAction = action;
            }

            myAction.Count = historyElemControl.Count;
            myAction.Delay = historyElemControl.Delay;
            actions.Add(myAction);
        }

        return actions;
    }

    private void uiSaveButton_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
        {
            return;
        }

        List<MyAction> actions = GetActions();

        string filename = saveFileDialog1.FileName;

        JsonSerializerSettings settings = new()
        {
            TypeNameHandling = TypeNameHandling.Objects,
        };

        string jsonString = JsonConvert.SerializeObject(actions, settings);
        File.WriteAllText(filename, jsonString);
    }

    private void uiLoadButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
        {
            return;
        }

        string filename = openFileDialog1.FileName;
        string fileText = File.ReadAllText(filename);

        JsonSerializerSettings settings = new()
        {
            TypeNameHandling = TypeNameHandling.Objects,
        };

        MyAction[]? actions = JsonConvert.DeserializeObject<MyAction[]>(fileText, settings);

        if (actions == null)
        {
            MessageBox.Show("Не удалось десериализовать действия.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ClearActions();

        foreach (MyAction action in actions)
        {
            AddAction(action);
        }
    }
}
