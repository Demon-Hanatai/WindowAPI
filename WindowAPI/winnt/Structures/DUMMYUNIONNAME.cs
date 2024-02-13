namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DUMMYUNIONNAME
    {
        public nint Relationship;
        public uint Size;
        public PROCESSOR_RELATIONSHIP Processor;
        public nint NumaNode;
        public nint Cache;
        public GROUP_RELATIONSHIP Group;
    }



}