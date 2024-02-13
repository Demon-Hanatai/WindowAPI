namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FILE_COMPRESSION_INFO
    {
        public int CompressedFileSize;
        public uint CompressionFormat;
        public char CompressionUnitShift;
        public char ChunkShift;
        public char ClusterShift;
    }



}