namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct JOBOBJECT_LIMIT_VIOLATION_INFORMATION
    {
        public uint LimitFlags;
        public uint ViolationLimitFlags;
        public uint IoReadBytes;
        public uint IoReadBytesLimit;
        public uint IoWriteBytes;
        public uint IoWriteBytesLimit;
        public int PerJobUserTime;
        public int PerJobUserTimeLimit;
        public uint JobMemory;
        public uint JobMemoryLimit;
        public int RateControlTolerance;
        public int RateControlToleranceLimit;
    }



}