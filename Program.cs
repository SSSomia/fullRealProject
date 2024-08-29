﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullRealProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!EventLog.SourceExists(currentSourceNameLog.sourceName))
            {
                EventLog.CreateEventSource(currentSourceNameLog.sourceName, "Application");
            }           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginScreen());
        }
    }
}
