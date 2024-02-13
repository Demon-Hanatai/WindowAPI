namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GenericReparseBuffer
    {
        public uint ReparseTag;
        public short ReparseDataLength;
        public short Reserved;
        public int ReparseGuid;
        public byte DataBuffer;
    }



}