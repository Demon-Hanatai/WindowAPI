namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct TOKEN_GROUPS_AND_PRIVILEGES
    {
        public uint SidCount;
        public uint SidLength;
        public int Sids;
        public uint RestrictedSidCount;
        public uint RestrictedSidLength;
        public int RestrictedSids;
        public uint PrivilegeCount;
        public uint PrivilegeLength;
        public int Privileges;
        public LUID AuthenticationId;
    }



}