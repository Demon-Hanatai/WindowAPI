namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ACTIVATION_CONTEXT_QUERY_INDEX
    {
        public uint ulAssemblyIndex;
        public uint ulFileIndexInAssembly;
    }



}