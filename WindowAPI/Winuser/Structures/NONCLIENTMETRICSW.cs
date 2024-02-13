namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NONCLIENTMETRICSW
    {
        public uint cbSize;
        public int iBorderWidth;
        public int iScrollWidth;
        public int iScrollHeight;
        public int iCaptionWidth;
        public int iCaptionHeight;
        public LOGFONTW lfCaptionFont;
        public int iSmCaptionWidth;
        public int iSmCaptionHeight;
        public LOGFONTW lfSmCaptionFont;
        public int iMenuWidth;
        public int iMenuHeight;
        public LOGFONTW lfMenuFont;
        public LOGFONTW lfStatusFont;
        public LOGFONTW lfMessageFont;
        public int iPaddedBorderWidth;
    }



}