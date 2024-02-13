namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TITLEBARINFOEX
    {
        public uint cbSize;
        public RECT rcTitleBar;
        public uint rgstate;
        public RECT rgrect;
    }



}