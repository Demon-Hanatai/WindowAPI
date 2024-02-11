
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MENUINFO
    {
        public uint cbSize;
        public uint fMask;
        public uint dwStyle;
        public IntPtr cyMax;
        public IntPtr hbrBack;
        public uint dwContextHelpID;
        public IntPtr dwMenuData;
    }



}