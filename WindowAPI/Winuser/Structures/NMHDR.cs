namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct NMHDR
    {
        public IntPtr hwndFrom;
        public int idFrom;
        public uint code;
    }



}