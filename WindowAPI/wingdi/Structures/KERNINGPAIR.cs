namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct KERNINGPAIR
    {
        public short wFirst;
        public short wSecond;
        public int iKernAmount;
    }



}