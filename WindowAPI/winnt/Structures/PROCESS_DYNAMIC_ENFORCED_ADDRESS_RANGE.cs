namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE
    {
        public int BaseAddress;
        public int Size;
        public uint Flags;
    }



}