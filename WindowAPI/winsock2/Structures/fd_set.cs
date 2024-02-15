namespace WindowAPI.winsock2.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct fd_set
    {
        public uint fd_count;
        public short fd_array;
    }



}