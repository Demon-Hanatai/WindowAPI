namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DLGITEMTEMPLATE
    {
        public uint style;
        public uint dwExtendedStyle;
        public short x;
        public short y;
        public short cx;
        public short cy;
        public short id;
    }



}