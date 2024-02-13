namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GLYPHSET
    {
        public uint cbThis;
        public uint flAccel;
        public uint cGlyphsSupported;
        public uint cRanges;
        public WCRANGE ranges;
    }



}