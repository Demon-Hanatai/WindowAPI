namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOUCHINPUT
    {
        public int x;
        public int y;
        public IntPtr hSource;
        public uint dwID;
        public uint dwFlags;
        public uint dwMask;
        public uint dwTime;
        public int dwExtraInfo;
        public uint cxContact;
        public uint cyContact;
    }



}