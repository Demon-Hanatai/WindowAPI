
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MOUSEMOVEPOINT
    {
        public IntPtr x;
        public IntPtr y;
        public uint time;
        public IntPtr dwExtraInfo;
    }



}