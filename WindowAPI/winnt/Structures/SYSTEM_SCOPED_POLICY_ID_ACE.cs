namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SYSTEM_SCOPED_POLICY_ID_ACE
    {
        public ACE_HEADER Header;
        public int Mask;
        public uint SidStart;
    }



}