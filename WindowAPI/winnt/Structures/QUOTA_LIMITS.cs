namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct QUOTA_LIMITS
    {
        public int PagedPoolLimit;
        public int NonPagedPoolLimit;
        public int MinimumWorkingSetSize;
        public int MaximumWorkingSetSize;
        public int PagefileLimit;
        public int TimeLimit;
    }



}