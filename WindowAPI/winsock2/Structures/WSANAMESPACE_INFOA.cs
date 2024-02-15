namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WSANAMESPACE_INFOA
    {
        public LUID NSProviderId;
        public uint dwNameSpace;
        public bool fActive;
        public uint dwVersion;
        public string lpszIdentifier;
    }



}