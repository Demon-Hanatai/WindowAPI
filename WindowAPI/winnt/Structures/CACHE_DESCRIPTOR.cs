namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CACHE_DESCRIPTOR
    {
        public byte Level;
        public byte Associativity;
        public short LineSize;
        public uint Size;
        public nint Type;
    }



}