namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct JOBOBJECT_SECURITY_LIMIT_INFORMATION
    {
        public uint SecurityLimitFlags;
        public nint JobToken;
        public int SidsToDisable;
        public int PrivilegesToDelete;
        public int RestrictedSids;
    }



}