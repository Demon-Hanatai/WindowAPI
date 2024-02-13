namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ALTTABINFO
    {
        public uint cbSize;
        public int cItems;
        public int cColumns;
        public int cRows;
        public int iColFocus;
        public int iRowFocus;
        public int cxItem;
        public int cyItem;
        public POINT ptStart;
    }



}