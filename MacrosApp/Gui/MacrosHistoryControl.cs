using MacrosApp.Core;

namespace MacrosApp.Gui;

public partial class MacrosHistoryControl : UserControl
{
    private readonly IActionsProvider _actionsProvider;

    public MacrosHistoryControl()
    {
        InitializeComponent();
        _actionsProvider = new JsonActionsProvider();
    }

    public void AddAction(MyAction action)
    {
        MacrosHistoryElemControl item = new();
        action.FillHistoryElement(item);

        item.Left = 0;
        item.Top = panel1.Controls.Count * item.Height;

        panel1.Controls.Add(item);
    }

    public void ClearActions()
    {
        panel1.Controls.Clear();
    }

    public List<MyAction> GetActions()
    {
        List<MyAction> actions = [];

        foreach (Control control in panel1.Controls)
        {
            if (control is not MacrosHistoryElemControl historyElemControl)
            {
                continue;
            }

            if (historyElemControl.Tag is not MyAction myAction)
            {
                continue;
            }

            actions.Add(myAction.Update(historyElemControl));
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
        _actionsProvider.Save(actions, saveFileDialog1.FileName);
    }

    private void uiLoadButton_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
        {
            return;
        }

        IEnumerable<MyAction>? actions = _actionsProvider.Load(openFileDialog1.FileName);

        if (actions == null)
        {
            MessageBox.Show("Не удалось загрузить макросы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ClearActions();

        foreach (MyAction action in actions)
        {
            AddAction(action);
        }
    }
}
