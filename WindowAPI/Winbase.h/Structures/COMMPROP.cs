namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct COMMPROP
    {
        public uint wPacketLength;
        public uint wPacketVersion;
        public uint dwServiceMask;
        public uint dwReserved1;
        public uint dwMaxTxQueue;
        public uint dwMaxRxQueue;
        public uint dwMaxBaud;
        public uint dwProvSubType;
        public uint dwProvCapabilities;
        public uint dwSettableParams;
        public uint dwSettableBaud;
        public uint wSettableData;
        public uint wSettableStopParity;
        public uint dwCurrentTxQueue;
        public uint dwCurrentRxQueue;
        public uint dwProvSpec1;
        public uint dwProvSpec2;
    }



}