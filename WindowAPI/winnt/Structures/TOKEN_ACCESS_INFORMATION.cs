namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOKEN_ACCESS_INFORMATION
    {
        public nint SidHash;
        public nint RestrictedSidHash;
        public int Privileges;
        public LUID AuthenticationId;
        public int TokenType;
        public int ImpersonationLevel;
        public int MandatoryPolicy;
        public uint Flags;
        public uint AppContainerNumber;
        public int PackageSid;
        public nint CapabilitiesHash;
        public int TrustLevelSid;
        public int SecurityAttributes;
    }



}