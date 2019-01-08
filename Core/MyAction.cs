using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacrosApp.Core
{
    public class MyAction
    {
        public int Id { get; set; }
        public bool IsMouseClick { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public double Delay { get; set; }
        public int Count { get; set; }
        public MouseButtons Button { get; set; }
    }
}
