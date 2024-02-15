namespace WindowAPI.minwinbase.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct CREATE_PROCESS_DEBUG_INFO
    {
        public nint hFile;
        public nint hProcess;
        public nint hThread;
        public nint lpBaseOfImage;
        public uint dwDebugInfoFileOffset;
        public uint nDebugInfoSize;
        public nint lpThreadLocalBase;
        public PFIBERSTARTROUTINE lpStartAddress;
        public nint lpImageName;
        public short fUnicode;
    }



}