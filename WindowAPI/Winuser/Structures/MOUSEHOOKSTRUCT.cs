
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MOUSEHOOKSTRUCT
    {
        public IntPtr pt;
        public IntPtr hwnd;
        public IntPtr wHitTestCode;
        public IntPtr dwExtraInfo;
    }



}