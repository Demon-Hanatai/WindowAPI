namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MESSAGE_RESOURCE_DATA
    {
        public uint NumberOfBlocks;
        public MESSAGE_RESOURCE_BLOCK Blocks;
    }



}