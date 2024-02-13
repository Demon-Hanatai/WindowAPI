namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOKEN_CONTROL
    {
        public LUID TokenId;
        public LUID AuthenticationId;
        public LUID ModifiedId;
        public int TokenSource;
    }



}