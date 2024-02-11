
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EVENTMSG
    {
        public IntPtr message;
        public IntPtr paramL;
        public IntPtr paramH;
        public uint time;
        public IntPtr hwnd;
    }



}