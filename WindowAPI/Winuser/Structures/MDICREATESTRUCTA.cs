namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MDICREATESTRUCTA
    {
        public string szClass;
        public string szTitle;
        public IntPtr hOwner;
        public int x;
        public int y;
        public int cx;
        public int cy;
        public uint style;
        public IntPtr lParam;
    }



}