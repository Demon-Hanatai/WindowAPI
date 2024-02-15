namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct INET_PORT_RANGE
    {
        public ushort StartPort;
        public ushort NumberOfPorts;
    }



}