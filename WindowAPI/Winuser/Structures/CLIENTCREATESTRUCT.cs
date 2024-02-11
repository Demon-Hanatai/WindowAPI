
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CLIENTCREATESTRUCT
    {
        public IntPtr hWindowMenu;
        public IntPtr idFirstChild;
    }



}