namespace WindowAPI.winnt.Structures
{


    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IMAGE_NT_HEADERS32
    {
        public uint Signature;
        public IMAGE_FILE_HEADER FileHeader;
        public nint OptionalHeader;
    }



}