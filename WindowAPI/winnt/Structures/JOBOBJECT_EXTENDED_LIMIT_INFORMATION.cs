namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct JOBOBJECT_EXTENDED_LIMIT_INFORMATION
    {
        public JOBOBJECT_BASIC_LIMIT_INFORMATION BasicLimitInformation;
        public IO_COUNTERS IoInfo;
        public int ProcessMemoryLimit;
        public int JobMemoryLimit;
        public int PeakProcessMemoryUsed;
        public int PeakJobMemoryUsed;
    }



}