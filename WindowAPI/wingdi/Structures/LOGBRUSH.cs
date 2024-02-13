namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LOGBRUSH
    {
        public uint lbStyle;
        public int lbColor;
        public int lbHatch;
    }



}