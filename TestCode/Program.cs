using WindowAPI.windef.Structures;
using WindowAPI.winuser.h.Structures;
using static WindowAPI.wingdi.Functions;
using static WindowAPI.winuser.h.Functions;

class Program
{

    static unsafe void Main()
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
        nint m = CreateWindowExW(0, "Button", "OK", WS_VISIBLE | WS_TABSTOP | WS_CHILD, 20, 20, 40, 50, d, 0, 0, 0);
        int blueColor = 0xFF0000; // Blue color in RGB
        IntPtr hBrush = CreateSolidBrush(blueColor);
        ShowWindow(d, 1);
        ShowWindow(m, 1);


        SetClassLongPtrA(d, -10, hBrush.ToInt32());
        var mee = new RECT();
        InvalidateRect(d, *(RECT*)&mee, true);
        UpdateWindow(d);
        UpdateColors(d);


        while (GetMessageA(out MSG de, d, 0, 0))
        {

        }
    }
}
