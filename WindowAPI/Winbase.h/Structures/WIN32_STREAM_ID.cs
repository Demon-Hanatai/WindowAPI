namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct WIN32_STREAM_ID
    {
        public uint dwStreamId;
        public uint dwStreamAttributes;
        public int Size;
        public uint dwStreamNameSize;
    }



}