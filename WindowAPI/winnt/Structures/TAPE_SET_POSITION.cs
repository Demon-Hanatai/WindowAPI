namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TAPE_SET_POSITION
    {
        public uint Method;
        public uint Partition;
        public int Offset;
        public bool Immediate;
    }



}