﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ch.romibi.Scrap.Packed.Explorer
{
    class MainApp
    {
        [STAThread]
        public static int Main(string[] args)
        {
            var guiApp = new GuiApp();
            guiApp.InitializeComponent();
            guiApp.Run();
            return 0;
        }
    }
}
