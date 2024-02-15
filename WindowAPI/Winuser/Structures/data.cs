namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct data
    {
        public nint header;
        public int mouse;
        public int keyboard;
        public RAWHID hid;
    }



}