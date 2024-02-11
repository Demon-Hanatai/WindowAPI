
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CURSORINFO
    {
        public uint cbSize;
        public uint flags;
        public IntPtr hCursor;
        public IntPtr ptScreenPos;
    }



}