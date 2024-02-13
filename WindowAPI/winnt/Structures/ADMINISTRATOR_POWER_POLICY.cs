namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ADMINISTRATOR_POWER_POLICY
    {
        public int MinSleep;
        public int MaxSleep;
        public uint MinVideoTimeout;
        public uint MaxVideoTimeout;
        public uint MinSpindownTimeout;
        public uint MaxSpindownTimeout;
    }



}