
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MULTIKEYHELPW
    {
        public uint mkSize;
        public IntPtr mkKeylist;
    }



}