using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COMSTAT
    {
        public uint cbInQue;
        public uint cbOutQue;
    }



}