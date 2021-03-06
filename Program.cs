﻿using AppTools;
using System;
using System.Windows.Forms;

namespace JsonViewer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationQueue.InstanceAddFormQueue(new JsonLoader());
            ApplicationQueue.RunApplicationQueue();
        }
    }
}