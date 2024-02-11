
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MDICREATESTRUCTA
    {
        public string szClass;
        public string szTitle;
        public IntPtr hOwner;
        public IntPtr x;
        public IntPtr y;
        public IntPtr cx;
        public IntPtr cy;
        public uint style;
        public IntPtr lParam;
    }



}