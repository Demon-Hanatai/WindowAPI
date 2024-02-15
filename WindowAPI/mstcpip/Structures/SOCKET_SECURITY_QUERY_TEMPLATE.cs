using WindowAPI.mstcpip.Enums;

namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SOCKET_SECURITY_QUERY_TEMPLATE
    {
        public _SOCKET_SECURITY_PROTOCOL SecurityProtocol;
        public SOCKADDR_IRDA PeerAddress;
        public uint PeerTokenAccessMask;
    }



}