namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PROCESSOR_POWER_POLICY
    {
        public uint Revision;
        public byte DynamicThrottle;
        public byte Spare;
        public uint PolicyCount;
        public int Policy;
    }



}