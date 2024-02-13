namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WCRANGE
    {
        public StringBuilder wcLow;
        public ushort cGlyphs;
    }



}