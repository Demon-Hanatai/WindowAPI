
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ICONMETRICSW
    {
        public IntPtr cbSize;
        public IntPtr iHorzSpacing;
        public IntPtr iVertSpacing;
        public IntPtr iTitleWrap;
        public IntPtr lfFont;
    }



}