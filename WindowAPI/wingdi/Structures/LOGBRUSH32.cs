namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LOGBRUSH32
    {
        public uint lbStyle;
        public int lbColor;
        public uint lbHatch;
    }



}