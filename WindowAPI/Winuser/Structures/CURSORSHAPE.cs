
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CURSORSHAPE
    {
        public IntPtr xHotSpot;
        public IntPtr yHotSpot;
        public IntPtr cx;
        public IntPtr cy;
        public IntPtr cbWidth;
        public IntPtr Planes;
        public IntPtr BitsPixel;
    }



}