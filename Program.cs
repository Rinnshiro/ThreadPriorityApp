using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ThreadPriorityApp
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [STAThread]
        private static void Main()
        {
            AllocConsole();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTrackThread());
        }
    }
}
