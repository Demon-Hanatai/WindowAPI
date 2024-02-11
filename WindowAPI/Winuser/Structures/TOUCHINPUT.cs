
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOUCHINPUT
    {
        public int x;
        public int y;
        public IntPtr hSource;
        public uint dwID;
        public uint dwFlags;
        public uint dwMask;
        public uint dwTime;
        public IntPtr dwExtraInfo;
        public uint cxContact;
        public uint cyContact;
    }



}