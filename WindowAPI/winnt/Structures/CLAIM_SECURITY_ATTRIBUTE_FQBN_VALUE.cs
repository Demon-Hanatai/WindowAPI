namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE
    {
        public uint Version;
        public string Name;
    }



}