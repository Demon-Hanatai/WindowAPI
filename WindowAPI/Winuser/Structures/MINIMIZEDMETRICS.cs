
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MINIMIZEDMETRICS
    {
        public IntPtr cbSize;
        public IntPtr iWidth;
        public IntPtr iHorzGap;
        public IntPtr iVertGap;
        public IntPtr iArrange;
    }



}