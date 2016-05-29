using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BeerBilling.main;

namespace BeerBilling
{
    static class Program
    {

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        private const int SW_RESTORE = 0x9;
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bCreatedNew;
            using (new Mutex(true, "BeerBilling", out bCreatedNew))
            {
                if (bCreatedNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    var mainForm = new MdiMain();
                    mainForm.ShowFormDangNhap();
                    if (mainForm.LoginSuccess)
                        Application.Run(mainForm);
                }
                else
                {
                    Process current = Process.GetCurrentProcess();
                    foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                    {
                        if (process.Id != current.Id)
                        {
                            if (IsIconic(process.MainWindowHandle))
                            {
                                ShowWindowAsync(process.MainWindowHandle, SW_RESTORE);
                            }
                            SetForegroundWindow(process.MainWindowHandle);
                            break;
                        }
                    }
                }
            }
        }
    }
}
