namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SOCKET_PEER_TARGET_NAME
    {
        public _SOCKET_SECURITY_PROTOCOL SecurityProtocol;
        public SOCKADDR_IRDA PeerAddress;
        public uint PeerTargetNameStringLen;
        public string AllStrings;
    }



}