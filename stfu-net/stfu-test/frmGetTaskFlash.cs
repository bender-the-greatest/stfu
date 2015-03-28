using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using System.Runtime.InteropServices;

namespace stfu_tray
{
    public partial class frmGetTaskFlash : Form
    {
        #region user32.dll stuff
        public enum HookType : int
        {
            WH_JOURNALRECORD = 0,
            WH_JOURNALPLAYBACK = 1,
            WH_KEYBOARD = 2,
            WH_GETMESSAGE = 3,
            WH_CALLWNDPROC = 4,
            WH_CBT = 5,
            WH_SYSMSGFILTER = 6,
            WH_MOUSE = 7,
            WH_HARDWARE = 8,
            WH_DEBUG = 9,
            WH_SHELL = 10,
            WH_FOREGROUNDIDLE = 11,
            WH_CALLWNDPROCRET = 12,
            WH_KEYBOARD_LL = 13,
            WH_MOUSE_LL = 14
        }

        delegate IntPtr HookProc(int code, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetWindowsHookEx(HookType hookType, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        #endregion

        private bool mTestFlash = false;

        public frmGetTaskFlash()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            // Toggle checking for flashing taskbar buttons
            switch (mTestFlash = !mTestFlash)
            {
                case true:
                    uint dwID
                    break;
                case false:
                    break;
            }
            
        }

        private static List<IntPtr> GetTaskbarHWNDs()
        {
            //List<IntPtr> hwnds = new List<IntPtr>();
            //foreach (Process p in Process.GetProcesses())
            //{
            //    // This is dirty, assumes if there is no window title
            //    // then it is not a taskbar process
            //    if (!string.IsNullOrEmpty(p.MainWindowTitle))
            //        hwnds.Add(p.MainWindowHandle);
            //}
            //return hwnds;
        }
    }
}
