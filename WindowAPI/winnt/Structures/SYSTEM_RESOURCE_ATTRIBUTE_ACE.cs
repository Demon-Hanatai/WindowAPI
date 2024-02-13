namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SYSTEM_RESOURCE_ATTRIBUTE_ACE
    {
        public ACE_HEADER Header;
        public int Mask;
        public uint SidStart;
    }



}