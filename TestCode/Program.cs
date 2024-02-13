
using static WindowAPI.Winbase.h.Functions;
using static WindowAPI.winuser.h.Functions;
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

        ShowWindow(d, 1); // SW_SHOWNORMAL = 1, show the window
        while (GetMessageA(out MSG de, d, 0, 0))
        {
           
        }
    }
}
