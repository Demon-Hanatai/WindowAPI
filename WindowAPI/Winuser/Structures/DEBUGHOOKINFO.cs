
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DEBUGHOOKINFO
    {
        public uint idThread;
        public uint idThreadInstaller;
        public IntPtr lParam;
        public IntPtr wParam;
        public IntPtr code;
    }



}