namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct KEYBDINPUT
    {
        public short wVk;
        public short wScan;
        public uint dwFlags;
        public uint time;
        public int dwExtraInfo;
    }



}