namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MESSAGE_RESOURCE_BLOCK
    {
        public uint LowId;
        public uint HighId;
        public uint OffsetToEntries;
    }



}