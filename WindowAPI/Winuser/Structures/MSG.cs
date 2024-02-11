
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MSG
    {
        public IntPtr hwnd;
        public IntPtr message;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public IntPtr pt;
        public uint lPrivate;
    }



}