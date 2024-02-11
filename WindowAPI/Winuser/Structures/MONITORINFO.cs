
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MONITORINFO
    {
        public uint cbSize;
        public IntPtr rcMonitor;
        public IntPtr rcWork;
        public uint dwFlags;
    }



}