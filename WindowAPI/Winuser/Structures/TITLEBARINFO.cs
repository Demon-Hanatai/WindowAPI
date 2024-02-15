namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TITLEBARINFO
    {
        public uint cbSize;
        public RECT rcTitleBar;
        public uint rgstate;
    }



}