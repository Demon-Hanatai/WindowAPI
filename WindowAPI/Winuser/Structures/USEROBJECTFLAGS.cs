namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct USEROBJECTFLAGS
    {
        public bool fInherit;
        public bool fReserved;
        public uint dwFlags;
    }



}