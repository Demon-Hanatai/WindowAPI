namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MDICREATESTRUCTW
    {
        public string szClass;
        public string szTitle;
        public nint hOwner;
        public int x;
        public int y;
        public int cx;
        public int cy;
        public uint style;
        public nint lParam;
    }



}