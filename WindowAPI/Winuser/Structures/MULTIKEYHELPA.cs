namespace WindowAPI.winuser.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MULTIKEYHELPA
    {
        public uint mkSize;
        public char mkKeylist;
        public char szKeyphrase;
    }



}