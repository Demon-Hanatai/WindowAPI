
//Auto Create-#=
using System.Runtime.InteropServices;


namespace WindowAPI.Winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACCEL
    {
        public IntPtr fVirt;
        public short key;
        public short cmd;

    }



}