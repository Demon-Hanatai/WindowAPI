
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MENUGETOBJECTINFO
    {
        public uint dwFlags;
        public IntPtr uPos;
        public IntPtr hmenu;
        public IntPtr riid;
        public IntPtr pvObj;
    }



}