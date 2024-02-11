
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DRAWTEXTPARAMS
    {
        public IntPtr cbSize;
        public IntPtr iTabLength;
        public IntPtr iLeftMargin;
        public IntPtr iRightMargin;
        public IntPtr uiLengthDrawn;
    }



}