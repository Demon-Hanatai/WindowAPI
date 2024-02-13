namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct BITMAPFILEHEADER
    {
        public short bfType;
        public uint bfSize;
        public short bfReserved1;
        public short bfReserved2;
        public uint bfOffBits;
    }



}