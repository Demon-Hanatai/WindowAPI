namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PSFEATURE_CUSTPAPER
    {
        public int lOrientation;
        public int lWidth;
        public int lHeight;
        public int lWidthOffset;
        public int lHeightOffset;
    }



}