namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOKEN_SOURCE
    {
        public char SourceName;
        public LUID SourceIdentifier;
    }



}