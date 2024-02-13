namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SYSTEM_POWER_LEVEL
    {
        public bool Enable;
        public byte Spare;
        public uint BatteryLevel;
        public POWER_ACTION_POLICY PowerPolicy;
        public int MinSystemState;
    }



}