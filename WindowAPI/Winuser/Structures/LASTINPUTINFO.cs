
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LASTINPUTINFO
    {
        public IntPtr cbSize;
        public uint dwTime;
    }



}