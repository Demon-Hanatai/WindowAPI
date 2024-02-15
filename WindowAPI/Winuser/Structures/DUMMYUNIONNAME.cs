namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DUMMYUNIONNAME
    {
        public uint cbSize;
        public uint dwType;
        public int mouse;
        public int keyboard;
        public nint hid;
    }



}