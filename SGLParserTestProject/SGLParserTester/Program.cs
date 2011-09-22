using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGLTest;

namespace WindowsFormsApplication4
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SimpleSGLEditor());
        }
    }
}
