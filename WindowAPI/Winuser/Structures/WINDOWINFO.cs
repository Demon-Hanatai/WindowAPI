
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WINDOWINFO
    {
        public uint cbSize;
        public IntPtr rcWindow;
        public IntPtr rcClient;
        public uint dwStyle;
        public uint dwExStyle;
        public uint dwWindowStatus;
        public IntPtr cxWindowBorders;
        public IntPtr cyWindowBorders;
        public IntPtr atomWindowType;
        public short wCreatorVersion;
    }



}