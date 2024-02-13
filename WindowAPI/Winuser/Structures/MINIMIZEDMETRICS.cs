namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MINIMIZEDMETRICS
    {
        public uint cbSize;
        public int iWidth;
        public int iHorzGap;
        public int iVertGap;
        public int iArrange;
    }



}