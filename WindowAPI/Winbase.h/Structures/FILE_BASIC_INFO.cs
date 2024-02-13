namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FILE_BASIC_INFO
    {
        public int CreationTime;
        public int LastAccessTime;
        public int LastWriteTime;
        public int ChangeTime;
        public uint FileAttributes;
    }



}