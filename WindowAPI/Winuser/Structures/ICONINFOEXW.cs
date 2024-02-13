namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ICONINFOEXW
    {
        public uint cbSize;
        public bool fIcon;
        public uint xHotspot;
        public uint yHotspot;
        public IntPtr hbmMask;
        public IntPtr hbmColor;
        public short wResID;
        public StringBuilder szModName;
        public StringBuilder szResName;
    }



}