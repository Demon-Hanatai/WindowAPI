namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HARDWARE_COUNTER_DATA
    {
        public nint Type;
        public uint Reserved;
        public uint Value;
    }



}