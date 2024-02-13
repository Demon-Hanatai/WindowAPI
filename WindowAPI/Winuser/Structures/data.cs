namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct data
    {
        public IntPtr header;
        public int mouse;
        public int keyboard;
        public RAWHID hid;
    }



}