namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WSADATA
    {
        public short wVersion;
        public short wHighVersion;
        public ushort iMaxSockets;
        public ushort iMaxUdpDg;
        public char szDescription;

    }



}