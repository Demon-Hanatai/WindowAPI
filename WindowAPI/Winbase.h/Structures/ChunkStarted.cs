namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ChunkStarted
    {
        public int Type;
        public uint dwPadding;
        public uint dwStreamNumber;
        public uint dwReserved;
        public IntPtr hSourceFile;
        public IntPtr hDestinationFile;
        public int uliChunkNumber;
        public int uliChunkSize;
        public int uliStreamSize;
        public int uliTotalFileSize;
        public uint dwFlags;

        public int uliStreamBytesTransferred;

        public int uliTotalBytesTransferred;


    }



}