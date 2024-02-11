
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HARDWAREINPUT
    {
        public uint uMsg;
        public short wParamL;
        public short wParamH;
    }



}