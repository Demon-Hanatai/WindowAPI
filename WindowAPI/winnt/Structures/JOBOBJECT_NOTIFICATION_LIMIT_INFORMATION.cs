namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION
    {
        public uint IoReadBytesLimit;
        public uint IoWriteBytesLimit;
        public int PerJobUserTimeLimit;
        public uint JobMemoryLimit;
        public int RateControlTolerance;
        public int RateControlToleranceInterval;
        public uint LimitFlags;
    }



}