namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IMAGE_FUNCTION_ENTRY
    {
        public uint StartingAddress;
        public uint EndingAddress;
        public uint EndOfPrologue;
    }



}