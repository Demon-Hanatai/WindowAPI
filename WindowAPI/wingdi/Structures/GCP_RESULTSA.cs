namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GCP_RESULTSA
    {
        public uint lStructSize;
        public string lpOutString;
        public string lpClass;
        public string lpGlyphs;
        public uint nGlyphs;
        public int nMaxFit;
    }



}