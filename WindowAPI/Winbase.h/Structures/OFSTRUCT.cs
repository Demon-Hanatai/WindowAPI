using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OFSTRUCT
    {
        public int cBytes;
        public int fFixedDisk;
        public uint nErrCode;
        public uint Reserved1;
        public uint Reserved2;
    }



}