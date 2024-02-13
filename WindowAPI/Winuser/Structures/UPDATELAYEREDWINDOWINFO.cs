namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct UPDATELAYEREDWINDOWINFO
    {
        public uint cbSize;
        public IntPtr hdcDst;
        public IntPtr hdcSrc;
        public int crKey;
        public uint dwFlags;
    }



}