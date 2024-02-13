namespace WindowAPI.wingdi.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DRAWPATRECT
    {
        public POINT ptPosition;
        public POINT ptSize;
        public short wStyle;
        public short wPattern;
    }



}