namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DEBUGHOOKINFO
    {
        public uint idThread;
        public uint idThreadInstaller;
        public nint lParam;
        public nint wParam;
        public int code;
    }



}