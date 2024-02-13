namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PROCESSOR_GROUP_INFO
    {
        public byte MaximumProcessorCount;
        public byte ActiveProcessorCount;
        public byte Reserved;
        public int ActiveProcessorMask;
    }



}