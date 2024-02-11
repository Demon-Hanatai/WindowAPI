using System.Runtime.InteropServices;


namespace WindowAPI.Winbase.h.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FILE_ID_BOTH_DIR_INFO
    {
        public uint NextEntryOffset;
        public uint FileIndex;
        public int CreationTime;
        public int LastAccessTime;
        public int LastWriteTime;
        public int ChangeTime;
        public int EndOfFile;
        public int AllocationSize;
        public uint FileAttributes;
        public uint FileNameLength;
        public uint EaSize;
        public char ShortNameLength;
        public int FileId;
    }



}