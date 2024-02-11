
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HELPINFO
    {
        public IntPtr cbSize;
        public IntPtr iContextType;
        public IntPtr iCtrlId;
        public IntPtr hItemHandle;
        public IntPtr dwContextId;
        public IntPtr MousePos;
    }



}