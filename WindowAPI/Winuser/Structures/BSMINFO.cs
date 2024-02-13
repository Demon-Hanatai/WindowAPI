namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct BSMINFO
    {
        public uint cbSize;
        public IntPtr hdesk;
        public IntPtr hwnd;
        public LUID luid;
    }



}