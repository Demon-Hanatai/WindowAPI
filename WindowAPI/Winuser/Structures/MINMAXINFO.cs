
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MINMAXINFO
    {
        public IntPtr ptReserved;
        public IntPtr ptMaxSize;
        public IntPtr ptMaxPosition;
        public IntPtr ptMinTrackSize;
        public IntPtr ptMaxTrackSize;
    }



}