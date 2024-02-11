
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CWPSTRUCT
    {
        public IntPtr lParam;
        public IntPtr wParam;
        public IntPtr message;
        public IntPtr hwnd;
    }



}