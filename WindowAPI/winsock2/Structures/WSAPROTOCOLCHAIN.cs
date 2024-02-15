namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WSAPROTOCOLCHAIN
    {
        public int ChainLen;
        public uint ChainEntries;
    }



}