﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacrosApp
{
    static class programm
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Run(new MainForm());
        }
    }
}
