
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DUMMYUNIONNAME
    {
        public uint cbSize;
        public uint dwType;
        public IntPtr mouse;
        public IntPtr keyboard;
        public IntPtr hid;
    }



}