using MacrosApp.Core;

namespace MacrosApp.Gui;

public partial class MacrosHistoryControl : UserControl
{
    private readonly IActionsProvider _actionsProvider;

    public MacrosHistoryControl()
    {
        InitializeComponent();
        _actionsProvider = new JsonActionsProvider();

        saveFileDialog1.Title = "Сохранить макросы";
        saveFileDialog1.Filter = $"Файлы макросов (*.{_actionsProvider.FileFormat})|*.{_actionsProvider.FileFormat}|Все файлы (*.*)|*.*";
        saveFileDialog1.DefaultExt = _actionsProvider.FileFormat;
        saveFileDialog1.AddExtension = true;

        openFileDialog1.Title = "Загрузить макросы";
        openFileDialog1.Filter = $"Файлы макросов (*.{_actionsProvider.FileFormat})|*.{_actionsProvider.FileFormat}|Все файлы (*.*)|*.*";
        openFileDialog1.DefaultExt = _actionsProvider.FileFormat;
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

        try
        {
            _actionsProvider.Save(actions, saveFileDialog1.FileName);
            MessageBox.Show($"Макросы успешно сохранены в файл: {saveFileDialog1.FileName}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception exception)
        {
            MessageBox.Show($"Ошибка при сохранении макросов: {exception.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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
            MessageBox.Show("Не удалось загрузить макросы. Пожалуйста, проверьте файл и попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ClearActions();

        foreach (MyAction action in actions)
        {
            AddAction(action);
        }

        MessageBox.Show($"Макросы успешно загружены из файла: {openFileDialog1.FileName}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
