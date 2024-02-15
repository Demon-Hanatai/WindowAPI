namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NONCLIENTMETRICSA
    {
        public uint cbSize;
        public int iBorderWidth;
        public int iScrollWidth;
        public int iScrollHeight;
        public int iCaptionWidth;
        public int iCaptionHeight;
        public LOGFONTA lfCaptionFont;
        public int iSmCaptionWidth;
        public int iSmCaptionHeight;
        public LOGFONTA lfSmCaptionFont;
        public int iMenuWidth;
        public int iMenuHeight;
        public LOGFONTA lfMenuFont;
        public LOGFONTA lfStatusFont;
        public LOGFONTA lfMessageFont;
        public int iPaddedBorderWidth;
    }



}