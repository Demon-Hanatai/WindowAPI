namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TTPOLYCURVE
    {
        public short wType;
        public short cpfx;
        public POINTFX apfx;
    }



}