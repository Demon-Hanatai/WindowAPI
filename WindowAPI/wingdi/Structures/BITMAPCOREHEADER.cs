namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct BITMAPCOREHEADER
    {
        public uint bcSize;
        public short bcWidth;
        public short bcHeight;
        public short bcPlanes;
        public short bcBitCount;
    }



}