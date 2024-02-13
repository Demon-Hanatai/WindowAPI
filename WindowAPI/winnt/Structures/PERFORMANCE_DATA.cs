namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PERFORMANCE_DATA
    {
        public short Size;
        public byte Version;
        public byte HwCountersCount;
        public uint ContextSwitchCount;
        public uint WaitReasonBitMap;
        public uint CycleTime;
        public uint RetryCount;
        public uint Reserved;
        public HARDWARE_COUNTER_DATA HwCounters;
    }



}