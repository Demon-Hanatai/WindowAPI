
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TITLEBARINFO
    {
        public uint cbSize;
        public IntPtr rcTitleBar;
    }



}