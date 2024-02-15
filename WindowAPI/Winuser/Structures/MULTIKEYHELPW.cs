namespace WindowAPI.winuser.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MULTIKEYHELPW
    {
        public uint mkSize;
        public StringBuilder mkKeylist;
        public StringBuilder szKeyphrase;
    }



}