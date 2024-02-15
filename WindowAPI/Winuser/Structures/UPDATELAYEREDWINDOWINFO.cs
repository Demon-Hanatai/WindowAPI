namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct UPDATELAYEREDWINDOWINFO
    {
        public uint cbSize;
        public nint hdcDst;
        public nint hdcSrc;
        public int crKey;
        public uint dwFlags;
    }



}