
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MDINEXTMENU
    {
        public IntPtr hmenuIn;
        public IntPtr hmenuNext;
        public IntPtr hwndNext;
    }



}