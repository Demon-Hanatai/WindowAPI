
using static WindowAPI.Winbase.h.Functions;
using static WindowAPI.winuser.h.Functions;
using static WindowAPI.wingdi.Functions;
using System;
using WindowAPI.winuser.h.Structures;

class Program
{
    
    static void Main()
    {
        IntPtr d = CreateWindowExW(
            0, // Extended window style
            "STATIC", // Predefined class; application determines the class name
            "MAIN WINDOW", // Window name
            0x20000000, // Window style
            200, // X position
            200, // Y position
            600, // Width
            400, // Height
            IntPtr.Zero, // Parent window handle
            IntPtr.Zero, // Menu handle
            IntPtr.Zero, // Instance handle
            IntPtr.Zero); // Additional application data

         // SW_SHOWNORMAL = 1, show the window
        uint WS_VISIBLE = 0x10000000;
        uint WS_TABSTOP = 0x00010000;
        uint WS_CHILD = 0x40000000;
        nint m = CreateWindowExW(0, "Button", "OK", WS_VISIBLE|WS_TABSTOP|WS_CHILD, 20, 20, 40, 50, d, 0, 0, 0);
        int blueColor = 0xFF0000; // Blue color in RGB
        IntPtr hBrush = CreateSolidBrush(blueColor);
        ShowWindow(d, 1);
        ShowWindow(m, 1);
        if (IntPtr.Size == 8)
        {
            // 64-bit application
            SetClassLongPtrA(d, -10, hBrush.ToInt32());
        }
        else
        {
            // 32-bit application
            SetClassLongPtrA(d, -10, hBrush.ToInt32());
        }

       
        while (GetMessageA(out MSG de, d, 0, 0)&& GetMessageA(out MSG e, m, 0, 0))
        {

        }
    }
}
