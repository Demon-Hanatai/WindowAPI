namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CREATESTRUCTW
    {
        public IntPtr lpCreateParams;
        public IntPtr hInstance;
        public IntPtr hMenu;
        public IntPtr hwndParent;
        public int cy;
        public int cx;
        public int y;
        public int x;
        public int style;
        public string lpszName;
        public string lpszClass;
        public uint dwExStyle;
    }



}