namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct HEAP_OPTIMIZE_RESOURCES_INFORMATION
    {
        public uint Version;
        public uint Flags;
    }



}