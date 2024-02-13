namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TAPE_WRITE_MARKS
    {
        public uint Type;
        public uint Count;
        public bool Immediate;
    }



}