
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct BSMINFO
    {
        public IntPtr cbSize;
        public IntPtr hdesk;
        public IntPtr hwnd;
        public IntPtr luid;
    }



}