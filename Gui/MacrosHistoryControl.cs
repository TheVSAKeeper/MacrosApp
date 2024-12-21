using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MacrosApp.Core;

namespace MacrosApp
{
    public partial class MacrosHistoryControl : UserControl
    {
        private int _currentId = 0;
        private Dictionary<MouseButtons, string> _mouseButtons;
        public MacrosHistoryControl()
        {
            InitializeComponent();
            _mouseButtons = new Dictionary<MouseButtons, string>
            {
                { MouseButtons.Left, "l" },
                { MouseButtons.Right, "r" }
            };
        }

        public void AddAction(MyAction action)
        {
            _currentId++;

            var item = new MacrosHistoryElemControl();
            item.Count = action.Count;
            item.Delay = action.Delay;
            item.Tag = _currentId.ToString();
            item.Left = 0;
            item.Top = _currentId * item.Height;
            item.TypeText = action.TypeText;
            if (action is MouseAction)
            {
                var mouseAction = (MouseAction)action;
                item.X = mouseAction.X;
                item.Y = mouseAction.Y;
                item.Button = _mouseButtons[mouseAction.Button];
            }
            else if (action is KeyboardAction)
            {
                var keyboardAction = (KeyboardAction)action;
                item.Button = keyboardAction.KeyValue.ToString();
            }
            else
            {
                throw new Exception("unrecognized type");
            }

            Controls.Add(item);
        }

        public void ClearActions()
        {
            Controls.Clear();
            _currentId = 0;
        }

        public List<MyAction> GetActions()
        {
            var mouseHint = new MouseAction();
            var actions = new List<MyAction>();
            foreach (Control control in Controls)
            {
                var historyElemControl = control as MacrosHistoryElemControl;
                if (historyElemControl != null)
                {
                    MyAction myAction;
                    if (historyElemControl.TypeText == mouseHint.TypeText)
                    {
                        var action = new MouseAction();
                        action.X = historyElemControl.X;
                        action.Y = historyElemControl.Y;
                        action.Button = _mouseButtons.Single(x => x.Value == historyElemControl.Button).Key;
                        myAction = action;
                    }
                    else
                    {
                        var action = new KeyboardAction();
                        action.KeyValue = Int32.Parse(historyElemControl.Button);
                        myAction = action;
                    }

                    myAction.Count = historyElemControl.Count;
                    myAction.Delay = historyElemControl.Delay;
                    actions.Add(myAction);
                }
            }
            return actions;
        }
    }
}
