namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct RASTERIZER_STATUS
    {
        public short nSize;
        public short wFlags;
        public short nLanguageID;
    }



}