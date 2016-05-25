using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace mcontrol.LOV
{
    public class MoveWinDowHelper
    {
        struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT rect);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        static extern void MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public static void MoveWindow2(IntPtr handle, int X, int Y, bool b)
        {
            RECT Rect = new RECT();

            GetWindowRect(handle, ref Rect);
            MoveWindow(handle, X, Y, Rect.right - Rect.left, Rect.bottom - Rect.top, b);
        }
    }
}
