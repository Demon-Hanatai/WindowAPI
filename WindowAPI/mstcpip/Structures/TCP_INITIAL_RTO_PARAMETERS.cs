namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TCP_INITIAL_RTO_PARAMETERS
    {
        public ushort Rtt;
        public char MaxSynRetransmissions;
    }



}