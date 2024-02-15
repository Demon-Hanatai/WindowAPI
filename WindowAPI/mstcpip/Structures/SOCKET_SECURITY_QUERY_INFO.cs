namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SOCKET_SECURITY_QUERY_INFO
    {
        public _SOCKET_SECURITY_PROTOCOL SecurityProtocol;
        public uint Flags;
        public uint PeerApplicationAccessTokenHandle;
        public uint PeerMachineAccessTokenHandle;
    }



}