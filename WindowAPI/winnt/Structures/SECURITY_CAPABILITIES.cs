namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SECURITY_CAPABILITIES
    {
        public int AppContainerSid;
        public int Capabilities;

        public uint CapabilityCount;
        public uint Reserved;
    }



}