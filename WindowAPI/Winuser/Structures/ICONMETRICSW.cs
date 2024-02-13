namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ICONMETRICSW
    {
        public uint cbSize;
        public int iHorzSpacing;
        public int iVertSpacing;
        public int iTitleWrap;
        public LOGFONTW lfFont;
    }



}