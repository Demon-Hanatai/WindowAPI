namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOKEN_ORIGIN
    {
        public LUID OriginatingLogonSession;
    }



}