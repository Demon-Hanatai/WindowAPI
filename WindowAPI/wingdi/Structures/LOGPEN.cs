namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LOGPEN
    {
        public uint lopnStyle;
        public POINT lopnWidth;
        public int lopnColor;
    }



}