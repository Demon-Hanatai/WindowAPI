namespace WindowAPI.mstcpip.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TIMESTAMPING_CONFIG
    {
        public uint Flags;
        public ushort TxTimestampsBuffered;
    }



}