namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DEBUGHOOKINFO
    {
        public uint idThread;
        public uint idThreadInstaller;
        public IntPtr lParam;
        public IntPtr wParam;
        public int code;
    }



}