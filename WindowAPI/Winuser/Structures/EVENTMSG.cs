namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct EVENTMSG
    {
        public uint message;
        public uint paramL;
        public uint paramH;
        public uint time;
        public IntPtr hwnd;
    }



}