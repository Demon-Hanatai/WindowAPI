namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct USEROBJECTFLAGS
    {
        public bool fInherit;
        public bool fReserved;
        public uint dwFlags;
    }



}