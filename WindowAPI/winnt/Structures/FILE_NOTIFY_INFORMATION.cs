namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct FILE_NOTIFY_INFORMATION
    {
        public uint NextEntryOffset;
        public uint Action;
        public uint FileNameLength;
        public StringBuilder FileName;
    }



}