namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct BATTERY_REPORTING_SCALE
    {
        public uint Granularity;
        public uint Capacity;
    }



}