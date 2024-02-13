namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MOUSEMOVEPOINT
    {
        public int x;
        public int y;
        public uint time;
        public int dwExtraInfo;
    }



}