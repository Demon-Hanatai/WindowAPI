
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MENUBARINFO
    {
        public uint cbSize;
        public IntPtr rcBar;
        public IntPtr hMenu;
        public IntPtr hwndMenu;
    }



}