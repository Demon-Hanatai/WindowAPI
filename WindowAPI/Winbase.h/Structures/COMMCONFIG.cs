using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COMMCONFIG
    {
        public uint dwSize;
        public uint wVersion;
        public uint wReserved;
        public int dcb;
        public uint dwProviderSubType;
        public uint dwProviderOffset;
        public uint dwProviderSize;
    }



}