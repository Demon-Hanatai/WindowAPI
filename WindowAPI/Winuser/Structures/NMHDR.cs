namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NMHDR
    {
        public nint hwndFrom;
        public int idFrom;
        public uint code;
    }



}