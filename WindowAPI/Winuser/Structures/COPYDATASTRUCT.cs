
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COPYDATASTRUCT
    {
        public IntPtr dwData;
        public uint cbData;
        public IntPtr lpData;
    }



}