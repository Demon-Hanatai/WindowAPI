namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MULTIKEYHELPA
    {
        public uint mkSize;
        public char mkKeylist;
        public char szKeyphrase;
    }



}