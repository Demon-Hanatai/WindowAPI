namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MEM_ADDRESS_REQUIREMENTS
    {
        public IntPtr LowestStartingAddress;
        public IntPtr HighestEndingAddress;
        public int Alignment;
    }



}