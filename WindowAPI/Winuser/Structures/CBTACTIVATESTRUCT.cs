
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CBTACTIVATESTRUCT
    {
        public bool fMouse;
        public IntPtr hWndActive;
    }



}