
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WINDOWPLACEMENT
    {
        public IntPtr length;
        public IntPtr flags;
        public IntPtr showCmd;
        public IntPtr ptMinPosition;
        public IntPtr ptMaxPosition;
        public IntPtr rcNormalPosition;
        public IntPtr rcDevice;
    }



}