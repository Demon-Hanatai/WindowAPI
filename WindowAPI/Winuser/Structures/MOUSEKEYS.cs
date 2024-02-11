
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MOUSEKEYS
    {
        public IntPtr cbSize;
        public uint dwFlags;
        public uint iMaxSpeed;
        public uint iTimeToMaxSpeed;
        public uint iCtrlSpeed;
        public uint dwReserved1;
        public uint dwReserved2;
    }



}