
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FLASHWINFO
    {
        public IntPtr cbSize;
        public IntPtr hwnd;
        public uint dwFlags;
        public IntPtr uCount;
        public uint dwTimeout;
    }



}