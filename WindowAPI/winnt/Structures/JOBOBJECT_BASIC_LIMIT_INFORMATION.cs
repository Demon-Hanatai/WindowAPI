namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct JOBOBJECT_BASIC_LIMIT_INFORMATION
    {
        public int PerProcessUserTimeLimit;
        public int PerJobUserTimeLimit;
        public uint LimitFlags;
        public int MinimumWorkingSetSize;
        public int MaximumWorkingSetSize;
        public uint ActiveProcessLimit;
        public int Affinity;
        public uint PriorityClass;
        public uint SchedulingClass;
    }



}