
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SCROLLINFO
    {
        public IntPtr cbSize;
        public IntPtr fMask;
        public IntPtr nMin;
        public IntPtr nMax;
        public IntPtr nPage;
        public IntPtr nPos;
        public IntPtr nTrackPos;
    }



}