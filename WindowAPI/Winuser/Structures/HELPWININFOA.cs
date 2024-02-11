
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HELPWININFOA
    {
        public IntPtr wStructSize;
        public IntPtr x;
        public IntPtr y;
        public IntPtr dx;
        public IntPtr dy;
        public IntPtr wMax;
    }



}