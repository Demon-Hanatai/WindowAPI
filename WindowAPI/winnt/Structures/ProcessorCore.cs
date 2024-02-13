namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ProcessorCore
    {
        public int ProcessorMask;
        public nint Relationship;
        public byte Flags;
        public uint NodeNumber;
        public CACHE_DESCRIPTOR Cache;
        public int Reserved;
    }



}