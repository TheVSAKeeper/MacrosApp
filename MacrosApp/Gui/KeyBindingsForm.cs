using MacrosApp.Core;

namespace MacrosApp.Gui;

public class KeyBindingsForm : Form
{
    public KeyBindingsForm(Dictionary<ControlKey, Keys> keyBindings)
    {
        Size = new Size(300, 400);

        DataGridView dataGridView = new()
        {
            Dock = DockStyle.Fill,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            Font = new Font("Arial", 12, FontStyle.Regular),
            AllowUserToAddRows = false,
            ReadOnly = true,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false,
        };

        dataGridView.Columns.Add("Action", "Действие");
        dataGridView.Columns.Add("Key", "Клавиша");

        foreach ((ControlKey key, Keys value) in keyBindings)
        {
            dataGridView.Rows.Add(key.ToString(), value.ToString());
        }

        Controls.Add(dataGridView);

        Button closeButton = new()
        {
            Text = "Закрыть",
            Dock = DockStyle.Bottom,
            Height = 40,
        };

        closeButton.Click += (_, _) => Close();
        Controls.Add(closeButton);
    }

    private void InitializeComponent()
    {

    }
}
