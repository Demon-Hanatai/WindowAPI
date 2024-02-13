namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SYSTEM_POWER_STATUS
    {
        public int ACLineStatus;
        public int BatteryFlag;
        public int BatteryLifePercent;
        public int SystemStatusFlag;
        public uint BatteryLifeTime;
        public uint BatteryFullLifeTime;
    }



}