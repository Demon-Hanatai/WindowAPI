
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct data
    {
        public IntPtr header;
        public IntPtr mouse;
        public IntPtr keyboard;
        public RAWHID hid;
    }



}