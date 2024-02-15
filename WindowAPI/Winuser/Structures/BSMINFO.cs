namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct BSMINFO
    {
        public uint cbSize;
        public nint hdesk;
        public nint hwnd;
        public LUID luid;
    }



}