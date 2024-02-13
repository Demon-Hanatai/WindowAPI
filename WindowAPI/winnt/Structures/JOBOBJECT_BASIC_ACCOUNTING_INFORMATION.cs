namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct JOBOBJECT_BASIC_ACCOUNTING_INFORMATION
    {
        public int TotalUserTime;
        public int TotalKernelTime;
        public int ThisPeriodTotalUserTime;
        public int ThisPeriodTotalKernelTime;
        public uint TotalPageFaultCount;
        public uint TotalProcesses;
        public uint ActiveProcesses;
        public uint TotalTerminatedProcesses;
    }



}