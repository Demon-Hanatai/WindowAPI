namespace WindowAPI.minwinbase.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Block
    {
        public nint lpData;
        public uint cbData;
        public byte cbOverhead;
        public byte iRegionIndex;
        public short wFlags;
        public nint hMem;
        public uint dwReserved;
        public uint dwCommittedSize;
        public uint dwUnCommittedSize;
        public nint lpFirstBlock;
        public nint lpLastBlock;
    }



}