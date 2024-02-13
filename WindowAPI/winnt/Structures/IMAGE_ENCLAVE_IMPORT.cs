namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IMAGE_ENCLAVE_IMPORT
    {
        public uint MatchType;
        public uint MinimumSecurityVersion;
        public byte UniqueOrAuthorID;
        public uint ImportName;
        public uint Reserved;
    }



}