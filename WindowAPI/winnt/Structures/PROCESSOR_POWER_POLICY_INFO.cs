namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PROCESSOR_POWER_POLICY_INFO
    {
        public uint TimeCheck;
        public uint DemoteLimit;
        public uint PromoteLimit;
        public byte DemotePercent;
        public byte PromotePercent;
        public byte Spare;
    }



}