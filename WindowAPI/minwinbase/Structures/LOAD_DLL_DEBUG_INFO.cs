namespace WindowAPI.minwinbase.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LOAD_DLL_DEBUG_INFO
    {
        public nint hFile;
        public nint lpBaseOfDll;
        public uint dwDebugInfoFileOffset;
        public uint nDebugInfoSize;
        public nint lpImageName;
        public short fUnicode;
    }



}