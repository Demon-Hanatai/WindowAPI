namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FILE_ID_EXTD_DIR_INFO
    {
        public int NextEntryOffset;
        public int FileIndex;
        public int CreationTime;
        public int LastAccessTime;
        public int LastWriteTime;
        public int ChangeTime;
        public int EndOfFile;
        public int AllocationSize;
        public int FileAttributes;
        public int FileNameLength;
        public int EaSize;
        public int ReparsePointTag;
        public int FileId;
    }



}