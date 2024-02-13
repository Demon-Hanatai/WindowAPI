namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PRIVILEGE_SET
    {
        public uint PrivilegeCount;
        public uint Control;
        public LUID_AND_ATTRIBUTES Privilege;
    }



}