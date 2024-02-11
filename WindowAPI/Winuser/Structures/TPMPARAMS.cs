
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TPMPARAMS
    {
        public IntPtr cbSize;
        public IntPtr rcExclude;
    }



}