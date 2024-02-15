namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ICONMETRICSA
    {
        public uint cbSize;
        public int iHorzSpacing;
        public int iVertSpacing;
        public int iTitleWrap;
        public LOGFONTA lfFont;
    }



}