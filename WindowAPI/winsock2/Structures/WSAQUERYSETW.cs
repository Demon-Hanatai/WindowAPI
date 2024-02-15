namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WSAQUERYSETW
    {
        public uint dwSize;
        public string lpszServiceInstanceName;
        public nint lpServiceClassId;
        public string lpVersion;
        public string lpszComment;
        public uint dwNameSpace;
        public nint lpNSProviderId;
        public string lpszContext;
        public uint dwNumberOfProtocols;
        public AFPROTOCOLS lpafpProtocols;
        public string lpszQueryString;
        public uint dwNumberOfCsAddrs;
        public CHAR_INFO lpcsaBuffer;
        public uint dwOutputFlags;
        public BLOB lpBlob;
    }



}