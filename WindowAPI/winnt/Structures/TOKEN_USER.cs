namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOKEN_USER
    {
        public SID_AND_ATTRIBUTES User;
    }



}