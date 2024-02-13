namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SID
    {
        public byte Revision;
        public byte SubAuthorityCount;
        public nint IdentifierAuthority;
    }



}