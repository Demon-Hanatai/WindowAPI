
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SCROLLBARINFO
    {
        public uint cbSize;
        public IntPtr rcScrollBar;
        public IntPtr dxyLineButton;
        public IntPtr xyThumbTop;
        public IntPtr xyThumbBottom;
        public IntPtr reserved;
    }



}